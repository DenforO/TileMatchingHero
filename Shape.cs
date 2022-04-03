using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public abstract class Shape
    {
        private Point center;
        public Cell OccupiedCell { get; set; }
        public Color Color { get; set; }
        public bool ToChange { get; set; }
        public bool Drag { get; set; }
        public string Element { get; internal set; }

        public virtual Point Location { get; set; }

        public Point Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
        public abstract void Paint(Graphics g);
        public void SwitchWith(Shape s)
        {
            var temp = s.OccupiedCell;
            s.Center = this.OccupiedCell.Center;
            s.OccupiedCell = this.OccupiedCell;
            this.OccupiedCell = temp;
        }
        public abstract bool Contains(Point pt);
    }
}
