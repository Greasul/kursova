using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab25
{
    class CRectangle: CFigure
    {

        const int DefaultRadius = 50;
        private int _radius;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }
        public CRectangle(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CRectangle(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        protected override void Draw(Pen pen)
        {
            Rectangle rectangle2 = new Rectangle(X, Y, 2 * Radius, 2 * Radius);
            graphics.DrawRectangle(pen, rectangle2);
        }
        public override void Expand(int dR)
        {
            Hide();
            Radius += dR;
            Show();
        }
        public override void Collapse(int dR)
        {
            Hide();
            Radius -= dR;
            Show();
        }
    }
}
