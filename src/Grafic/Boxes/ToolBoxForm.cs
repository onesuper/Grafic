using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Grafic.MyGrafics;

namespace Grafic.Boxes
{
    public partial class ToolBoxForm : Form
    {
        public MainForm frmMainForm;            
        
        //ToolMode Table
        public enum ToolMode
        {
            Move, Ellipse, Rectangle, RoundedRectangle, FreeFormShape,
            Line, Pencil, Brush, Eraser, Text,
            Adjust, ColorPicker, PaintBucket, FillBorder, Curve,
            RectangleSelect, EllipseSelect, LassoSelect, MagicWand, CloneStamp
        }

        //Telling the Grafic the Mode you are using
        public static ToolMode g_tmUsingToolMode;
        public static float g_ftLineWidth;
        public static int g_intBrushStyle;            //1.Solid  2.Hatch 3.Texture 4.Linear
        public static int g_intBrushWidth;
        public static int g_intEraserWidth;

        public ToolBoxForm()
        {
            InitializeComponent();
        }

        private void ToolBoxForm_Load(object sender, EventArgs e)
        {
            frmMainForm = new MainForm();
            

            g_tmUsingToolMode = ToolMode.Move;
            g_ftLineWidth = 1;
            g_intBrushStyle = 1;
            g_intBrushWidth = 20;
            g_intEraserWidth = 5;
            this.cboBrushStyle.SelectedIndex = 0;
            this.cboLineWidth.SelectedIndex = 0;
            this.cboBrushWidth.SelectedIndex = 3;
            this.cboEraserWidth.SelectedIndex = 0;
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Buttons
            toolTip1.SetToolTip(this.btnToolSelectAndMove, "选择&移动");
            toolTip1.SetToolTip(this.btnToolLine, "直线&曲线");
            toolTip1.SetToolTip(this.btnToolBrush,"画刷");
            toolTip1.SetToolTip(this.btnToolEraser, "橡皮");
            toolTip1.SetToolTip(this.btnToolText, "字体");
            toolTip1.SetToolTip(this.btnToolPencil, "铅笔");
            toolTip1.SetToolTip(this.btnToolRectangle, "矩形");
            toolTip1.SetToolTip(this.btnToolRoundedRectangle, "圆角矩形");
            toolTip1.SetToolTip(this.btnToolFreeFormShape, "任意多边形");
            toolTip1.SetToolTip(this.btnToolEllipse, "椭圆");
            toolTip1.SetToolTip(this.btnToolColorPicker, "吸管");
            toolTip1.SetToolTip(this.btnToolFillBorder, "区域填充");
            toolTip1.SetToolTip(this.btnPaintBucket, "图形填充");
            toolTip1.SetToolTip(this.btnToolCurve,"曲线");
            
            //Not open yet
            toolTip1.SetToolTip(this.btnRectangleSelect, "尚未开放");
            toolTip1.SetToolTip(this.btnToolEllipseSelect, "尚未开放");
             toolTip1.SetToolTip(this.btnToolLassoSelect, "尚未开放");
             toolTip1.SetToolTip(this.btnToolMagicWand, "尚未开放");
             toolTip1.SetToolTip(this.btnToolCloneStamp, "尚未开放");
             toolTip1.SetToolTip(this.btnToolAdjust, "尚未开放");

        }

        private void ToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();               //hide the form when you close it
            MainForm.g_blToolBoxIsShow = false;

        }

        #region RadioButtons

        //Making the Tool selection by radio buttons
        //Each time only one button is enabled telling the Tool mode that has been selected
        private void btnToolSelectAndMove_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Move;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }

        }

        private void rdbtnToolLine_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Line;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }            
        }

        private void rdbtnToolModeCircle_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Ellipse;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void rdbtnToolModeRectangle_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Rectangle;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolRoundedRectangle_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.RoundedRectangle;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolFreeFormShape_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.FreeFormShape;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolPencil_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Pencil;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolBrush_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Brush;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolEraser_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Eraser;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolText_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Text;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolPan_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Adjust;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolColorPicker_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.ColorPicker;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnPaintBucket_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.PaintBucket;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolFillBorder_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.FillBorder;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolSparyPaint_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.Curve;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnRectangleSelect_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.RectangleSelect;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolEllipseSelect_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.EllipseSelect;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolLassoSelect_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.LassoSelect;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolMagicWand_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.MagicWand;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        private void btnToolCloneStamp_CheckedChanged(object sender, EventArgs e)
        {
            g_tmUsingToolMode = ToolMode.CloneStamp;
            if (MainForm.g_lstShapeList.Count > 0)
            {
                MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1].m_blShapeIsFormed = true;
            }
        }

        #endregion

        private void cboLineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cboLineWidth.SelectedIndex)
            {
                case 0:
                    g_ftLineWidth = 1F;
                    break;
                case 1:
                    g_ftLineWidth = 1.5F;
                    break;
                case 2:
                    g_ftLineWidth = 2.0F;
                    break;
                case 3:
                    g_ftLineWidth = 2.5F;
                    break;
            }
        }

        private void cboBrushStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cboBrushStyle.SelectedIndex)
            {
                   case 0:
                    g_intBrushStyle=1;
                    break;
                case 1:
                    g_intBrushStyle=2;
                    break;
                case 2:
                    g_intBrushStyle=3;
                    break;
            }

        }

        private void cboBrushWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboBrushWidth.SelectedIndex)
            {
                case 0:
                    g_intBrushWidth = 5;
                    break;
                case 1:
                    g_intBrushWidth = 10;
                    break;
                case 2:
                    g_intBrushWidth = 15;
                    break;
                case 3:
                    g_intBrushWidth = 20;
                    break;
            }
        }

        private void cboEraserWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboEraserWidth.SelectedIndex)
            {
                case 0:
                    g_intEraserWidth = 5;
                    break;
                case 1:
                    g_intEraserWidth = 10;
                    break;
                case 2:
                    g_intEraserWidth = 15;
                    break;
            }

        }



    }
}
