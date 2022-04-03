using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Goblin : Enemy
    {
        public Goblin(int level) : base(level)
        {
            this.level = level;
            this.LifePoints = rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * 360), Convert.ToInt32(Math.Sqrt(this.level) * 400));
            Loot = Convert.ToInt32(LifePoints / 35 + rnd.Next(LifePoints / 100));
            ManaPoints = 0;
            actions.Add(Attack);
            actions.Add(GetDefense);
            actions.Add(LevelUp);
            actions.Add(UltimateAttack);
        }


        public override void Attack(Hero hero)
        {
            int atkValue = rnd.Next(Convert.ToInt32(Math.Sqrt(this.level) * 200), Convert.ToInt32(Math.Sqrt(this.level) * 250));
            hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
            lastActionText = $"Goblin dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} damage to your hero.";
            hero.TemporaryShieldPoints -= atkValue;
            EndingTurn = true;
        }
        public void GetDefense(Hero hero)
        {
            DefencePoints += this.level * this.level * 50;
            lastActionText = $"Goblin got {DefencePoints} defence points for the next turn.";
            EndingTurn = true;
        }
        public void UltimateAttack(Hero hero)
        {
            //More powerful with less LifePoints
            if (ManaPoints == maxManaPoints)
            {
                ManaPoints = 0;
                int atkValue = level * maxManaPoints;
                hero.LifePoints -= AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints);
                lastActionText = $"Goblin dealt {AttackThroughDefense(atkValue, hero.DefencePoints + hero.TemporaryShieldPoints)} ultimate damage to your hero.";
                Loot += Convert.ToInt32(atkValue / 100);
                hero.TemporaryShieldPoints -= atkValue;
                EndingTurn = true;
            }
            else
                return;
        }
        public void LevelUp(Hero hero)
        {
            if (ManaPoints >= 90)
            {
                ManaPoints -= 90;
                level++;
                lastActionText = $"Goblin evolved  to {level} Level and gained {lifePoints/2} Life points and {lifePoints/2} Defense points!";
                DefencePoints += lifePoints / 2;
                lifePoints += lifePoints / 2;
                Loot += Convert.ToInt32(level * 2);
                EndingTurn = true;
            }
            else
                return;
        }
    }
}

