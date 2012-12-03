using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Grafic.MyGrafics
{
    [Serializable]
    class RoundedRect:Rect
    {
        private const int c_intCornerRadius=8;
        public bool g_blRdRectHasBeenCreated;

        public RoundedRect(Point start, Point end, bool IsShapely)
        {
            SetRect(start, end, IsShapely);
            SetPath();
        }

        public RoundedRect()
        {
            g_blRdRectHasBeenCreated = false;
        }

        public override void SetPath()
        {
            Erase();
            m_grpShapePath.AddArc(m_rtRect.X, m_rtRect.Y, c_intCornerRadius * 2, 
                c_intCornerRadius * 2, 180, 90);

            m_grpShapePath.AddLine(m_rtRect.X + c_intCornerRadius, m_rtRect.Y,
                m_rtRect.Right - c_intCornerRadius * 2, m_rtRect.Y);

            m_grpShapePath.AddArc(m_rtRect.X + m_rtRect.Width - c_intCornerRadius * 2, 
                m_rtRect.Y, c_intCornerRadius * 2, c_intCornerRadius * 2, 270, 90);

            m_grpShapePath.AddLine(m_rtRect.Right, m_rtRect.Y + c_intCornerRadius * 2,
                m_rtRect.Right, m_rtRect.Y + m_rtRect.Height - c_intCornerRadius * 2);

            m_grpShapePath.AddArc(m_rtRect.X + m_rtRect.Width - c_intCornerRadius * 2, 
                m_rtRect.Y + m_rtRect.Height - c_intCornerRadius * 2, c_intCornerRadius * 2,c_intCornerRadius * 2, 0, 90);

            m_grpShapePath.AddLine(m_rtRect.Right - c_intCornerRadius * 2,
                m_rtRect.Bottom, m_rtRect.X + c_intCornerRadius * 2, m_rtRect.Bottom);

            m_grpShapePath.AddArc(m_rtRect.X, m_rtRect.Bottom - c_intCornerRadius * 2,
                c_intCornerRadius * 2, c_intCornerRadius * 2, 90, 90);

            m_grpShapePath.AddLine(m_rtRect.X, m_rtRect.Bottom - c_intCornerRadius * 2,
                m_rtRect.X, m_rtRect.Y + c_intCornerRadius * 2);

            m_grpShapePath.CloseFigure();
        }


        public override void Draw(Graphics g)
        {
            if (m_blVisible == false)
                return;
            SetPath();
            if (g_blRdRectHasBeenCreated == true)
            {
                g.DrawPath(new Pen(m_clrPenColor, m_ftPenwidth), m_grpShapePath);          //Draw the path of the ClosedShape
            }
        }


    }
}
