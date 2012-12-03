using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Grafic.Boxes;
using Grafic.MyGrafics;
using System.Runtime.Serialization.Formatters.Binary;

namespace Grafic
{
    public partial class MainForm : Form
    {

        #region 1.Variables
        //Global        
        public static Bitmap g_bmDrawingPaper;     //A bitmap that runs in the memory as a painting paper.
        public static Bitmap g_bmBackground;         //Create A bitmap as the background when you new or open a file
        public static Bitmap g_bmCache;                //A special space of 1*1 bitmap for keeping the cursor color on the screen
        public static int g_intPaperWidth;
        public static int g_intPaperHeight;

        public static bool g_blFileIsNewed;             //   0               1              0              1
        public static bool g_blFileIsOpened;            //   1               0              0              1
                                                                       //Open          New        No File     Impossible

        public static bool g_blFileHasBeenEdited;    //Whether the current file has been edited by Grafic.
                                                                       //It will be set up in the MouseUpEvent.
        public static bool g_blToolBoxIsShow;         //Contol the three box-windows between form and form
        public static bool g_blInfoBoxIsShow;          //Bool value means the two states of each box window:Show or Hide
        public static bool g_blColorBoxIsShow;
        public static bool g_blLayerBoxIsShow;

        public static List<Shape> g_lstShapeList;              //A List of Created Shape.It can be visted anywhere in the program.
        public static List<Shape> g_lstSelectedShapeList;  //A List of selected Shape.
        public static int g_intNumberOfShape;
        public static Rectangle g_rtAdjustingRect;            //Rectangle for adjusting area

    
        //Member
        private ToolBoxForm frmToolBox;                   //Institations of forms
        private InfoBoxForm frmInfoBox;
        private ColorBoxForm frmColorBox;
        private LayerBoxForm frmLayerBox;
        private OptionBoxForm frmOptionBox;

        private string m_strOpenFileName;                    //Gives the file name that Grafic is operating on.
        private bool m_blOperating;                             //Drawing states using in the MouseEvent
        private static bool m_blAdjusting;
        private Double[,] m_dbScaleMatrix;
        private Double[,] m_dbRotationMatrix;
        private int m_intAjustingState;                //0:None          1:translation     2:Scaling/Flip    3:Rotation   4:Move center
        private int m_intCurveNodeIndex;
        private bool m_blShiftKeyDown;                 //Mouse event


        private static Rectangle g_rtFillRectangle;    //It's a public area for  filling in background
        private AdjustingBox m_abAdjustingBox;

        private Line m_lnNewLine;                                //Tempoprary graphic variables
        private Rect m_rtNewRect;                               //Use the names of Rect and Elli to avoid ambiguity.
        private Elli m_elNewElli;
        private RoundedRect m_rrNewRdRect;
        private Curve m_cvNewCurve;
        private Text m_txtNewText;
        private Point m_ptStart;                                   //temporary points for the start and the end
        private Point m_ptEnd;

        private Color m_clrPixelColor;                           //Pixel color using in infobox      
        private Byte m_btPixelColorR;
        private Byte m_btPixelColorG;
        private Byte m_btPixelColorB;

        private Pen m_penPencil;                                  //Paint Tools in background
        private SolidBrush m_brsEraserBrush;
        private SolidBrush m_brsSolidBrush;
        private HatchBrush m_brsHatchBrush;
        private LinearGradientBrush m_brsLinearBrush;

        private bool m_blBold;                                  //Font variables
        private bool m_blItatic;
        private bool m_blUnderline;
        private FontFamily m_ffFontKind;                //These two member variables are used to set the text font
        private int m_intFontsize;
        private FontStyle m_fsFontStyle;
        private StringFormat m_sfFontStringFormat;
        private String m_strStringYouInsert;

                              

        #endregion

        #region 2.MainForm

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmToolBox = new ToolBoxForm();
            frmInfoBox = new InfoBoxForm();
            frmColorBox = new ColorBoxForm();
            frmLayerBox = new LayerBoxForm();


            frmColorBox.Show();
            frmToolBox.Show();
            frmInfoBox.Show();
            frmLayerBox.Show();

            frmLayerBox.frmMainForm = this;

            g_intPaperWidth = 600;
            g_intPaperHeight = 500;
            g_blFileIsNewed = false;
            g_blFileIsOpened = false;
            g_blFileHasBeenEdited = false;
            g_blColorBoxIsShow = true;                
            g_blInfoBoxIsShow = true;
            g_blToolBoxIsShow = true;
            g_blLayerBoxIsShow = true;

            g_lstShapeList = new List<Shape>();
            g_lstSelectedShapeList = new List<Shape>();
            g_intNumberOfShape = 0;
            g_bmCache = new Bitmap(1, 1);
            m_blAdjusting = false;
            m_blOperating = false;
            m_lnNewLine = new Line();
            m_cvNewCurve = new Curve();
            m_elNewElli = new Elli();
            m_rtNewRect = new Rect();
            m_rrNewRdRect = new RoundedRect();
            m_txtNewText = new Text();
            m_abAdjustingBox = new AdjustingBox();
            m_intAjustingState = 0;

            m_blShiftKeyDown = false;

            m_blBold = false;
            m_blItatic = false;
            m_blUnderline = false;

            m_dbScaleMatrix = new double[3, 3];
            m_dbRotationMatrix = new double[3, 3];
            

