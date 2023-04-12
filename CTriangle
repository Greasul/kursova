using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdsfsdfsdfsdf
{
    class CTriangle : CFigure
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
        public CTriangle(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CTriangle(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        protected override void Draw(Pen pen)
        {
            Matrix matrix = new Matrix();
            double a = Math.Sqrt(3) * Radius;
            double h = Math.Sqrt(a * a - Math.Pow(a / 2, 2));
            int X1 = (int)((2 * Radius - a) / 2);
            Point p4 = new Point(X + X1, Y + Radius + Radius / 2);
            Point p5 = new Point(X + X1 + (int)a, Y + Radius + Radius / 2);
            Point p6 = new Point(X + Radius, Y);
            Point[] triangle2 = { p4, p5, p6 };
            graphics.DrawPolygon(pen, triangle2);
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
