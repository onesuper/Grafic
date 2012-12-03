using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Grafic.MyGrafics
{
    [Serializable]
    public class Rect:ClosedShape
    {
        public Rectangle m_rtRect;    //Succeded by elli

        public Rect()
        { 
        }

        public Rect(Point start, Point end, bool IsSharply)  
        {
            SetRect(start, end, IsSharply);
            SetPath();
        }

        public override void SetPath()
        {
            Erase();
            m_grpShapePath.AddRectangle(m_rtRect);
        }

        public void SetRect(Point start, Point end, bool IsShapely)             
        {
            //Set up m_rtRect
            int height = Math.Abs(end.Y - start.Y);
            int width = Math.Abs(end.X - start.X);
            if (!IsShapely)
            {
                m_rtRect = new Rectangle(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y), width, height);
            }
            else
            {
                height = Math.Max(height, width);
                width = height;
                if (end.X < start.X && end.Y > start.Y)
                    m_rtRect = new Rectangle(start.X - width, start.Y, width, height);
                else if (end.X < start.X && end.Y < start.Y)
                    m_rtRect = new Rectangle(start.X - width, start.Y - height, width, height);
                else if (end.X > start.X && end.Y > start.Y)
                    m_rtRect = new Rectangle(start.X, start.Y, width, height);
                else
                    m_rtRect = new Rectangle(start.X, start.Y - height, width, height);
            }
        }

        public override void Translate(Size size)
        {
            m_rtRect.Offset(size.Width, size.Height);
            SetPath();
        }

        public override void Scale(double sx, double sy, Point point)   
        {
            Point center = new Point(m_rtRect.X + m_rtRect.Width / 2, m_rtRect.Y + m_rtRect.Height / 2);  //Point is a basepoint
            Point newcenter = new Point();
            newcenter.X = (int)(center.X * sx + point.X * (1 - sx));
            newcenter.Y = (int)(center.Y * sy + point.Y * (1 - sy));
            int hw = (int)(sx * m_rtRect.Width);
            int hh = (int)(sy * m_rtRect.Height);
            m_rtRect = new Rectangle(newcenter.X - hw / 2, newcenter.Y - hh / 2, hw, hh);
            SetPath();
        }

        public override void Rotate(double degree, Point point)
        {
            Point center = new Point(m_rtRect.X + m_rtRect.Width / 2, m_rtRect.Y + m_rtRect.Height / 2);

            Point[] pt = new Point[4];
            pt[0] = center;
            pt[1].X = point.X + (point.Y - center.Y);
            pt[1].Y = point.Y + (center.X - point.X);
            pt[2].X = 2 * point.X - center.X;
            pt[2].Y = 2 * point.Y - center.Y;
            pt[3].X = point.X - (point.Y - center.Y);
            pt[3].Y = point.Y - (center.X - point.X);

            if (Math.Abs(degree) <= 45 * Pi/ 180)               //  -90< degree <90
                center = pt[0];
            else if ((degree) > 45 * Pi / 180 && (degree) < 135 * Pi / 180)   //90< degree < 270
                center = pt[1];
            else if (Math.Abs(degree) >= 135 * Pi / 180)          //degree>270 or degree <-270
                center = pt[2];
            else                                                               //  -270<degree <-90
                center = pt[3];

            int halfwidth = m_rtRect.Width / 2;
            int halfheight = m_rtRect.Height / 2;
            int centerX = center.X;
            int centerY = center.Y;

            //The width and height of m_rtRect change
            if (Math.Abs(degree) >= 45 * Pi / 180 && Math.Abs(degree) <= 135 * Pi / 180)
                SetRect(new Point(centerX - halfheight, centerY - halfwidth),
                    new Point(centerX + halfheight, centerY + halfwidth), false);
            else
                SetRect(new Point(centerX - halfwidth, centerY - halfheight),
                    new Point(centerX + halfwidth, centerY + halfheight), false);
        }
    }
}
