using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Hero
    {


        #region Fields

        private int lifePoints = 1000;
        private int maxLifePoints = 1000;
        private int mana = 100;
        private int maxMana = 100;
        private int waterPoints;
        private int earthPoints;
        private int firePoints;
        private int airPoints;
        private int defencePoints = 0;
        private int attackPoints = 100;
        private string lastActionText = "";
        private bool succsessfulAction = false;
        private List<IShopping> potions = new List<IShopping>();
        private Magic[] equippedMagic = new Magic[4];
        private int temporaryShieldPoints = 0;

        private int maxLPUpgradeCost = 10;
        private int attackPowerUpgradeCost = 15;
        private int defensePowerUpgradeCost = 10;

        #endregion



        #region Properties
        public int LifePoints
        {
            get { return lifePoints; }

            set
            {
                if (value < maxLifePoints)
                    lifePoints = value;
                else
                    lifePoints = maxLifePoints;
            }
        }

        public int MaxLifePoints
        {
            get
            {
                return maxLifePoints;
            }
            set
            {
                maxLifePoints = value;
            }
        }


        public int Mana
        {
            get { return mana; }
            set
            {
                if (value > maxMana) mana = maxMana;
                else if (value < 0) mana = 0;
                else mana = value;
            }
        }


        public int MaxMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }


        public int Coins { get; set; }

        public bool HasUsedPotionThisTurn { get; set; }

        public int MaxLPUpgradeCost
        {
            get { return maxLPUpgradeCost; }
            set { maxLPUpgradeCost = value; }
        }
        public int AttackPowerUpgradeCost
        {
            get { return attackPowerUpgradeCost; }
            set { attackPowerUpgradeCost = value; }
        }
        public int DefensePowerUpgradeCost
        {
            get { return defensePowerUpgradeCost; }
            set { defensePowerUpgradeCost = value; }
        }




        public int DefencePoints
        {
            get { return defencePoints; }
            set { defencePoints = value; }
        }

        public int TemporaryShieldPoints 
        {
            get
            {
                return temporaryShieldPoints;
            }
            set
            {
                if (value < 0) temporaryShieldPoints = 0;
                else temporaryShieldPoints = value;
            }
        }


        public int AttackPoints
        {
            get { return attackPoints; }
            set { attackPoints = value; }
        }

        public int WaterPoints
        {
            get
            {
                return waterPoints;
            }
            set
            {
                waterPoints = value > 100 ? 100 : value;
            }
        }
        public int EarthPoints
        {
            get
            {
                return earthPoints;
            }
            set
            {
                earthPoints = value > 100 ? 100 : value;
            }
        }
        public int FirePoints
        {
            get
            {
                return firePoints;
            }
            set
            {
                firePoints = value > 100 ? 100 : value;
            }
        }
        public int AirPoints
        {
            get
            {
                return airPoints;
            }
            set
            {
                airPoints = value > 100 ? 100 : value;
            }
        }
        public int HealPoints { get; set; }

        public int CollectedWaterPoints { get; set; }
        public int CollectedEarthPoints { get; set; }
        public int CollectedFirePoints { get; set; }
        public int CollectedAirPoints { get; set; }

        public List<IShopping> ItemsOwned
        {
            get { return potions; }
            set { potions = value; }
        }
        public Magic[] EquippedMagic
        {
            get { return equippedMagic; }
            set { equippedMagic = value; }
        }


        public string LastActionText
        {
            get { return lastActionText; }
            set { lastActionText = value; }
        }

        public bool SuccsessfulAction
        {
            get { return succsessfulAction; }
            private set { succsessfulAction = value; }
        }



        #endregion


        public Hero()
        {
            Coins = 10;

            EquippedMagic[0] = new Magic() { Id = "6", Element = "Water", Name = "Healing Wave", Price = 20, LifePointsValue = 200, Power = 60, Tip = "Gives 200 Life points for 60 Water points.", IconPath = "ele-water-icon.png"};
            EquippedMagic[1] = new Magic() { Id = "7", Element = "Earth", Name = "Stone Wall", Price = 15, DefenceValue = 150, Power = 50, Tip = "150 Defence points next turn for 50 Earth points.", IconPath = "ele-earth-icon.png" };
            EquippedMagic[2] = new Magic() { Id = "8", Element = "Fire", Name = "Volcanic Blast", Price = 17, AttackValue = 275, BackFireValue = 100, Power = 60, Tip = "Deals 275 Damage to enemy, backfires 100 for 60 Fire Points.", IconPath = "ele-fire-icon.png" };
            EquippedMagic[3] = new Magic() { Id = "9", Element = "Air", Name = "Dust Cloud", Price = 25, DefenceValue = 80, Power = 30, Tip = "80 Defence points next turn for 30 Air points.", IconPath = "ele-wind-icon.png" };

            foreach (var item in EquippedMagic)
            {
                ItemsOwned.Add(item);
            }
        }


        Random rnd = new Random();

        public void Attack(Enemy enemy)
        {
            int atkValue = (rnd.Next(Convert.ToInt32(attackPoints - attackPoints * 0.25), Convert.ToInt32(attackPoints + attackPoints * 0.25)));
            enemy.IsAttacked(atkValue, out int damage);
            lastActionText = $"You dealt {damage} damage to {enemy.GetType().Name}";
            succsessfulAction = true;
        }

        public void MagicAttack(Enemy enemy)
        {
            int atkValue = rnd.Next(attackPoints, attackPoints * 2);
            if (mana >= 60)
            {
                mana -= 60;
                enemy.IsAttacked(atkValue, out int damage);
                lastActionText = $"You dealt {damage} magic damage to {enemy.GetType().Name}";
                succsessfulAction = true;
            }
            else
                lastActionText = "You don't have enough mana for this action.";
        }

        public void Magic(Magic magic, Enemy enemy)
        {
            if (
                (magic.Element == "Water" && WaterPoints < magic.Power) ||
                (magic.Element == "Earth" && EarthPoints < magic.Power) ||
                (magic.Element == "Fire" && FirePoints < magic.Power) ||
                (magic.Element == "Air" && AirPoints < magic.Power))
            {
                lastActionText = $"You don't have enough {magic.Element} points for this action.";
                return;
            }
            else
            {
                magic.Activate(this, enemy);
            }
        }


        public void EndTurn()
        {
            succsessfulAction = false;
            HasUsedPotionThisTurn = false;
            Mana += 15;
        }
    }
}
