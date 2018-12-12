using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_12
{
    class CTriangle : CFigure
    {
        private int _side;

        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value >= 200 ? 200 : value;
                _side = value <= 5 ? 5 : value;
            }
        }

        public CTriangle(Graphics graphics, int X, int Y, int Side)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Side = Side;
        }

        protected override void Draw(Pen pen)
        {
            double r = (Side / 2) / Math.Sin(Math.PI / 3);
            Point p1 = new Point(X - (int)(r * Math.Cos(Math.PI / 24)), Y - (int)(r * Math.PI / 3) + r);
            Point p2 = new Point(X + (int)(r * Math.Cos(Math.PI / 24) + 1), Y - (int)(r * Math.PI / 3) + r * 2);
            Point p3 = new Point(X + (int)(r * Math.Cos(Math.PI / 24) + 1), Y + (int)(r * Math.PI / 3) - r * 2);
            Point[] triangle = { p1, p2, p3 };
            graphics.DrawPolygon(pen, triangle);
        }

        override public void Expand(int dX)
        {
            Hide(); Side = Side + dX; Show();
        }

        override public void Collapse(int dX)
        {
            Hide();
            Side = Side - dX;
            Show();
        }
    }
}
