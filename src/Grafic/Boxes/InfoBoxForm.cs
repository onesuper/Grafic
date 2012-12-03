using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafic.Boxes
{
    public partial class InfoBoxForm : Form
    {
   

        private Byte m_clrCurrentColorR;
        private Byte m_clrCurrentColorG;
        private Byte m_clrCurrentColorB;
        private int m_intCursorX;
        private int m_intCursorY;
        private int m_intImageWidth;
        private int m_intImageHeight;
        private bool m_blInPaintingArea;

        public void Clear()
        {
            m_blInPaintingArea = false;
            this.Invalidate();
        }

        public void SetColorRGB(Byte R, Byte G, Byte B)
        {
            m_clrCurrentColorR=R;
            m_clrCurrentColorG=G;
            m_clrCurrentColorB=B;
            this.Invalidate();
        }

        public void SetCurrentCursor(Point p)
        {
            m_blInPaintingArea = true;
            m_intCursorX = p.X;
            m_intCursorY = p.Y;
            this.Invalidate();
        }

        public void SetSize(Point start, Point end)
        {
            m_intImageWidth = Math.Abs(end.X - start.X);
            m_intImageHeight = Math.Abs(end.Y - start.Y);
            this.Invalidate();
        }

        public InfoBoxForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            m_blInPaintingArea = false;
        }

        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();                               //hide the form when you close it
            MainForm.g_blInfoBoxIsShow = false;
        }

        private void InfoBoxForm_Paint(object sender, PaintEventArgs e)
        {

            if (m_blInPaintingArea == true)
            {
                this.lblCursorX.Text = "X:" + m_intCursorX.ToString();
                this.lblCursorY.Text = "Y:" + m_intCursorY.ToString();
                this.lblColorR.Text = "R:" + m_clrCurrentColorR.ToString();
                this.lblColorG.Text = "G:" + m_clrCurrentColorG.ToString();
                this.lblColorB.Text = "B:" + m_clrCurrentColorB.ToString();
                this.lblImageWidth.Text = "W:" + m_intImageWidth.ToString();
                this.lblImageHeight.Text = "H:" + m_intImageHeight.ToString();
            }
            else
            {
                this.lblCursorX.Text = "X:";
                this.lblCursorY.Text = "Y:";
                this.lblColorR.Text = "R:";
                this.lblColorG.Text = "G:";
                this.lblColorB.Text = "B:";
                this.lblImageWidth.Text = "W:";
                this.lblImageHeight.Text = "H:";
            }
        }


    }
}
