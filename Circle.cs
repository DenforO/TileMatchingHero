using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Circle : Shape
    {
        public int Radius { get; private set; }
        public Circle(Point center)
        {
            Center = center;
            Radius = 25;
            Color = Color.DeepSkyBlue;
            Element = "Water";
        }

        public override void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(
                Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
            {
                graphics.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
            using (var pen = new Pen(Color, 2))
            {
                graphics.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }

        public override bool Contains(Point p)
        {
            return
                (Center.X - p.X) * (Center.X - p.X) + (Center.Y - p.Y) * (Center.Y - p.Y) < Radius * Radius;
        }
    }
}
