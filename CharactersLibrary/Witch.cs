using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Witch : Enemy
    {
        private int maxLifePoints;

        public Witch(int level) : base(level)
        {
            this.level = level;
            this.LifePoints = rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * 300), Convert.ToInt32(Math.Sqrt(this.level) * 330));
            maxLifePoints = LifePoints;
            Loot = Convert.ToInt32(LifePoints / 100 + rnd.Next(LifePoints / 100));
            actions.Add(this.Attack);
            actions.Add(MagicAttack);
        }

        public override void Attack(Hero hero)
        {
            //More powerful with high LifePoints
            int atkValue = rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * this.LifePoints * 0.3), Convert.ToInt32(Math.Sqrt(this.level) * (this.LifePoints + 50) * 0.3));
            hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
            lastActionText = $"Witch dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} damage to your hero.";
            hero.TemporaryShieldPoints -= atkValue;
            EndingTurn = true;
        }

        public void MagicAttack(Hero hero)
        {
            //More powerful with less LifePoints
            if (manaPoints >= 90)
            {
                manaPoints -= 90;
                int atkValue = rnd.Next(Convert.ToInt32(2 * Math.Sqrt(this.level) * (0.5 * maxLifePoints - 0.5 * LifePoints)), Convert.ToInt32(2 * Math.Sqrt(this.level) * ((0.5 * maxLifePoints) - 0.5 * LifePoints)));
                hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
                lastActionText = $"Witch dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} magic damage to your hero.";
                Loot += Convert.ToInt32(atkValue / 100);
                hero.TemporaryShieldPoints -= atkValue;
                EndingTurn = true;
            }
            else
                return;
        }
    }


}
