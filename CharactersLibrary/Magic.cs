using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Magic : IShopping
    {
        public delegate void Special(Hero hero, Enemy enemy);
        public string Name { get; set; }
        public string Id { get; set; }
        public string IconPath { get; set; }
        public int Price { get; set; }
        public bool Bought { get; set; }
        public string Tip { get; set; }
        public string Element { get; set; }
        public int Power { get; set; }
        public int AttackValue { get; set; }
        public int DefenceValue { get; set; }
        public int BackFireValue { get; set; }
        public int LifePointsValue { get; set; }
        public bool ShapeChanging { get; set; }
        public Special Effect { get; set; }

        public Magic()
        {
            Effect += (x,y)=> { };
        }

        //private void ShapeChange(Shape s1, Shape s2, IEnumerable<Shape> shapes)
        //{
        //    var shapesList = shapes.ToList();

        //    for (int i = 0; i < shapes.Count(); i++)
        //    {
        //        if(shapesList[i].GetType().Equals(s1.GetType()))
        //        {
        //            Shape newShape = s2;
        //            newShape.Center = shapesList[i].Center;
        //            shapesList[i].OccupiedCell.ContainedShape = newShape;
        //            shapesList[i] = newShape;
        //        }
        //    }
        //}

        public void Activate(Hero hero, Enemy enemy)
        {
            hero.LastActionText = "";

            Effect(hero, enemy);

            if (LifePointsValue > 0)
            {
                hero.LifePoints += LifePointsValue;
                hero.LastActionText += $"You gained {LifePointsValue} Life Points.";
            }
            if (DefenceValue > 0)
            {
                hero.TemporaryShieldPoints += DefenceValue;
                hero.LastActionText += $"You gained {DefenceValue} Defence Points for the next turn.";
            }
            if (BackFireValue > 0)
            {
                hero.LifePoints -= BackFireValue;
                hero.LastActionText += $"{Name} backfired {BackFireValue} Points.";
            }
            if (AttackValue > 0)
            {
                enemy.IsAttacked(AttackValue, out int damageDealt);
                hero.LastActionText += $"You dealt {damageDealt} {Element} damage to {enemy.GetType().Name}";
            }
            PowerDrain(hero);
        }
        //public void  Activate(Hero hero, Enemy enemy, Shape s1, Shape s2, IEnumerable<Shape> shapes)
        //{
        //    hero.LastActionText = "";

        //    if (LifePointsValue > 0)
        //    {
        //        hero.LifePoints += LifePointsValue;
        //        hero.LastActionText += $"You gained {LifePointsValue} Life Points.";
        //    }
        //    if (DefenceValue > 0)
        //    {
        //        hero.DefencePoints += DefenceValue;
        //        hero.LastActionText += $"You gained {DefenceValue} Defence Points for the next turn.";
        //    }
        //    if (BackFireValue > 0)
        //    {
        //        hero.LifePoints -= BackFireValue;
        //        hero.LastActionText += $"{Name} backfired {BackFireValue} Points.";
        //    }
        //    if (AttackValue > 0)
        //    {
        //        enemy.IsAttacked(AttackValue, out int damageDealt);
        //        hero.LastActionText += $"You dealt {damageDealt} {Element} damage to {enemy.GetType().Name}";
        //    }
        //    if (ShapeChanging)
        //    {
        //        ShapeChange(s1,s2, shapes);
        //    }
        //    PowerDrain(hero);
        //}


        private void PowerDrain(Hero h)
        {
            switch (Element)
            {
                case "Water":
                    h.WaterPoints -= Power;
                    break;
                case "Earth":
                    h.EarthPoints -= Power;
                    break;
                case "Fire":
                    h.FirePoints -= Power;
                    break;
                case "Air":
                    h.AirPoints -= Power;
                    break;
            }
        }
    }
}
