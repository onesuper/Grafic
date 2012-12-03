using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Grafic.Boxes;

namespace Grafic.MyGrafics
{
    [Serializable]
    public abstract class ClosedShape:Shape
    {
        public bool m_blFilled;           //the closed shape is filled or not

        public void SetFillColor(Color c)
        {
            m_clrFillColor = c;
        }

        public ClosedShape()
        {
            m_clrFillColor = ColorBoxForm.g_clrSelectedColor2;

        }

        public override void Draw(Graphics g)            
        {
            if (m_blVisible == false)
                return;
            SetPath();
            g.DrawPath(new Pen(m_clrPenColor,m_ftPenwidth), m_grpShapePath);         //Draw the path of the ClosedShape
            if (m_clrFillColor == Color.Transparent)
            {
                m_blFilled = false;
            }
            else
            {
                Brush Brush = new SolidBrush(m_clrFillColor);
                g.FillPath(Brush, m_grpShapePath);                  //Fill it
                m_blFilled = true;
            }

        }
    }
}
