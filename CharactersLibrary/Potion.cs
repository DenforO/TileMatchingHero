using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Potion : IShopping
    {
        public Potion()
        {
            Element = "-None-";
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
        public int Price { get; set; }
        public bool Bought { get; set; }
        public string Element { get; set; }
        public string Tip { get; set; }
        public int LifePoints { get; set; }
        public int WaterPoints { get; set; }
        public int EarthPoints { get; set; }
        public int FirePoints { get; set; }
        public int AirPoints { get; set; }
        public int DefensePoints { get; set; }

        public void Use(Hero hero)
        {
            hero.LifePoints += LifePoints;
            hero.WaterPoints += WaterPoints;
            hero.EarthPoints += EarthPoints;
            hero.FirePoints += FirePoints;
            hero.AirPoints += AirPoints;
            hero.TemporaryShieldPoints += DefensePoints;
        }

    }
}
