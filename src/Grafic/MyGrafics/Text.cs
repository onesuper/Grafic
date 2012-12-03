using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Grafic.Boxes;

namespace Grafic.MyGrafics
{
    [Serializable]
    class Text:NonClosedShape
    {
        private Color m_clrStringColor;
        private Rectangle m_rtRect;
        private FontFamily m_ffamilyText;
        private FontStyle m_fstyleText;
        private float m_femSize;
        private String m_strText;
        private StringFormat m_strformatText;
        //A protected m_teRect  here!
        public void SetFont(FontFamily ff, FontStyle fs, float size, string s, StringFormat sf)
        {
            m_ffamilyText = ff;
            m_fstyleText = fs;
            m_femSize = size;
            m_strText = s;
            m_strformatText = sf;
        }

        public void SetRect(Point start, Point end)              //Set up m_rtRect
        {
            int height = Math.Abs(end.Y - start.Y);
            int width = Math.Abs(end.X - start.X);
            m_rtRect = new Rectangle(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y), width, height);
        }

        public override void SetPath()
        {
            Erase();
            m_grpShapePath.AddRectangle(m_rtRect);   //the path on rubber layer is a rect
           
        }

        public override void Translate(Size size)
        {
            m_rtRect.Offset(size.Width, size.Height);
            SetPath();
        }

        public void SetText()
        {
            Erase();
            m_grpShapePath.AddString(m_strText, m_ffamilyText, (int)m_fstyleText, m_femSize, m_rtRect, m_strformatText);
        }

        public void DrawPath(Graphics g)                            //Rubber band:draw the rect
         {
            if (m_blVisible == false)
                return;
            SetPath();
            g.DrawPath(new Pen(m_clrPenColor,m_ftPenwidth), m_grpShapePath);        
        }

        public override void Draw(Graphics g)                      //Draw string
        {
            if (m_blVisible == false)
                return;
            SetText();
            Brush Brush = new SolidBrush(m_clrStringColor);
            g.FillPath(Brush, m_grpShapePath);                  
        }

        public override void Scale(double sx, double sy, Point point)   //Point is a basepoint
        {
            Point center = new Point(m_rtRect.X + m_rtRect.Width / 2, m_rtRect.Y + m_rtRect.Height / 2);
            Point newcenter = new Point();
            newcenter.X = (int)(center.X * sx + point.X * (1 - sx));
            newcenter.Y = (int)(center.Y * sy + point.Y * (1 - sy));
            int hw = (int)(sx * m_rtRect.Width);
            int hh = (int)(sy * m_rtRect.Height);
            m_rtRect = new Rectangle(newcenter.X - hw / 2, newcenter.Y - hh / 2, hw, hh);
            SetPath();
        }

        public Text()
        {
        }

        public Text(Point start, Point end)
        {
            SetRect(start, end);
            SetPath();
        }

        public Text(Point start, Point end, FontFamily ff, FontStyle fs, float size, string s, StringFormat sf)
        {
            m_clrStringColor = ColorBoxForm.g_clrSelectedColor1;
            SetRect(start, end);
            m_ffamilyText = ff;
            m_fstyleText = fs;
            m_femSize = size;
            m_strText = s;
            m_strformatText = sf;
            SetFont(ff, fs, size, s, sf);
            SetText();
        }

    }
}
