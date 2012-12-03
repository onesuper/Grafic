using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafic.MyGrafics
{
    [Serializable]
    public class Elli:Rect
    {        
        public override void SetPath()
        {
            Erase();
            m_grpShapePath.AddEllipse(m_rtRect);
        }

        public Elli(Point start, Point end, bool IsShapely)
        {
            SetRect(start, end, IsShapely);
            SetPath();
        }

        public Elli()
        {
        }
    }
}
