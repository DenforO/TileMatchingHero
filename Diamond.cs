using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Diamond : Shape
    {
        public int Side { get; private set; }
        private int diagonal;

        public int Diagonal
        {
            get
            {
                return Convert.ToInt32(Math.Sqrt(Side * Side * 2));
            }
            set
            {
                diagonal = value;
            }
        }

        public Diamond(Point center)
        {
            Center = center;
            Side = 40;
            Color = Color.CornflowerBlue;
            Element = "Heal";
        }

        public override void Paint(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(new Point(Center.X, Center.Y - Diagonal / 2), new Point(Center.X + Diagonal / 2, Center.Y));
            path.AddLine(new Point(Center.X + Diagonal / 2, Center.Y), new Point(Center.X, Center.Y + Diagonal / 2));
            path.AddLine(new Point(Center.X, Center.Y + Diagonal / 2), new Point(Center.X - Diagonal / 2, Center.Y));
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
                pt.X > Center.X - Diagonal / 2 && pt.X < Center.X + Diagonal / 2 &&
                pt.Y > Center.Y - Diagonal / 2 && pt.Y < Center.Y + Diagonal / 2 &&
                Math.Abs(Center.X - pt.X) + Math.Abs(Center.Y - pt.Y) < Diagonal / 2;
        }
    }
}
