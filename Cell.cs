using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public sealed class Cell : Rectangle
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Shape ContainedShape { get; set; }
        public Cell(Point c)
        {
            Height = 50;
            Width = 50;
            Color = Color.Green;
            Center = new Point((Location.X + Location.X + Width) / 2, (Location.Y + Location.Y + Height) / 2);
            Center = c;
            Location = new Point((2 * Center.X - Width) / 2, (2 * Center.Y - Height) / 2);
        }
        public bool IsEmpty { get; set; }
    }
}
