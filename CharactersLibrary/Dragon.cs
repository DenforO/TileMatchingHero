using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Dragon : Enemy
    {
        public Dragon(int level) : base(level)
        {
            this.level = level;
            this.LifePoints = (rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * 300), Convert.ToInt32(Math.Sqrt(this.level) * 330)));
            Loot = Convert.ToInt32(LifePoints / 20 + rnd.Next(LifePoints / 20));
            actions.Add(this.Attack);
            actions.Add(WingedAttack);
            actions.Add(FireBreathAttack);
        }

        public override void Attack(Hero hero)
        {
            int atkValue = rnd.Next(level * 100, level * 150);
            hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
            lastActionText = $"Dragon dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} damage to your hero.";
            hero.TemporaryShieldPoints -= atkValue;
            EndingTurn = true;
        }
        public void WingedAttack(Hero hero)
        {
            if (manaPoints >= 40)
            {
                ManaPoints -= 40;
                int atkValue = rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * 50), Convert.ToInt32(Math.Sqrt(this.level) * 65));
                hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
                DefencePoints += this.level * 80;
                lastActionText = $"Dragon dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} damage and got {DefencePoints} defence points.";
                hero.TemporaryShieldPoints -= atkValue; 
                EndingTurn = true;
            }
        }

        public void FireBreathAttack(Hero hero)
        {
            if (manaPoints >= 100)
            {
                manaPoints -= 100;
                int atkValue = rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * 200), Convert.ToInt32(Math.Sqrt(this.level) * 300));
                hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
                lastActionText = $"Dragon dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} magic damage to your hero.";
                hero.TemporaryShieldPoints -= atkValue;
                Loot += Convert.ToInt32(atkValue / 50);
                EndingTurn = true;
            }
            else
                return;
        }

        public override void EndOfTurn()
        {
            base.EndOfTurn();
            LifePoints += Convert.ToInt32(Math.Sqrt(level) * 50);
        }
    }
}

