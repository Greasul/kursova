using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace fdsfsdfsdfsdf
{
    class CCircle : CFigure
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
        public CCircle(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CCircle(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        protected override void Draw(Pen pen)
        {
            Rectangle rectangle1 = new Rectangle(X - Radius / 25, Y - Radius / 25,
            2 * Radius, 2 * Radius);
            graphics.DrawEllipse(pen, rectangle1);
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
