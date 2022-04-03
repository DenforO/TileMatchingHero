using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Rectangle : Shape
    {
        private Point location;

        public override Point Location
        {
            get
            {
                return new Point((2 * Center.X - Width) / 2, (2 * Center.Y - Height) / 2);
            }
            set
            {
                location = value;
            }
        }


        public int Width { get; set; }
        public int Height { get; set; }


        public Rectangle()
        {
            Height = 50;
            Width = 50;
            Color = Color.Green;
            Center = new Point((Location.X + Location.X + Width) / 2, (Location.Y + Location.Y + Height) / 2);
            Element = "Earth";
        }
        public Rectangle(Point c) : this()
        {
            Center = c;

            Location = new Point((2 * Center.X - Width) / 2, (2 * Center.Y - Height) / 2);
        }

        public Rectangle(int width, int height) : this()
        {
            this.Width = width;
            this.Height = height;
        }

        public Rectangle(int width, int height, int X, int Y, Color c) : this(width, height)
        {
            this.Location = new Point(X, Y);
            this.Color = c;

            Center = new Point((Location.X + Location.X + Width) / 2, (Location.Y + Location.Y + Height) / 2);
        }



        public override void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(
                Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
            {
                graphics.FillRectangle(brush, (2 * Center.X - Width) / 2, (2 * Center.Y - Height) / 2, Width, Height);
            }
            using (var pen = new Pen(Color, 2))
            {
                graphics.DrawRectangle(pen, (2 * Center.X - Width) / 2, (2 * Center.Y - Height) / 2, Width, Height);
            }
        }

        public override bool Contains(Point pt)
        {
            if ((pt.X > Location.X && pt.X < Location.X + Width) && (pt.Y > Location.Y && pt.Y < Location.Y + Height))
                return true;
            else return false;
        }
    }
}
