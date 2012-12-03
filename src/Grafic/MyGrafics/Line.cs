using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Grafic.Boxes;


namespace Grafic.MyGrafics
{
    [Serializable]
    public class Line:NonClosedShape
    {
        protected Point m_ptStart;    //Record the line by two points  
        protected Point m_ptEnd;

        public void SetStart(Point point)
        {
            m_ptStart= point;
        }

        public void SetEnd(Point point)
        {
            m_ptEnd = point;
        }

        public void SetLine(Point start, Point end)
        {
            m_ptStart = start;
            m_ptEnd = end;
        }

        public Point GetStart()
        {
            return m_ptStart;
        }

        public Point GetEnd()
        {
            return m_ptEnd;
            //Directional Setting
        }

        public override void Draw(Graphics g)
        {
            if (m_blVisible == false)
                return;
            SetPath();
            g.DrawPath(new Pen(m_clrPenColor, m_ftPenwidth), m_grpShapePath);          //Draw the path between two points
        }
       
        public override void SetPath()
        {
            Erase();
            m_grpShapePath.AddLine(m_ptStart, m_ptEnd);
        }

        public override void Translate(Size translation)
        {
            m_ptStart.Offset(translation.Width, translation.Height);     ///Change the two ends of lines to tanslate
            m_ptEnd.Offset(translation.Width, translation.Height);
        }

        public override void Scale(double[,] S)
        {
            m_ptStart.X = (int)(S[0, 0] * m_ptStart.X + S[0, 2]);
            m_ptStart.Y = (int)(S[1, 1] * m_ptStart.Y + S[1, 2]);
            m_ptEnd.X = (int)(S[0, 0] * m_ptEnd.X + S[0, 2]);
            m_ptEnd.Y = (int)(S[1, 1] * m_ptEnd.Y + S[1, 2]);
        }

        public override void Rotate(double[,] R)
        {
            int x1 = m_ptStart.X;
            int y1 = m_ptStart.Y;
            m_ptStart.X = (int)(R[0, 0] * x1 + R[0, 1] * y1 + R[0, 2]);
            m_ptStart.Y = (int)(R[1, 0] * x1 + R[1, 1] * y1 + R[1, 2]);

            int x2 = m_ptEnd.X;
            int y2 = m_ptEnd.Y;
            m_ptEnd.X = (int)(R[0, 0] * x2 + R[0, 1] * y2 + R[0, 2]);
            m_ptEnd.Y = (int)(R[1, 0] * x2 + R[1, 1] * y2 + R[1, 2]);
        }

        public Line()
        {
            m_ptStart = new Point(0, 0);
            m_ptEnd = new Point(0, 0);
        }

        public Line(Line l)                  //copy line
        {
            m_ptStart = l.m_ptStart;
            m_ptEnd = l.m_ptEnd;
            m_clrPenColor = l.m_clrPenColor;
            m_dsPenDash = l.m_dsPenDash;
            m_ftPenwidth = l.m_ftPenwidth;
        }
    }
}
