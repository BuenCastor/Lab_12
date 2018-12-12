using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_12
{
    abstract class CFigure
    {
        protected Graphics graphics;
        public int X { get; set; }
        public int Y { get; set; }

        abstract protected void Draw(Pen pen);

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }

        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
        abstract public void Expand(int dR);
        abstract public void Collapse(int dR);
    }
}
