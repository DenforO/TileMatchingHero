using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public abstract class Enemy
    {
        protected delegate void Actions(Hero hero);

        protected List<Actions> actions = new List<Actions>();

        protected int level;

        protected int lifePoints;

        protected int manaPoints;

        protected int maxManaPoints;

        protected string lastActionText;

        private bool endingTurn = false;

        public Enemy(int level)
        {
            this.level = level;
            manaPoints = Convert.ToInt32(100 * this.level);
            maxManaPoints = manaPoints;
        }
        public int Loot { get; set; }


        protected Random rnd = new Random();

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
            }
        }
        public int ManaPoints
        {
            get { return manaPoints; }
            set
            {
                if (value > maxManaPoints)
                    manaPoints = maxManaPoints;
                else
                    manaPoints = value;
            }
        }


        public int MaxManaPoints
        {
            get { return maxManaPoints; }
            set {  }
        }


        public int LifePoints
        {
            get { return lifePoints; }
            set { lifePoints = value; }
        }

        public int DefencePoints { get; set; }

        public string LastActionText
        {
            get { return lastActionText; }
            protected set { lastActionText = value; }
        }

        public bool EndingTurn
        {
            get { return endingTurn; }
            protected set { endingTurn = value; }
        }


        public abstract void Attack(Hero hero);

        public void IsAttacked(int atkValue, out int damageDealt)
        {
            damageDealt = AttackThroughDefense(atkValue, this.DefencePoints);
            this.DefencePoints = atkValue > DefencePoints ? 0 : DefencePoints - atkValue;
            this.LifePoints -= damageDealt;
        }

        public bool IsDestroyed()
        {
            if (lifePoints <= 0)
                return true;
            else
                return false;
        }

        public void StartOfTurn(Hero hero)
        {
            DefencePoints = 0;
            actions[rnd.Next(actions.Count)](hero);
        }

        public virtual void EndOfTurn()
        {
            EndingTurn = false;
            ManaPoints += this.level * 15;
        }

        public int AttackThroughDefense(int attack, int defence)
        {
            if (attack > defence)
                return attack -= defence;
            else
                return attack = 0;
        }
    }
}
