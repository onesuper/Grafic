using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafic.MyGrafics
{
    [Serializable]
    public class Curve:NonClosedShape
    {
        private Point[] m_ptNodeOnCurve=new Point[4];
        private Rectangle[] m_rtPointRectangle = new Rectangle[4];
        public bool m_blCurveIsWaiting;
        private int m_intCurrentNodeIndex;
        public bool m_blCurveAdjusting;

        public void SetCurve(Point start, Point end)
        {
            m_ptNodeOnCurve[0] = start;
            m_ptNodeOnCurve[1].X = (int)((start.X + end.X * 0.5) / (1 + 0.5));      //1/3 Point  
            m_ptNodeOnCurve[1].Y = (int)((start.Y + end.Y * 0.5) / (1 + 0.5));
            m_ptNodeOnCurve[2].X = (int)((start.X + end.X * 2) / (1 + 2));          //2/3 Point  
            m_ptNodeOnCurve[2].Y = (int)((start.Y + end.Y * 2) / (1 + 2));
            m_ptNodeOnCurve[3] = end;
        }

        public void SetNode()
        {
            m_rtPointRectangle[0] = new Rectangle(m_ptNodeOnCurve[0].X - 3, m_ptNodeOnCurve[0].Y - 3, 6, 6);
            m_rtPointRectangle[1] = new Rectangle(m_ptNodeOnCurve[1].X - 3, m_ptNodeOnCurve[1].Y - 3, 6, 6);
            m_rtPointRectangle[2] = new Rectangle(m_ptNodeOnCurve[2].X - 3, m_ptNodeOnCurve[2].Y - 3, 6, 6);
            m_rtPointRectangle[3] = new Rectangle(m_ptNodeOnCurve[3].X - 3, m_ptNodeOnCurve[3].Y - 3, 6, 6);
        }

        public override void SetNode(int index, Point point)
        {
            if (index == -1)
                return;
            m_ptNodeOnCurve[index] = new Point(point.X, point.Y);
            m_rtPointRectangle[index] = new Rectangle(point.X - 3, point.Y - 3, 6, 6);
        }

        public void DrawNodes(Graphics g)                 //Draw rectangles on the Nodes
        {
            Pen pen = new Pen(Brushes.Black, 1F);
            for (int i = 0; i < 4; i ++)
            {
                g.DrawRectangle(pen, m_rtPointRectangle[i]);
            }
        }

        public override void SetPath()
        {
            Erase();
            m_grpShapePath.AddCurve(m_ptNodeOnCurve);
        }

        public override int GetCurrentNode(Point point)                  //if the CursePoint is in the rectangle return the index
        {
            int index=-1;
            for (int i = 0; i < 4; ++i)
            {
                if (m_rtPointRectangle[i].Contains(point))
                {
                    index = i;
                }
            }
            return index;
        }

        public void AdjustCurve(Point point, int index)                  //Move to the no.index node to cursor point
        {
            if (!m_blCurveAdjusting || m_intCurrentNodeIndex < 0)          //m_intCurrentNodeIndex=-1 
                return;
            if (index > -1) 
            {
                m_intCurrentNodeIndex = index;
            }
            SetNode(m_intCurrentNodeIndex, point);                   //Adusting Curve means Adjusting the node
            m_blCurveAdjusting = true;
        }

        public override void Draw(Graphics g)
        {
            if (m_blVisible == false)
                return;
            SetPath();
            g.DrawPath(new Pen(m_clrPenColor, m_ftPenwidth), m_grpShapePath);          //Draw the path between two points
            if (m_blShapeIsFormed == false)                           //The node will disappear when the curve is formed
                DrawNodes(g);
        }

        public override void Translate(Size size)
        {
            for (int i = 0; i < 4; ++i)
            {
                Point tmpP = m_ptNodeOnCurve[i];
                tmpP.Offset(size.Width, size.Height);
                m_ptNodeOnCurve[i] = new Point(tmpP.X, tmpP.Y);
            }
        }

        public override void Scale(double[,] S)
        {
            for (int i = 0; i < 4; ++i)
            {
                int x = (int)(S[0, 0] * m_ptNodeOnCurve[i].X + S[0, 2]);
                int y = (int)(S[1, 1] * m_ptNodeOnCurve[i].Y + S[1, 2]);
                m_ptNodeOnCurve[i] = new Point(x, y);
                m_rtPointRectangle[i] = new Rectangle(x - 3, y - 3, 6, 6);
            }
        }

        public override void Rotate(double[,] R)
        {
            for (int i = 0; i < 4; ++i)
            {
                int x1 = m_ptNodeOnCurve[i].X;
                int y1 = m_ptNodeOnCurve[i].Y;
                int x = (int)(R[0, 0] * x1 + R[0, 1] * y1 + R[0, 2]);
                int y = (int)(R[1, 0] * x1 + R[1, 1] * y1 + R[1, 2]);
                m_ptNodeOnCurve[i] = new Point(x, y);
                m_rtPointRectangle[i] = new Rectangle(x - 3, y - 3, 6, 6);
            }
        }

        public Curve()
        {

        }

        public Curve(Point start, Point end)
        {
            m_blShapeIsFormed = false;
            m_blCurveIsWaiting = false;
            SetCurve(start, end);
            SetNode();
            SetNode();
            SetPath();
        }

    }
}
