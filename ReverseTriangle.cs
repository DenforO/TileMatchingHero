using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ReverseTriangle : Triangle
    {
        public ReverseTriangle(Point center) : base(center)
        {
            Color = Color.OrangeRed;
            Element = "Fire";
        }
        public override void Paint(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(new Point(Center.X, Center.Y + H * 2 / 3), new Point(Center.X - Side / 2, Center.Y - H / 3));
            path.AddLine(new Point(Center.X - Side / 2, Center.Y - H / 3), new Point(Center.X + Side / 2, Center.Y - H / 3));
            path.CloseFigure();

            using (var brush = new SolidBrush(
                Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
            {
                graphics.FillPath(brush, path);
            }
            using (var pen = new Pen(Color, 2))
            {
                graphics.DrawPath(pen, path);
            }
        }

        public override bool Contains(Point pt)
        {
            return
                pt.X > Center.X - Side / 2 && pt.X < Center.X + Side / 2 &&
                pt.Y > Center.Y - H / 3 && pt.Y < Center.Y + H * 2 / 3 &&
                Math.Abs(Center.X - pt.X) + Math.Abs(Center.Y - H / 3 - pt.Y) < H;
        }
    }
}