            foreach (FontFamily ff in FontFamily.Families)                    //Get ready for the list of FontFamily
            {
                toolStripFontFamily.Items.Add(ff.Name);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitFile(sender, e);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region 3.Paint Events

        private void picRubberBandLayer_Paint(object sender, PaintEventArgs e)
        {
            //It is a tansparent layer over the paper performing the rubber band 
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            if (m_lnNewLine != null)                   //Enable the rubber band of each shape
                m_lnNewLine.Draw(g);

            if (m_rtNewRect != null)
                m_rtNewRect.Draw(g);

            if (m_elNewElli != null)
                m_elNewElli.Draw(g);

            if (m_rrNewRdRect != null)
               m_rrNewRdRect.Draw(g);

            if (m_txtNewText != null)
                m_txtNewText.DrawPath(g);

            if (m_cvNewCurve != null)
                m_cvNewCurve.Draw(g);

            if (m_abAdjustingBox != null)
                m_abAdjustingBox.Draw(g);

        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {
            if (g_blFileIsNewed || g_blFileIsOpened)
            {
                Rectangle rect = e.ClipRectangle;
                BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
                BufferedGraphics buffer = currentContext.Allocate(e.Graphics, e.ClipRectangle);
                Graphics g = buffer.Graphics;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                g.DrawImage(g_bmBackground,0,0);                                 //Refresh with the background pic
                foreach (Shape G in g_lstShapeList)
                {
                    if (G.m_blVisible == true)
                        G.Draw(g);
                }
                buffer.Render(e.Graphics);
                g.Dispose();
                buffer.Dispose();
            }

        }

        #endregion

        #region 4.Mouse Events

        private void picRubberBandLayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (g_blFileIsOpened || g_blFileIsNewed)
            {
                if (m_blAdjusting == true)
                {
                    m_intAjustingState=0;
                    m_ptStart = new Point(e.X,e.Y);
                    switch (m_abAdjustingBox.GetCurrentHandle(m_ptStart))         //Get Current Handle,and react when mousemove
                    {
                        case 0:
                            SetSelectionRect();
                            m_intAjustingState = 1;  //translate
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            m_intAjustingState = 2;    //scale
                            break;
                        case 9:
                            m_intAjustingState = 4;    //move center
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            m_intAjustingState = 3;   //Rotation
                            break;
                    }
                    switch ((int)m_abAdjustingBox.curHandle)         //Get Current Handle,and react when mousemove
                    {
                        case -1:
                            break;
                        case 0:
                            break;
                        case 1:
                            this.Cursor = Cursors.SizeNWSE;
                            break;
                        case 2:
                            this.Cursor = Cursors.SizeWE;
                            break;
                        case 3:
                            this.Cursor = Cursors.SizeNESW;
                            break;
                        case 4:
                            this.Cursor = Cursors.SizeNS;
                            break;
                        case 5:
                            this.Cursor = Cursors.SizeNWSE;
                            break;
                        case 6:
                            this.Cursor = Cursors.SizeWE;
                            break;
                        case 7:
                            this.Cursor = Cursors.SizeNESW;
                            break;
                        case 8:
                            this.Cursor = Cursors.SizeNS;
                            break;
                        case 9:
                            this.Cursor = Cursors.SizeAll;
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            this.Cursor = new Cursor(GetType(), "Cursors.RotateToolCursor.cur");
                            break;
                    }

                }
                else
                {
                    switch (ToolBoxForm.g_tmUsingToolMode)
                    {
                        case ToolBoxForm.ToolMode.Move:
                            m_ptStart = new Point(e.X, e.Y);                                 //Record the current position when you click down 
                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.Line:
                            m_lnNewLine.SetLine(e.Location, e.Location);
                            m_lnNewLine.SetPen(ColorBoxForm.g_clrSelectedColor1,     //Set up the rubber band PenStyle
                                ToolBoxForm.g_ftLineWidth);
                            m_blOperating = true;                                                        //On Operatin so enable the MouseMove
                            break;

                        case ToolBoxForm.ToolMode.Curve:
                            if (m_cvNewCurve.m_blCurveIsWaiting == false)                   //There hasn't been a curve yet
                            {
                                m_ptStart = new Point(e.X, e.Y);                                                    //Save the start position
                                m_cvNewCurve.SetPen(ColorBoxForm.g_clrSelectedColor1,     //Set up the rubber band PenStyle
                                    ToolBoxForm.g_ftLineWidth);
                                m_blOperating = true;
                            }
                            else                                                                                           //One curve has been newed
                            {
                                m_intCurveNodeIndex = m_cvNewCurve.GetCurrentNode(e.Location);
                                if (m_intCurveNodeIndex == -1)           //Not selecting a Node.Start a new curve
                                {
                                    g_lstShapeList[g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
                                    //Finish the old one before start a new curve
                                    m_cvNewCurve = new Curve();
                                    m_ptStart = new Point(e.X, e.Y);
                                    m_cvNewCurve.SetPen(ColorBoxForm.g_clrSelectedColor1,
                                        ToolBoxForm.g_ftLineWidth);
                                    m_blOperating = true;
                                }
                                else                                                                      //Into Adjusting State 
                                {
                                    m_cvNewCurve.m_blCurveAdjusting = true;
                                }
                            }
                            break;

                        case ToolBoxForm.ToolMode.Rectangle:
                            m_ptStart = new Point(e.X, e.Y);
                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.Text:
                            m_ptStart = new Point(e.X, e.Y);
                            if (m_blItatic == true)
                                m_fsFontStyle = m_fsFontStyle | FontStyle.Italic;                     //Itatic
                            else
                                m_fsFontStyle = m_fsFontStyle & (~FontStyle.Italic);
                            if (m_blBold == true)
                                m_fsFontStyle = m_fsFontStyle | FontStyle.Bold;                   //Bold
                            else
                                m_fsFontStyle = m_fsFontStyle & (~FontStyle.Bold);
                            if (m_blUnderline == true)
                                m_fsFontStyle = m_fsFontStyle | FontStyle.Underline;
                            else
                                m_fsFontStyle = m_fsFontStyle & (~FontStyle.Underline);       //Underline

                            m_strStringYouInsert = frmToolBox.richTextBox1.Text;
                            m_sfFontStringFormat = new StringFormat();
                            m_sfFontStringFormat.Alignment = StringAlignment.Center;
                            m_sfFontStringFormat.FormatFlags = StringFormatFlags.LineLimit;
                            m_sfFontStringFormat.Trimming = StringTrimming.EllipsisWord;
                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.Ellipse:
                            m_ptStart = new Point(e.X, e.Y);
                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.RoundedRectangle:
                            m_ptStart = new Point(e.X, e.Y);

                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.ColorPicker:
                            Bitmap pick = new Bitmap(1, 1);
                            Graphics tempGraphics = Graphics.FromImage(pick);
                            Point screen = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
                            tempGraphics.CopyFromScreen(screen.X, screen.Y,
                                0, 0, new Size(1, 1));                                        //copy the (X,Y) in screen point to a 1*1 bitmap cache
                            frmColorBox.PickColor(pick.GetPixel(0, 0));             //Pick up the color in colobox                               
                            break;

                        case ToolBoxForm.ToolMode.Pencil:
                            m_penPencil = new Pen(ColorBoxForm.g_clrSelectedColor1, 1);         //Create the pencil when mouse down 
                            m_ptStart.X = e.X;
                            m_ptStart.Y = e.Y;
                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.Eraser:
                            this.Cursor = new Cursor(GetType(), "Cursors.EraserToolCursorMouseDown.cur");
                            m_brsEraserBrush = new SolidBrush(Color.White);
                            m_blOperating = true;
                            break;

                        case ToolBoxForm.ToolMode.Brush:
                            switch (ToolBoxForm.g_intBrushStyle)                               //Initialize the brush according to the selection
                            {
                                case 1:
                                    m_brsSolidBrush = new SolidBrush(ColorBoxForm.g_clrSelectedColor1);
                                    break;
                                case 2:
                                    m_brsHatchBrush = new HatchBrush(HatchStyle.DiagonalCross, ColorBoxForm.g_clrSelectedColor1
                                        , Color.Transparent);
                                    break;
                                case 3:
                                    Rectangle rect1 = new Rectangle(20, 80, 250, 100);
                                    m_brsLinearBrush = new LinearGradientBrush(rect1, ColorBoxForm.g_clrSelectedColor1,
                                        Color.White, LinearGradientMode.BackwardDiagonal);
                                    break;
                            }
                            m_blOperating = true;
                            break;
                        case ToolBoxForm.ToolMode.FillBorder:
                            if (g_rtFillRectangle.Contains(e.Location))
                            {
                                Graphics g = Graphics.FromImage(g_bmBackground);
                                SolidBrush brush = new SolidBrush(ColorBoxForm.g_clrSelectedColor2);
                                g.FillRectangle(brush, g_rtFillRectangle);
                                this.pnlBackground.Invalidate();
                            }
                            g_blFileHasBeenEdited = true;
                            break;

                        case ToolBoxForm.ToolMode.PaintBucket:
                            try
                            {
                                foreach (Rect s in g_lstSelectedShapeList)
                                {
                                    if (s.m_rtRect.Contains(e.Location))
                                    {
                                        s.SetFillColor(ColorBoxForm.g_clrSelectedColor2);
                                    }
                                }
                            }
                            catch
                            {
                                //do nothing
                            }
                            this.pnlBackground.Invalidate();
                            break;
                    }
                }
            }
        }

        private void picRubberBandLayer_MouseMove(object sender, MouseEventArgs e)
        {
            //Processing the InfoBox
            if (g_blFileIsOpened || g_blFileIsNewed)
            {
                if (m_blAdjusting == true)
                {

                    if (m_intAjustingState != 0)
                    {
                        switch (m_intAjustingState)                                //1.tanslate    2.scale   3.rotate  4.move center
                        {
                            case 1:
                                Size TransSize = new Size(e.X - m_ptStart.X, e.Y - m_ptStart.Y);
                                g_lstSelectedShapeList[g_lstSelectedShapeList.Count - 1].Translate(TransSize);  //move the shape
                                m_abAdjustingBox.Translate(TransSize);              //move the control box
                                this.picRubberBandLayer.Invalidate();
                                this.pnlBackground.Invalidate();
                                m_ptStart = new Point(e.X, e.Y);
                                break;
                            case 2:
                                m_abAdjustingBox.Scale(new Point(e.X,e.Y));        //Scale the adjustingbox
                                this.picRubberBandLayer.Invalidate();
                                this.pnlBackground.Invalidate();
                                break;
                            case 3:
                                m_ptEnd = new Point(e.X, e.Y);
                                SetRotation(m_ptStart, m_ptEnd);                               //Set up the RotationMatrix
                                m_abAdjustingBox.Rotate(m_dbRotationMatrix);
                                this.picRubberBandLayer.Invalidate();
                                
                                this.pnlBackground.Invalidate();
                                break;
                            case 4:
                                m_abAdjustingBox.m_ptRotationCenter = new Point(e.X, e.Y);
                                this.pnlBackground.Invalidate();
                                break;
                        }
                    }
                }
                else
                {
                    if (m_blOperating == false)                                                   //get cursor's RGB color when it is not on operating
                    {
                        Graphics tempGraphics = Graphics.FromImage(g_bmCache);
                        Point screen = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
                        tempGraphics.CopyFromScreen(screen.X, screen.Y,
                            0, 0, new Size(1, 1));                                             //copy the (X,Y) in screen point to a 1*1 bitmap cache
                        m_clrPixelColor = g_bmCache.GetPixel(0, 0);                //Get the pixel color of cashe
                        frmInfoBox.SetCurrentCursor(e.Location);
                        m_btPixelColorR = m_clrPixelColor.R;
                        m_btPixelColorG = m_clrPixelColor.G;
                        m_btPixelColorB = m_clrPixelColor.B;
                        frmInfoBox.SetColorRGB(m_btPixelColorR, m_btPixelColorG, m_btPixelColorB);
                    }
                    else         //Refresh the size of shape when in operating 
                    {
                        if (ToolBoxForm.g_tmUsingToolMode == ToolBoxForm.ToolMode.Rectangle
                            || ToolBoxForm.g_tmUsingToolMode == ToolBoxForm.ToolMode.Ellipse)
                        {
                            frmInfoBox.SetSize(m_ptStart, m_ptEnd);
                        }
                    }
                    if (m_blOperating == true)
                    {
                        switch (ToolBoxForm.g_tmUsingToolMode)
                        {
                            case ToolBoxForm.ToolMode.Move:
                                Size translation = new Size(e.X - m_ptStart.X, e.Y - m_ptStart.Y);
                                foreach (Shape G in g_lstSelectedShapeList)        //Translate the selected shape 
                                {
                                    G.Translate(translation);
                                }

                                this.pnlBackground.Invalidate();                        //Move the Adjustingbox with the shape           
                                m_ptStart = new Point(e.X, e.Y);                      //Prepare for the next StartPoint
                                break;

                            case ToolBoxForm.ToolMode.Line:
                                m_lnNewLine.SetEnd(e.Location);
                                picRubberBandLayer.Invalidate();                           //Refresh the picture box to realize rubber band
                                break;

                            case ToolBoxForm.ToolMode.Curve:
                                m_cvNewCurve = new Curve(m_ptStart, e.Location);
                                picRubberBandLayer.Invalidate();                           //Refresh the picture box to realize rubber band
                                break;

                            case ToolBoxForm.ToolMode.Rectangle:
                                m_ptEnd = new Point(e.X, e.Y);
                                m_rtNewRect = new Rect(m_ptStart, m_ptEnd, m_blShiftKeyDown);
                                m_rtNewRect.SetPen(ColorBoxForm.g_clrSelectedColor1,     //Set up the pen
                                    ToolBoxForm.g_ftLineWidth);
                                picRubberBandLayer.Invalidate();
                                break;

                            case ToolBoxForm.ToolMode.Text:               //The Text Frame
                                m_ptEnd = new Point(e.X, e.Y);
                                m_txtNewText = new Text(m_ptStart, m_ptEnd);
                                m_txtNewText.SetPen(DashStyle.Dot, Color.Black, 1);      //Dash Dot Frame                  
                                picRubberBandLayer.Invalidate();
                                break;

                            case ToolBoxForm.ToolMode.Ellipse:
                                m_ptEnd = new Point(e.X, e.Y);
                                m_elNewElli = new Elli(m_ptStart, m_ptEnd, m_blShiftKeyDown);
                                m_elNewElli.SetPen(ColorBoxForm.g_clrSelectedColor1,
                                    ToolBoxForm.g_ftLineWidth);
                                picRubberBandLayer.Invalidate();
                                break;

                            case ToolBoxForm.ToolMode.RoundedRectangle:
                                m_ptEnd = new Point(e.X, e.Y);
                                m_rrNewRdRect = new RoundedRect(m_ptStart, m_ptEnd, m_blShiftKeyDown);
                                m_rrNewRdRect.g_blRdRectHasBeenCreated = true;
                                m_rrNewRdRect.SetPen(ColorBoxForm.g_clrSelectedColor1,
                                    ToolBoxForm.g_ftLineWidth);
                                picRubberBandLayer.Invalidate();
                                break;

                            case ToolBoxForm.ToolMode.Pencil:
                                Graphics g = Graphics.FromImage(g_bmBackground);                    //Drawing line continually to make a free line pencil
                                g.DrawLine(m_penPencil, m_ptStart.X, m_ptStart.Y, e.X, e.Y);
                                g.SmoothingMode = SmoothingMode.HighQuality;
                                g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                                m_ptStart.X = e.X;
                                m_ptStart.Y = e.Y;
                                this.pnlBackground.Invalidate();
                                break;

                            case ToolBoxForm.ToolMode.Eraser:
                                Graphics g2 = Graphics.FromImage(g_bmBackground);
                                int r2 = ToolBoxForm.g_intEraserWidth / 2;
                                g2.FillEllipse(m_brsEraserBrush, e.X - r2, e.Y - r2, r2 * 2, r2 * 2);
                                this.pnlBackground.Invalidate();
                                break;

                            case ToolBoxForm.ToolMode.Brush:
                                Graphics g3 = Graphics.FromImage(g_bmBackground);
                                g3.SmoothingMode = SmoothingMode.HighQuality;
                                g3.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                                int r = ToolBoxForm.g_intBrushWidth / 2;
                                m_ptStart = e.Location;
                                switch (ToolBoxForm.g_intBrushStyle)                               //Initialize the brush according to the selection
                                {
                                    case 1:
                                        g3.FillEllipse(m_brsSolidBrush, m_ptStart.X - r, m_ptStart.Y - r, 2 * r, 2 * r);
                                        break;
                                    case 2:
                                        g3.FillEllipse(m_brsHatchBrush, m_ptStart.X - r, m_ptStart.Y - r, 2 * r, 2 * r);
                                        break;
                                    case 3:
                                        g3.FillEllipse(m_brsLinearBrush, m_ptStart.X - r, m_ptStart.Y - r, 2 * r, 2 * r);
                                        break;
                                }
                                m_ptStart = e.Location;
                                this.pnlBackground.Invalidate();
                                break;
                        }
                    }
                    else
                    {
                        switch (ToolBoxForm.g_tmUsingToolMode)
                        {
                            case ToolBoxForm.ToolMode.Curve:
                                if (m_cvNewCurve.m_blCurveIsWaiting == true)
                                {
                                    if (g_lstShapeList[g_lstShapeList.Count - 1].GetCurrentNode(e.Location) >= 0)      //Change the icon when cursor is on  one node
                                    {
                                        this.Cursor = new Cursor(GetType(), "Cursors.PanToolCursor.cur");
                                    }
                                    else
                                    {
                                        this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");
                                    }
                                }
                                if (m_cvNewCurve.m_blCurveAdjusting == true)
                                {
                                    this.Cursor = new Cursor(GetType(), "Cursors.PanToolCursorMouseDown.cur");
                                    g_lstShapeList[g_lstShapeList.Count - 1].SetNode(m_intCurveNodeIndex, e.Location);
                                    picRubberBandLayer.Invalidate();
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void picRubberBandLayer_MouseUp(object sender, MouseEventArgs e)
        {
            if (g_blFileIsOpened || g_blFileIsNewed)
            {
                if (m_blAdjusting == true)
                {
                    this.Cursor = new Cursor(GetType(), "Cursors.MoveSelectionToolCursor.cur");    //Reset the cursor
                    if (m_intAjustingState != 0)
                    {
                        switch (m_intAjustingState)
                        {
                            case 1:

                                break;
                            case 2:
                                Scale(new Point(e.X, e.Y));
                                this.pnlBackground.Invalidate();
                                break;
                            case 3:
                                m_ptEnd = new Point(e.X, e.Y);
                                g_lstSelectedShapeList[g_lstSelectedShapeList.Count-1].Rotate
                                    (GetAngle(m_ptStart, m_ptEnd, m_abAdjustingBox.m_ptRotationCenter), m_abAdjustingBox.m_ptRotationCenter);
                                m_abAdjustingBox.SetOldHandles();
                                this.pnlBackground.Invalidate();
                                break;
                            case 4:
                                break;
                        }
                        m_intAjustingState = 0;
                    }
                }
                else
                {
                    switch (ToolBoxForm.g_tmUsingToolMode)
                    {
                        case ToolBoxForm.ToolMode.Move:
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Line:
                            m_lnNewLine.SetEnd(e.Location);                //This is the final fixed line
                            m_lnNewLine.SetPen(ColorBoxForm.g_clrSelectedColor1, ToolBoxForm.g_ftLineWidth);
                            g_lstShapeList.Add(m_lnNewLine);               //Add the new line in the list
                            g_intNumberOfShape++;
                            frmLayerBox.AddItem(g_intNumberOfShape, 1);
                            g_blFileHasBeenEdited = true;                     //Now the file has been edited
                            m_lnNewLine = new Line();                           //Get the next coming line prepared
                            this.pnlBackground.Invalidate();
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Curve:
                            if (m_cvNewCurve.m_blCurveIsWaiting == false)
                            {
                                g_lstShapeList.Add(m_cvNewCurve);
                                g_intNumberOfShape++;
                                frmLayerBox.AddItem(g_intNumberOfShape, 6);
                                g_blFileHasBeenEdited = true;
                                this.pnlBackground.Invalidate();
                                m_blOperating = false;
                                m_cvNewCurve.m_blCurveIsWaiting = true;
                            }
                            if (m_cvNewCurve.m_blCurveAdjusting == true)
                            {
                                m_cvNewCurve.m_blCurveAdjusting = false;
                                this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");
                            }

                            break;

                        case ToolBoxForm.ToolMode.Rectangle:
                            g_lstShapeList.Add(m_rtNewRect);
                            g_intNumberOfShape++;
                            frmLayerBox.AddItem(g_intNumberOfShape, 2);
                            g_blFileHasBeenEdited = true;
                            m_rtNewRect = new Rect();
                            this.pnlBackground.Invalidate();
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Text:
                            m_txtNewText = new Text(m_ptStart, m_ptEnd, m_ffFontKind, m_fsFontStyle,
                                    m_intFontsize, m_strStringYouInsert, m_sfFontStringFormat);
                            g_lstShapeList.Add(m_txtNewText);
                            g_intNumberOfShape++;
                            frmLayerBox.AddItem(g_intNumberOfShape, 5);
                            g_blFileHasBeenEdited = true;
                            m_txtNewText = new Text();
                            this.pnlBackground.Invalidate();
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Ellipse:
                            g_lstShapeList.Add(m_elNewElli);
                            g_intNumberOfShape++;
                            frmLayerBox.AddItem(g_intNumberOfShape, 3);
                            g_blFileHasBeenEdited = true;
                            m_elNewElli = new Elli();
                            this.pnlBackground.Invalidate();
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.RoundedRectangle:
                            g_lstShapeList.Add(m_rrNewRdRect);
                            g_intNumberOfShape++;
                            frmLayerBox.AddItem(g_intNumberOfShape, 4);
                            g_blFileHasBeenEdited = true;
                            m_rrNewRdRect = new RoundedRect();
                            this.pnlBackground.Invalidate();
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Pencil:
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Eraser:
                            this.Cursor = new Cursor(GetType(), "Cursors.EraserToolCursor.cur");
                            m_blOperating = false;
                            break;

                        case ToolBoxForm.ToolMode.Brush:
                            m_ptStart = new Point();
                            m_blOperating = false;
                            break;
                    }
                }
            }
        }

        private void picRubberBandLayer_MouseEnter(object sender, EventArgs e)
        {
            if (g_blFileIsOpened || g_blFileIsNewed)
            {
                if (m_blAdjusting == true)
                {
                    this.Cursor = new Cursor(GetType(), "Cursors.MoveSelectionToolCursor.cur");    //Set the cursor
                }
                else 
                {
                    switch (ToolBoxForm.g_tmUsingToolMode)
                    {
                        case ToolBoxForm.ToolMode.Move:
                            this.Cursor = new Cursor(GetType(), "Cursors.MoveToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Line:
                            this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Ellipse:
                            this.Cursor = new Cursor(GetType(), "Cursors.EllipseToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Rectangle:
                            this.Cursor = new Cursor(GetType(), "Cursors.RectangleToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Brush:
                            this.Cursor = new Cursor(GetType(), "Cursors.PaintBrushToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.ColorPicker:
                            this.Cursor = new Cursor(GetType(), "Cursors.ColorPickerToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Eraser:
                            this.Cursor = new Cursor(GetType(), "Cursors.EraserToolCursor.cur");   //*
                            break;
                        case ToolBoxForm.ToolMode.FillBorder:
                            this.Cursor = new Cursor(GetType(), "Cursors.PaintBucketToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Text:
                            this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");  //Cursors.TextToolCursor.cur
                            break;
                        case ToolBoxForm.ToolMode.FreeFormShape:
                            this.Cursor = new Cursor(GetType(), "Cursors.FreeformShapeToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.PaintBucket:
                            this.Cursor = new Cursor(GetType(), "Cursors.PaintBucketToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Pencil:
                            this.Cursor = new Cursor(GetType(), "Cursors.PencilToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.RoundedRectangle:
                            this.Cursor = new Cursor(GetType(), "Cursors.RoundedRectangleToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Curve:
                            this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");  //*
                            break;


                        //Not open yet
                        case ToolBoxForm.ToolMode.CloneStamp:
                            this.Cursor = new Cursor(GetType(), "Cursors.CloneStampToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.Adjust:
                            this.Cursor = new Cursor(GetType(), "Cursors.MoveSelectionToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.RectangleSelect:
                            this.Cursor = new Cursor(GetType(), "Cursors.RectangleSelectToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.LassoSelect:
                            this.Cursor = new Cursor(GetType(), "Cursors.LassoSelectToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.MagicWand:
                            this.Cursor = new Cursor(GetType(), "Cursors.MagicWandToolCursor.cur");
                            break;
                        case ToolBoxForm.ToolMode.EllipseSelect:
                            this.Cursor = new Cursor(GetType(), "Cursors.EllipseSelectToolCursor.cur");
                            break;
                    }
                }
               
            }
        }

        private void picRubberBandLayer_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            frmInfoBox.Clear();
        }

        #endregion

        #region 5.KeyBoard Events

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
                m_blShiftKeyDown = true;
            if (e.KeyCode == Keys.Delete)
            {
                foreach (Shape G in g_lstSelectedShapeList)
                    G.m_blVisible = false;
                this.pnlBackground.Invalidate();
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            m_blShiftKeyDown = false;       //Unpress shift

        }

        #endregion

        #region 6.MenuTool Buttons

        private void mnuToolBoxIsShow_Click(object sender, EventArgs e)
        {
            g_blToolBoxIsShow = !(g_blToolBoxIsShow);
            if (g_blToolBoxIsShow == true)
                frmToolBox.Show();
            else
                frmToolBox.Hide();
        }

        private void mnuInfoBoxIsShow_Click(object sender, EventArgs e)
        {
            g_blInfoBoxIsShow = !(g_blInfoBoxIsShow);
            if (g_blInfoBoxIsShow == true)
                frmInfoBox.Show();
            else
                frmInfoBox.Hide();
        }

        private void mnuLayerBoxIsShow_Click(object sender, EventArgs e)
        {
            g_blLayerBoxIsShow = !(g_blLayerBoxIsShow);
            if (g_blLayerBoxIsShow == true)
                frmLayerBox.Show();
            else
                frmLayerBox.Hide();
        }

        private void mnuColorBoxIsShow_Click(object sender, EventArgs e)
        {
            g_blColorBoxIsShow = !(g_blColorBoxIsShow);
            if (g_blColorBoxIsShow == true)
                frmColorBox.Show();
            else
                frmColorBox.Hide();
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            if (g_blFileHasBeenEdited == true)
            {
                DialogResult result = MessageBox.Show("文件已做修改,是否保存?", "退出",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (g_blFileIsNewed == true)
                    {
                        SaveFileAs();
                    }
                    else if (g_blFileIsOpened == true)
                    {
                        SaveFile();
                    }
                    this.Dispose();  //Close After Saving
                }
                else if (result == DialogResult.No)
                {
                    this.Dispose();
                }
                else if (result == DialogResult.Cancel)
                {
                    //Do nothing
                }
            }
            else  //If the file has never edited
            {
                this.Dispose();
            }
        }
    
        private void mnuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();

        }

        private void mnuItemSave_Click(object sender, EventArgs e)
        {
            if (g_blFileIsOpened)
                SaveFile();
            else if(g_blFileIsNewed)
                 SaveFileAs();
        }

        private void mnuItemNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void mnuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBoxForm frmAboutBox=new AboutBoxForm();
            frmAboutBox.ShowDialog();
        }

        private void mnuItemAdjust_Click(object sender, EventArgs e)
        {
            if (this.mnuItemAdjust.Checked == false)
            {
                if (g_lstSelectedShapeList.Count > 0)
                {
                    g_lstShapeList[g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
                    SetSelectionRect();
                    pnlBackground.Invalidate();
                    this.mnuItemAdjust.Checked = true;
                    m_blAdjusting = true;
                    this.Cursor = new Cursor(GetType(), "Cursors.MoveSelectionToolCursor.cur");
                }
            }
            else
            {
                m_abAdjustingBox = new AdjustingBox();
                this.mnuItemAdjust.Checked = false;
                m_blAdjusting = false;
                switch (ToolBoxForm.g_tmUsingToolMode)
                {
                    case ToolBoxForm.ToolMode.Move:
                        this.Cursor = new Cursor(GetType(), "Cursors.MoveToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Line:
                        this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Ellipse:
                        this.Cursor = new Cursor(GetType(), "Cursors.EllipseToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Rectangle:
                        this.Cursor = new Cursor(GetType(), "Cursors.RectangleToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Brush:
                        this.Cursor = new Cursor(GetType(), "Cursors.PaintBrushToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.ColorPicker:
                        this.Cursor = new Cursor(GetType(), "Cursors.ColorPickerToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Eraser:
                        this.Cursor = new Cursor(GetType(), "Cursors.EraserToolCursor.cur");   //*
                        break;
                    case ToolBoxForm.ToolMode.FillBorder:
                        this.Cursor = new Cursor(GetType(), "Cursors.PaintBucketToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Text:
                        this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");  //Cursors.TextToolCursor.cur
                        break;
                    case ToolBoxForm.ToolMode.FreeFormShape:
                        this.Cursor = new Cursor(GetType(), "Cursors.FreeformShapeToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.PaintBucket:
                        this.Cursor = new Cursor(GetType(), "Cursors.PaintBucketToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Pencil:
                        this.Cursor = new Cursor(GetType(), "Cursors.PencilToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.RoundedRectangle:
                        this.Cursor = new Cursor(GetType(), "Cursors.RoundedRectangleToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Curve:
                        this.Cursor = new Cursor(GetType(), "Cursors.GenericToolCursor.cur");  //*
                        break;


                    //Not open yet
                    case ToolBoxForm.ToolMode.CloneStamp:
                        this.Cursor = new Cursor(GetType(), "Cursors.CloneStampToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.Adjust:
                        this.Cursor = new Cursor(GetType(), "Cursors.MoveSelectionToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.RectangleSelect:
                        this.Cursor = new Cursor(GetType(), "Cursors.RectangleSelectToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.LassoSelect:
                        this.Cursor = new Cursor(GetType(), "Cursors.LassoSelectToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.MagicWand:
                        this.Cursor = new Cursor(GetType(), "Cursors.MagicWandToolCursor.cur");
                        break;
                    case ToolBoxForm.ToolMode.EllipseSelect:
                        this.Cursor = new Cursor(GetType(), "Cursors.EllipseSelectToolCursor.cur");
                        break;
                }
                pnlBackground.Invalidate();
            }
        }



        private void mnuItemOptions_Click(object sender, EventArgs e)
        {
            frmOptionBox = new OptionBoxForm();
            frmOptionBox.ShowDialog();
        }

        #endregion

        #region 7.ToolStip Buttons

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (g_blFileIsOpened)
                SaveFile();
            else if (g_blFileIsNewed)
                SaveFileAs();
        }

        private void toolStripBold_Click(object sender, EventArgs e)
        {
            m_blBold = !(m_blBold);
            this.toolStripBold.Checked = !(this.toolStripBold.Checked);
        }

        private void toolStripItatic_Click(object sender, EventArgs e)
        {
            m_blItatic = !(m_blItatic);
            this.toolStripItatic.Checked = !(this.toolStripItatic.Checked);
        }

        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            m_blUnderline = !(m_blUnderline);
            this.toolStripUnderline.Checked = !(this.toolStripUnderline.Checked);
        }

        private void toolStripFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ffFontKind = FontFamily.Families[this.toolStripFontFamily.SelectedIndex];
        }

        //index: 0  1  2  3  4  5    |  6   7   8   9  10  11  12  13  14    | 15  16  17  18  19  20    
        //size:   5  6  7  8  9 10    | 12 14 16  18  20 22  24  26  28     | 32  40  48  56  64  72
        private void toolStripFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.toolStripFontSize.SelectedIndex <= 5)                                   
            {
                m_intFontsize = this.toolStripFontSize.SelectedIndex+5;   
            }
            else if (this.toolStripFontSize.SelectedIndex > 5 && this.toolStripFontSize.SelectedIndex <= 14)
            {
                m_intFontsize = 2 * this.toolStripFontSize.SelectedIndex;
            }
            else
            {
                m_intFontsize = (this.toolStripFontSize.SelectedIndex - 11) * 8;
            }

            
        }

        private void toolStripOption_Click(object sender, EventArgs e)
        {
            frmOptionBox = new OptionBoxForm();
            frmOptionBox.ShowDialog();
        }
        #endregion

        #region 8.Extra File Operating Function

        private void NewFile()
        {
            if (g_blFileHasBeenEdited == true)
            {
                DialogResult result = MessageBox.Show("文件已做修改,是否保存?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (g_blFileIsNewed == true)
                    {
                        SaveFileAs();
                    }
                    if (g_blFileIsOpened == true)
                    {
                        SaveFile();
                    }
                }
            }
            g_blFileIsNewed = true;
            g_blFileIsOpened = false;
            g_blFileHasBeenEdited = false;
            g_bmBackground = new Bitmap(g_intPaperWidth, g_intPaperHeight,                                 //Making the backgound a blank white paper 
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(g_bmBackground);
            g.Clear(Color.White);
            m_strOpenFileName = "untitled";
            mnuItemSaveAs.Enabled = true;                                             //Enable the mnuItems
            mnuItemAdjust.Enabled = true;
            mnuItemZoomIn.Enabled = true;
            mnuItemZoomOut.Enabled = true;
            toolStripSave.Enabled = true;
            toolStripUnderline.Enabled = true;
            toolStripBold.Enabled = true;
            toolStripItatic.Enabled = true;
            toolStripFontFamily.Enabled = true;
            toolStripFontSize.Enabled = true;
            mnuItemSave.Enabled = true;                                                //Enable the mnuItems
            frmLayerBox.ClearItem();                                                      //Clear the layerbox first
            frmLayerBox.AddBackgroundItem();                                       //Add in layerbox
            g_lstShapeList.Clear();                                                          //Clear the ShapeList in the new file 
            g_intNumberOfShape = 0;                                                        //Clear the counter of the Shape
            this.pnlBackground.Width = g_bmBackground.Width;
            this.pnlBackground.Height = g_bmBackground.Height;
            g_rtFillRectangle = new Rectangle(0, 0, g_bmBackground.Width, g_bmBackground.Height);
            this.picRubberBandLayer.Width = g_bmBackground.Width;        //Set up the sizes of three picturebox
            this.picRubberBandLayer.Height = g_bmBackground.Height;
            g_bmDrawingPaper = g_bmBackground;                                   //Save a copy as drawing one
            this.Text = m_strOpenFileName;
            this.toolStripFontFamily.SelectedIndex = 1;                           //Initializing the Font combobox
            this.toolStripFontSize.SelectedIndex = 6;
            this.toolStripFontSize.BackColor = Color.White;
            this.toolStripFontFamily.BackColor = Color.White;
            this.mnuItemAdjust.Checked = false;
            m_blAdjusting = false;                                                            //Reset the adjusting status
            m_abAdjustingBox = new AdjustingBox();
            this.Invalidate();
        }

        private void OpenFile()
        {
            if (g_blFileHasBeenEdited == true)
            {
                DialogResult result = MessageBox.Show("文件已做修改,是否保存?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (g_blFileIsNewed == true)
                    {
                        SaveFileAs();
                    }
                    if (g_blFileIsOpened == true)
                    {
                        SaveFile();
                    }
                }
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();                        //create an openfiledialog
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Grafic Files(*.gcd)|*.gcd|Image Files(*.bmp,*.jpg,*.gif)|*.bmp;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    g_intNumberOfShape = 0;    
                    g_lstShapeList.Clear();                                                           //Clear the ShapeList in the new file 
                    frmLayerBox.ClearItem();
                    frmLayerBox.AddBackgroundItem();
                    g_bmBackground = new Bitmap(g_intPaperWidth, g_intPaperHeight,
                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Graphics g = Graphics.FromImage(g_bmBackground);
                    g.Clear(Color.White);
                    BinaryFormatter binFormat = new BinaryFormatter();
                    Stream fStream = File.OpenRead(openFileDialog1.FileName);
                    g_lstShapeList = (List<Shape>)binFormat.Deserialize(fStream);
                    this.pnlBackground.Invalidate();
                    fStream.Close();
                    for (int i = 0; i < g_lstShapeList.Count; i++)
                    {
                        frmLayerBox.AddItem(i+1, 7);
                        g_intNumberOfShape++;
                    }
                }
                else if (openFileDialog1.FilterIndex == 2)
                {
                    g_bmBackground = new Bitmap(openFileDialog1.FileName);             //Send the openfile to the background
                    frmLayerBox.ClearItem();                                                        //Clear the layerbox first
                    g_lstShapeList.Clear();                                                           //Clear the ShapeList in the new file 
                    g_intNumberOfShape = 0;                                                        //Clear the counter of the Shape
                    frmLayerBox.AddBackgroundItem();                                         //Add in layerbox
                }
                g_blFileIsOpened = true;
                g_blFileHasBeenEdited = false;
                g_blFileIsNewed = false;
                m_strOpenFileName = openFileDialog1.FileName;                            //Store the path and name for saving
                this.Text = openFileDialog1.FileName;
                mnuItemSaveAs.Enabled = true;                                                 //Enable the mnuItems and toolStrip
                mnuItemAdjust.Enabled = true;
                mnuItemZoomIn.Enabled = true;
                mnuItemZoomOut.Enabled = true;
                toolStripSave.Enabled = true;
                toolStripUnderline.Enabled = true;
                toolStripBold.Enabled = true;
                toolStripItatic.Enabled = true;
                toolStripFontFamily.Enabled = true;
                toolStripFontSize.Enabled = true;
                mnuItemSave.Enabled = true;                                                   //Enable the mnuItems  and toolStrip                  
                this.Text = m_strOpenFileName;

                this.picRubberBandLayer.Width = g_bmBackground.Width;        //Set up the sizes of three picturebox
                this.picRubberBandLayer.Height = g_bmBackground.Height;
                this.pnlBackground.Width = g_bmBackground.Width;
                this.pnlBackground.Height = g_bmBackground.Height;
                
                g_rtFillRectangle = new Rectangle(0, 0, g_bmBackground.Width, g_bmBackground.Height);
                g_bmDrawingPaper = g_bmBackground;                                   //Save a copy as drawing one
                this.toolStripFontFamily.SelectedIndex = 1;                        //Initializing the Font combobox
                this.toolStripFontSize.SelectedIndex = 6;
                this.toolStripFontSize.BackColor = Color.White;
                this.toolStripFontFamily.BackColor = Color.White;
                this.mnuItemAdjust.Checked = false;
                m_blAdjusting = false;
                m_abAdjustingBox = new AdjustingBox();
                this.Invalidate();
            }
        }

        private void SaveFile()
        {
            string s_strOpenFileName = "D:\\123.bmp";
            Graphics g = Graphics.FromImage(g_bmDrawingPaper);
            foreach (Shape G in g_lstShapeList)                            //Now draw the Shape on the DrawingPaper
            {
                if (G.m_blVisible == true)
                    G.Draw(g);
            }
            Bitmap newBitmap = new Bitmap(g_bmDrawingPaper); //Save the drawing paper
            newBitmap.Save(s_strOpenFileName);
            g_blFileHasBeenEdited = false;           //A saved file here
        }

        private void SaveFileAs()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string saveName;
            Graphics g = Graphics.FromImage(g_bmDrawingPaper);
            foreach (Shape G in g_lstShapeList)                            //Draw the Shape on the DrawingPaper finally
            {
                if (G.m_blVisible == true)
                    G.Draw(g);
            }
            Bitmap newBitmap = new Bitmap(g_bmDrawingPaper);
            BinaryFormatter binFormat = new BinaryFormatter();            
            saveFileDialog1.Filter = "Grafic格式|*.gcd|Windows Bitmaps|*.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    Stream fStream = new FileStream(saveFileDialog1.FileName,
                        FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    binFormat.Serialize(fStream, g_lstShapeList);
                    fStream.Close();
                }
                else
                {
                    saveName = saveFileDialog1.FileName;
                    newBitmap.Save(saveName);
                }
            }
            g_blFileHasBeenEdited = false;
        }

        private void ExitFile(object sender, FormClosingEventArgs e)
        {
            if (g_blFileHasBeenEdited == true)
            {
                DialogResult result = MessageBox.Show("文件已做修改,是否保存?", "退出",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (g_blFileIsNewed == true)
                    {
                        SaveFileAs();
                    }
                    else if (g_blFileIsOpened == true)
                    {
                        SaveFile();
                    }
                    this.Dispose();  //Close After Saving
                }
                else if (result == DialogResult.No)
                {
                    this.Dispose();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;        //Cancel the closing
                }
            }
            else  //If the file has never edited
            {
                this.Dispose();
            }
        }

        #endregion

        #region 9.Graphic Functions

        public void SetSelectionRect()
        {
            GraphicsPath one = new GraphicsPath();
            one.AddPath(g_lstSelectedShapeList
                [g_lstSelectedShapeList.Count - 1].m_grpShapePath, false);
            g_rtAdjustingRect = Rectangle.Round(one.GetBounds());
            m_abAdjustingBox = new AdjustingBox(g_rtAdjustingRect);
            one.Dispose();
        }

        private void Scale(Point point)
        {
            if (m_abAdjustingBox.curHandle == CurrentHandle.CP_NULL)
                return;
            double sx = 0;
            double sy = 0;
            Point OldCenter = m_abAdjustingBox.m_ptBasePoint;
           // if (!m_abAdjustingBox.Scale(point))                                    //Scale wrongly
                //return;
            Point newCenter = m_abAdjustingBox.m_ptBasePoint;          //if succeed,the centerpoint changes
            sx = m_abAdjustingBox.GetWidth() / (double)(g_rtAdjustingRect.Right - g_rtAdjustingRect.Left);
            sy = m_abAdjustingBox.GetHeight() / (double)(g_rtAdjustingRect.Bottom - g_rtAdjustingRect.Top);

            g_lstSelectedShapeList[g_lstSelectedShapeList.Count - 1].Scale(sx, sy, newCenter);

            SetSelectionRect();                                                //Reset the rect of shape
            m_abAdjustingBox.m_ptBasePoint = OldCenter;
        }

        private void SetRotation(Point start, Point end)
        {
            Point ptCenterPoint = m_abAdjustingBox.m_ptRotationCenter;
            double agl = GetAngle(start, end, ptCenterPoint);              //get the Rotation angle by the center point 
            m_dbRotationMatrix[0, 0] = Math.Cos(agl);
            m_dbRotationMatrix[0, 1] = -Math.Sin(agl);
            m_dbRotationMatrix[0, 2] = ptCenterPoint.X * (1 - Math.Cos(agl)) + ptCenterPoint.Y * Math.Sin(agl);
            m_dbRotationMatrix[1, 0] = Math.Sin(agl);
            m_dbRotationMatrix[1, 1] = Math.Cos(agl);
            m_dbRotationMatrix[1, 2] = ptCenterPoint.Y * (1 - Math.Cos(agl)) - ptCenterPoint.X * Math.Sin(agl);
            m_dbRotationMatrix[2, 0] = 0;
            m_dbRotationMatrix[2, 1] = 0;
            m_dbRotationMatrix[2, 2] = 1;
        }

        private double GetAngle(Point start, Point end, Point origin)
        {
            int aa = (start.Y - origin.Y) * (start.Y - origin.Y) + (start.X - origin.X) * (start.X - origin.X);
            int bb = (end.Y - origin.Y) * (end.Y - origin.Y) + (end.X - origin.X) * (end.X - origin.X);
            int cc = (end.Y - start.Y) * (end.Y - start.Y) + (end.X - start.X) * (end.X - start.X);
            
            //Get the value of angle throught the relationship between two points 
            double cosagl = (aa + bb - cc) / (2 * Math.Sqrt(aa) * Math.Sqrt(bb));

            int flag = 1; //The coefficient of the angle
            if (start.X == origin.X) //virtical
            {
                flag = (start.Y > origin.Y) ? 1 : -1;         
                flag = (end.X < start.X) ? flag : -flag;      
            }
            else //notvertical
            {
                double k = (start.Y - origin.Y) / (double)(start.X - origin.X); 
                double t = (end.Y - start.Y) - k * (end.X - start.X); 

                flag = (start.X > origin.X) ? 1 : -1; 
                flag = t > 0 ? flag : -flag; 
            }
            return flag * Math.Acos(cosagl);
        }
        #endregion

        #region 10.View Functions

        private void mnuItemZoomIn_Click(object sender, EventArgs e)
        {
            float a=1.2F*g_bmBackground.Width;
            float b=1.2F*g_bmBackground.Height;
            this.picRubberBandLayer.Width = (int)a;
            this.picRubberBandLayer.Height = (int)b;
            this.pnlBackground.Width = (int)a;
            this.pnlBackground.Height = (int)b;
            Bitmap temp = new Bitmap((int)a,(int)b, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(temp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            g.DrawImage(g_bmBackground,0,0,a,b);
            g_bmBackground = new Bitmap(temp);
            this.pnlBackground.Invalidate();
        }

        private void mnuItemZoomOut_Click(object sender, EventArgs e)
        {
            float a = 0.8F * g_bmBackground.Width;
            float b = 0.8F * g_bmBackground.Height;
            this.picRubberBandLayer.Width = (int)a;
            this.picRubberBandLayer.Height = (int)b;
            this.pnlBackground.Width = (int)a;
            this.pnlBackground.Height = (int)b;
            Bitmap temp = new Bitmap((int)a, (int)b, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(temp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            g.DrawImage(g_bmBackground, 0, 0, a, b);
            g_bmBackground = new Bitmap(temp);
            this.pnlBackground.Invalidate();
        }
        #endregion
    }
}

