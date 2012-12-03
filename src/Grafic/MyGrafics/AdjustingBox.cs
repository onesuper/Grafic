using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Grafic.MyGrafics
{
    public enum CurrentHandle
    {
        CP_NULL,                   //0
        CP_NORTHWEST,        //1
        CP_WEST,                  //2
        CP_SOUTHWEST,        //3                     
        CP_SOUTH,                //4
        CP_SOUTHEAST,          //5
        CP_EAST,                   //6
        CP_NORTHEAST,         //7
        CP_NORTH,                //8
        CP_CENTER,               //9
        CP_LEFTTOP,              //10
        CP_LEFTBOTTOM,        //11
        CP_RIGHTBOTTOM,      //12
        CP_RIGHTTOP        //13
    }
    [Serializable]
    public class AdjustingBox
    {
        public Rectangle m_rtAdjustingRect;                       //Keep the size and pos info of the adjustingbox
        public Point m_ptBasePoint;
        public Point m_ptRotationCenter;
        protected Rectangle[] m_rtHandles;
        protected Point[] m_ptHandles = new Point[4];              
        protected Point[] m_ptOldHandles = new Point[4];
        protected CurrentHandle m_nCurrentHandle;
        

        private int left;
        private int right;
        private int top;
        private int bottom;
        private int horizonCenter;
        private int virticalCenter;

        public CurrentHandle curHandle             //Get to know which handle is cursor operating on
        {
            get { return m_nCurrentHandle; }
        }



        public int GetWidth()
        {
            return right - left;
        }

        public int GetHeight()
        {
            return bottom - top;
        }

        private void SetSelectionRect()
        {
            m_rtAdjustingRect = new Rectangle(left, top, right - left, bottom - top);
        }

        public void SetAdjustingBox()
        {
            left = m_rtAdjustingRect.Left;
            right = m_rtAdjustingRect.Right;
            top = m_rtAdjustingRect.Top;
            bottom = m_rtAdjustingRect.Bottom;
            horizonCenter = (left + right) / 2;
            virticalCenter = (top + bottom) / 2;
            m_rtHandles = new Rectangle[9];
            m_ptOldHandles = new Point[4];


            //Reset the point
            
            m_ptHandles[0] = new Point(left, top);
            m_ptHandles[1] = new Point(left, bottom);
            m_ptHandles[2] = new Point(right, bottom);
            m_ptHandles[3] = new Point(right, top);

            m_ptOldHandles[0] = new Point(left, top);
            m_ptOldHandles[1] = new Point(left, bottom);
            m_ptOldHandles[2] = new Point(right, bottom);
            m_ptOldHandles[3] = new Point(right, top);
            //Set up the handle rectangle
            m_rtHandles[0] = new Rectangle(m_ptHandles[0].X - 3, m_ptHandles[0].Y - 3, 6, 6);
            m_rtHandles[2] = new Rectangle(m_ptHandles[1].X - 3, m_ptHandles[1].Y - 3, 6, 6);
            m_rtHandles[4] = new Rectangle(m_ptHandles[2].X - 3, m_ptHandles[2].Y - 3, 6, 6);
            m_rtHandles[6] = new Rectangle(m_ptHandles[3].X - 3, m_ptHandles[3].Y - 3, 6, 6);

            m_rtHandles[1] = new Rectangle((m_ptHandles[0].X + m_ptHandles[1].X) / 2 - 3, 
                (m_ptHandles[0].Y + m_ptHandles[1].Y) / 2 - 3, 6, 6);

            m_rtHandles[3] = new Rectangle((m_ptHandles[1].X + m_ptHandles[2].X) / 2 - 3,
                (m_ptHandles[1].Y + m_ptHandles[2].Y) / 2 - 3, 6, 6);

            m_rtHandles[5] = new Rectangle((m_ptHandles[2].X + m_ptHandles[3].X) / 2 - 3,
                (m_ptHandles[2].Y + m_ptHandles[3].Y) / 2 - 3, 6, 6);

            m_rtHandles[7] = new Rectangle((m_ptHandles[3].X + m_ptHandles[0].X) / 2 - 3,
                (m_ptHandles[3].Y + m_ptHandles[0].Y) / 2 - 3, 6, 6);
        }
        
        public void Draw(Graphics g)
        {
            if (m_rtHandles == null)
                return;
            Pen pen = new Pen(Brushes.Black, 1);

            //Set up the handle Rectangle
            g.DrawRectangle(pen, m_ptHandles[0].X - 3, m_ptHandles[0].Y - 3, 6, 6);
            g.DrawRectangle(pen, m_ptHandles[1].X - 3, m_ptHandles[1].Y - 3, 6, 6);
            g.DrawRectangle(pen, m_ptHandles[2].X - 3, m_ptHandles[2].Y - 3, 6, 6);
            g.DrawRectangle(pen, m_ptHandles[3].X - 3, m_ptHandles[3].Y - 3, 6, 6);
            g.DrawRectangle(pen, (m_ptHandles[0].X + m_ptHandles[1].X) / 2 - 3,
                (m_ptHandles[0].Y + m_ptHandles[1].Y) / 2 - 3, 6, 6);
            g.DrawRectangle(pen, (m_ptHandles[1].X + m_ptHandles[2].X) / 2 - 3,
                (m_ptHandles[1].Y + m_ptHandles[2].Y) / 2 - 3, 6, 6);
            g.DrawRectangle(pen, (m_ptHandles[2].X + m_ptHandles[3].X) / 2 - 3,
                (m_ptHandles[2].Y + m_ptHandles[3].Y) / 2 - 3, 6, 6);
            g.DrawRectangle(pen, (m_ptHandles[3].X + m_ptHandles[0].X) / 2 - 3,
                (m_ptHandles[3].Y + m_ptHandles[0].Y) / 2 - 3, 6, 6);

            g.DrawEllipse(pen, m_ptRotationCenter.X - 5, m_ptRotationCenter.Y - 5, 10, 10);
            pen.DashStyle = DashStyle.Dash;
            pen.DashPattern = new float[] { 5,3};
            pen.Width = 0.5F;
            g.DrawLine(pen, m_ptHandles[0], m_ptHandles[1]);
            g.DrawLine(pen, m_ptHandles[1], m_ptHandles[2]);
            g.DrawLine(pen, m_ptHandles[2], m_ptHandles[3]);
            g.DrawLine(pen, m_ptHandles[3], m_ptHandles[0]);

        }

        public bool CenterChoosed(Point point)
        {
            GraphicsPath temp = new GraphicsPath();
            temp.AddEllipse(m_ptHandles[8].X - 5, m_ptHandles[8].Y - 5, 10, 10);
            return temp.IsVisible(point);
        }

        public int GetCurrentHandle(Point point)                  //Get current handle kind according the current point
        {
            for (int i = 0; i < 8; ++i)
            {
                Rectangle temp = new Rectangle(m_rtHandles[i].Left - 8, m_rtHandles[i].Top - 8, 16, 16);     //Expand the selection area
                if (temp.Contains(point))
                {
                    m_nCurrentHandle = (CurrentHandle)(i + 1);
                    return i+1;
                }
            }
            Rectangle temp2 = new Rectangle(m_ptRotationCenter.X - 8, m_ptRotationCenter.Y - 8, 16, 16);
            if(temp2.Contains(point))
            {
                m_nCurrentHandle=(CurrentHandle)9;
                return 9;
            }
            if (m_rtAdjustingRect.Contains(point))
            {
                m_nCurrentHandle = 0;
                return 0;
            }
            else if (point.X < virticalCenter && point.Y < horizonCenter)
            {
                m_nCurrentHandle = (CurrentHandle)10;
                return 10;
            }
            else if (point.X < virticalCenter && point.Y > horizonCenter)
            {
                m_nCurrentHandle = (CurrentHandle)11;
                return 11;
            }
            else if (point.X > virticalCenter && point.Y > horizonCenter)
            {
                m_nCurrentHandle = (CurrentHandle)12;
                return 12;
            }
            else
            {
                m_nCurrentHandle = (CurrentHandle)13;
                return 13;
            }

        }

        public bool IsInHandle(Point point)
        {
            GraphicsPath tmp = new GraphicsPath();
            foreach (Point p in m_ptHandles)
                tmp.AddEllipse(p.X - 6, p.Y - 6, 12, 12);
            return tmp.IsVisible(point);
        }
        
        public void Translate(Size s)
        {
            //SetAdjustingBox();
            for (int i = 0; i < 4; ++i)
            {
                m_ptOldHandles[i] = m_ptHandles[i];
                m_ptHandles[i].Offset(s.Width, s.Height);
            }
            m_ptBasePoint.Offset(s.Width, s.Height);
            m_ptRotationCenter.Offset(s.Width, s.Height);
            m_rtAdjustingRect.Offset(s.Width, s.Height);
            SetAdjustingBox();
        }
              
        public bool Scale(Point point)
        {
            bool Changed = true;
            switch (m_nCurrentHandle)
            {
                case CurrentHandle.CP_NORTHWEST:
                    if (point.X > right - 20 || point.Y > bottom - 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(right, bottom);
                    left = point.X;
                    top = point.Y;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_SOUTHEAST:
                    if (point.X < left + 20 || point.Y < top + 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(left, top);
                    right = point.X;
                    bottom = point.Y;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_NORTHEAST:
                    if (point.X < left + 20 || point.Y > bottom - 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(left, bottom);
                    right = point.X;
                    top = point.Y;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_SOUTHWEST:
                    if (point.X > right - 20 || point.Y < top + 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(right, top);
                    left = point.X;
                    bottom = point.Y;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_WEST:
                    if (point.X > right - 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(right, virticalCenter);
                    left = point.X;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_EAST:
                    if (point.X < left + 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(left, virticalCenter);
                    right = point.X;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_NORTH:
                    if (point.Y > bottom - 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(horizonCenter, bottom);
                    top = point.Y;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                case CurrentHandle.CP_SOUTH:
                    if (point.Y < top + 20)
                    {
                        Changed = false;
                        break;
                    }
                    m_ptBasePoint = new Point(horizonCenter, top);
                    bottom = point.Y;
                    SetSelectionRect();
                    SetAdjustingBox();
                    break;
                default:
                    break;
            }
            return Changed;
        }

        public void Rotate(double[,] R)
        {
            m_ptHandles[0].X = (int)(R[0, 0] * m_ptOldHandles[0].X + R[0, 1] * m_ptOldHandles[0].Y + R[0, 2]);
            m_ptHandles[0].Y = (int)(R[1, 0] * m_ptOldHandles[0].X + R[1, 1] * m_ptOldHandles[0].Y + R[1, 2]);
            m_ptHandles[1].X = (int)(R[0, 0] * m_ptOldHandles[1].X + R[0, 1] * m_ptOldHandles[1].Y + R[0, 2]);
            m_ptHandles[1].Y = (int)(R[1, 0] * m_ptOldHandles[1].X + R[1, 1] * m_ptOldHandles[1].Y + R[1, 2]);
            m_ptHandles[2].X = (int)(R[0, 0] * m_ptOldHandles[2].X + R[0, 1] * m_ptOldHandles[2].Y + R[0, 2]);
            m_ptHandles[2].Y = (int)(R[1, 0] * m_ptOldHandles[2].X + R[1, 1] * m_ptOldHandles[2].Y + R[1, 2]);
            m_ptHandles[3].X = (int)(R[0, 0] * m_ptOldHandles[3].X + R[0, 1] * m_ptOldHandles[3].Y + R[0, 2]);
            m_ptHandles[3].Y = (int)(R[1, 0] * m_ptOldHandles[3].X + R[1, 1] * m_ptOldHandles[3].Y + R[1, 2]);
        }

        public void SetOldHandles()
        {
            for (int i = 0; i < 4; ++i)
            {
                m_ptOldHandles[i] = m_ptHandles[i];
            }
        }

        public AdjustingBox(Rectangle R)
        {
            m_rtAdjustingRect = R;
            SetAdjustingBox();
            m_ptBasePoint = new Point(horizonCenter,virticalCenter );
            m_ptRotationCenter = new Point(horizonCenter, virticalCenter);
        }

        public AdjustingBox()
        { 
        }
    }
}
