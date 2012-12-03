using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using Grafic.Boxes;
using Grafic;

namespace Grafic.MyGrafics
{
    [Serializable]
    public abstract class Shape
    {
        public const double Pi = 3.1415926;              //Const variables for Rotation
        public DashStyle m_dsPenDash;
        public Color m_clrPenColor;
        public float m_ftPenwidth;
        public Color m_clrFillColor;
        public bool m_blVisible;
        public bool m_blSelected;
        public bool m_blAdjusting;
        [NonSerialized]
        public GraphicsPath m_grpShapePath;
        public bool m_blShapeIsFormed;             

        public Shape()
        {
            m_clrPenColor = Color.Black;
            m_ftPenwidth = 1F;
            m_blVisible=true;
            m_blSelected=false;
            m_blAdjusting=false;
            m_blShapeIsFormed = false;
           m_grpShapePath = new GraphicsPath();
        }

        public void SetPen(Color color,float width)              //A public interface to set penstyle.
        {
            m_ftPenwidth = width;
            m_clrPenColor = color;
        }

        public void SetPen(DashStyle dash,Color color, float width)    //Three refs constructing func that includes DashStyle
        {
            m_ftPenwidth = width;
            m_clrPenColor = color;
            m_dsPenDash = dash;
        }

        public virtual void Draw(Graphics g)                    //Overrided in each different shape
        { 
        }

        public virtual void Erase()
        {
            m_grpShapePath = new GraphicsPath();          //Having the new Path means the old one has been erased
        }

        public virtual void SetPath() 
        { 
            Erase(); 
        }

        public virtual void Translate(Size size)          
        {
        }

        public virtual void Scale(double[,] S)                                      //S is the 2D Scale Matrix
        {
        }
        // Scale (sx,sy) by point
        public virtual void Scale(double sx, double sy, Point point)       
        {
            double[,] S = new double[3, 3];                                            //Scale Matrix
            S[0, 0] = sx;                                                                       //   sx   0   x(1-sx)
            S[0, 1] = 0;                                                                         //  0    sy  y(1-sy)
            S[0, 2] = point.X * (1 - sx);                                                  //   0     0      1
            S[1, 0] = 0;
            S[1, 1] = sy;
            S[1, 2] = point.Y * (1 - sy);
            S[2, 0] = 0;
            S[2, 1] = 0;
            S[2, 2] = 1;
            Scale(S);
            SetPath();
        }

        public virtual void Rotate(double[,] R)                                              //R is the 2D Rotation Matrix
        {
        }

        public virtual void Rotate(double degree, Point point)                  //Rotate degree winding point
        {
            double[,] R = new double[3, 3];                                                                 
            R[0, 0] = Math.Cos(degree);                                                                      //   cos30    -sin30      x(1-cos30+sin30)
            R[0, 1] = -Math.Sin(degree);                                                                      //   sin30     cos30      y(1-cos30-sin30)
            R[0, 2] = point.X * (1 - Math.Cos(degree)) + point.Y * Math.Sin(degree);       //      0          0                       1
            R[1, 0] = Math.Sin(degree);
            R[1, 1] = Math.Cos(degree);
            R[1, 2] = point.Y * (1 - Math.Cos(degree)) - point.X * Math.Sin(degree);
            R[2, 0] = 0;
            R[2, 1] = 0;
            R[2, 2] = 1;
            Rotate(R);
            SetPath();
        }

        public virtual void SetNode(int index,Point p)
        { 
        }

        public virtual int GetCurrentNode(Point point)          //Get the index of current operating node
        {
            return 0;
        }
    }
}
