using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ShopForm : Form
    {
        public Hero MyHero_Shop = new Hero();

        private List<IShopping> _items = new List<IShopping>();
        private List<IShopping> toExclude = new List<IShopping>();
        private int _lastClickedColumn = -1;
        private bool _inverse = false;

        private string show1 = "Potion";
        private string show2 = "Magic";

        private List<IShopping> _allItems = new List<IShopping>()
        {
            new Potion(){ Id = "1", Name = "Water potion", Price = 5 ,WaterPoints = 50, Tip = "Gives you 50 Water Points during battle.", IconPath = "Water-potion.png"},
            new Potion(){ Id = "2", Name = "Earth potion", Price = 5 ,EarthPoints = 50, Tip = "Gives you 50 Earth Points during battle.", IconPath = "Earth-potion.png"},
            new Potion(){ Id = "3", Name = "Fire potion", Price = 5 ,FirePoints = 50, Tip = "Gives you 50 Fire Points during battle.", IconPath = "Potion-2-icon.png"},
            new Potion(){ Id = "4", Name = "Air potion", Price = 5 ,AirPoints = 50, Tip = "Gives you 50 Air Points during battle.", IconPath = "Air-potion.png"},
            new Potion(){ Id = "5", Name = "Defense potion",Price = 10 ,DefensePoints = 200, Tip = "Gives you 200 Defence Points for a turn.", IconPath = "Potion-icon3.png"},

            new Magic() { Id = "6", Element = "Water", Name = "Healing Wave", Price = 20, LifePointsValue = 200, Power = 60, Tip = "Gives 200 Life points for 60 Water points.", IconPath = "ele-water-icon.png"},
            new Magic() { Id = "7", Element = "Earth", Name = "Stone Wall", Price = 15, DefenceValue = 150, Power = 50, Tip = "150 Defence points next turn for 50 Earth points.", IconPath = "ele-earth-icon.png" },
            new Magic() { Id = "8", Element = "Fire", Name = "Volcanic Blast", Price = 17, AttackValue = 275, BackFireValue = 100, Power = 60, Tip = "Deals 275 Damage to enemy, backfires 100 for 60 Fire Points.", IconPath = "ele-fire-icon.png" },
            new Magic() { Id = "9", Element = "Air", Name = "Dust Cloud", Price = 25, DefenceValue = 80, Power = 30, Tip = "80 Defence points next turn for 30 Air points.", IconPath = "ele-wind-icon.png" },

            new Magic(){ Id = "10", Element = "Water", Name = "Soothing Ice", Price = 70, LifePointsValue = 150, DefenceValue = 150, Power = 70, Tip = "Gives 150 Life points and Defence for 70 Water points.", IconPath = "ele-water-icon.png"},
            new Magic(){ Id = "11", Element = "Earth", Name = "Sandstorm", Price = 75, BackFireValue = 50, AttackValue = 150, DefenceValue = 100, Power = 55, Tip = "Deals 150 damage, gives 100 Defence, backfires 50 for 55 Earth Points.", IconPath = "ele-earth-icon.png"},
            new Magic(){ Id = "12", Element = "Fire", Name = "Heatwave", Price = 100, BackFireValue = 100, Effect = (x,y) => { x.LastActionText = $"{y.GetType().Name} lost {Math.Min(y.ManaPoints, 80)} Mana points.";  y.ManaPoints = Math.Max(y.ManaPoints -= 80, 0); }, Power = 80, Tip = "Your enemy loses 80 Mana ponts, backfires 100, for 80 Fire Points.", IconPath = "ele-fire-icon.png"},
            new Magic(){ Id = "13", Element = "Air", Name = "Teleport behind", Price = 80, Effect = (x,y) => {y.DefencePoints /= 2; x.LastActionText = $"You teleported behind the enemy and halved its defence."; },Power = 55, Tip = "Halves the enemy's defense for 55 Air points.", IconPath = "ele-wind-icon.png"},
            
            new Magic(){ Id = "14", Element = "Water", Name = "Shiny Raindrops", Price = 180, Effect = (x,y)=>{ if(x.AirPoints < x.WaterPoints) { x.LastActionText = "Your Air points must be more than or equal to your Water points."; } else {x.LifePoints += (x.WaterPoints*4 + x.AirPoints); x.LastActionText = $"You gained {x.WaterPoints*4 + x.AirPoints} Life Points"; x.WaterPoints = 0; x.AirPoints = 0; }},  Power = 0, Tip = "Converts your Water points x4 + your Air points to Life Points. Your Air points must be more than or equal to your Water points.", IconPath = "ele-water-icon.png"},
            new Magic(){ Id = "15", Element = "Earth", Name = "Falling boulders", Price = 135, Effect = (x,y) => {y.IsAttacked(x.TemporaryShieldPoints + x.DefencePoints, out int d); x.TemporaryShieldPoints = 0; x.LastActionText = $"You dealt {d} damage to {y.GetType().Name}."; }, Power = 65, Tip = "Converts all your defense points to damage for 65 Earth points (permanent defense stays but is counted too).", IconPath = "ele-earth-icon.png"},
            new Magic(){ Id = "16", Element = "Fire", Name = "Raging Flames", Price = 155, Effect = (x,y) => {y.IsAttacked((x.MaxLifePoints - x.LifePoints)/2, out int d); x.LastActionText = $"You dealt {d} damage to {y.GetType().Name}."; }, Power = 60, Tip = "Deals damage, equal to half the damage you've taken for 60 Fire points.", IconPath = "ele-fire-icon.png"},
            new Magic(){ Id = "17", Element = "Air", Name = "Energize", Price = 185, Effect = (x,y) => { x.FirePoints += 40; x.WaterPoints += 40; x.EarthPoints += 40; x.LastActionText="You gained 40 points of each element."; },Power = 70, Tip = "Gives you 40 points of every other element for 70 Air points.", IconPath = "ele-wind-icon.png"},

            new Magic(){ Id = "18", Element = "Water", Name = "Elemental healing", Price = 250, Effect = (x,y)=>{x.LifePoints += x.WaterPoints*3 + x.EarthPoints*3 + x.FirePoints*3 + x.AirPoints*3; x.LastActionText = $"You gained { x.WaterPoints*3 + x.EarthPoints*3 + x.FirePoints*3 + x.AirPoints*3} Life Points."; x.EarthPoints = 0; x.FirePoints = 0; x.AirPoints = 0; },  Power = 100, Tip = "Converts tripple all your elemental points to Life Points. You must have 100 Water Points.", IconPath = "ele-water-icon.png"},
            new Magic(){ Id = "19", Element = "Earth", Name = "Earthquake", Price = 190, BackFireValue = 125, Effect = (x,y) => { y.LifePoints -= 200; x.LastActionText = $"You dealt 200 damage to {y.GetType().Name}."; }, Power = 65, Tip = "Deals 200 damage (ignores defence), backfires 125 for 65 Earth Points.", IconPath = "ele-earth-icon.png"},
            new Magic(){ Id = "20", Element = "Fire", Name = "Meteorite", Price = 240, Effect = (x,y) => {y.IsAttacked(x.FirePoints * (x.EarthPoints/10), out int d); x.LastActionText = $"You dealt {d} Earth + Fire damage to {y.GetType().Name}"; x.FirePoints = 0; x.EarthPoints = 0; }, Power = 0, Tip = "Deals damage, equal to your Fire points multiplied by a tenth of your Earth points. Both get nullified.", IconPath = "ele-fire-icon.png"},
            new Magic(){ Id = "21", Element = "Air", Name = "Swift Attacks", Price = 220, Effect = (x,y) => { int damage = 0, i = 0; while(x.AirPoints >= 10) { damage += 5*++i; x.AirPoints -= 10; } y.IsAttacked( Convert.ToInt32( damage*2.5/*Math.Pow(2.1,x.AirPoints/9)/5)*/), out int d); x.LastActionText = $"You dealt {d} Air damage to {y.GetType().Name}"; },Power = 0, Tip = "The more Air points you have - the more damage it does.", IconPath = "ele-wind-icon.png"},
        };


        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            LabelsRefresh();

            comboBox1.SelectedItem = "All";

            ExcludeBought();



            ShoppingListOrder(0);
        }


        private void ShoppingList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 3) return; //Tip Column
            if (e.Column == _lastClickedColumn && !_inverse)
                _inverse = true;
            else
                _inverse = false;
            ShoppingListOrder(e.Column);
            _lastClickedColumn = e.Column;
        }


        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (ShoppingList.SelectedItems != null)
            {

                if (MyHero_Shop.Coins < int.Parse(ShoppingList.SelectedItems[0].SubItems[1].Text))
                {
                    MessageBox.Show("Not enough coins");
                    return;
                }

                MyHero_Shop.ItemsOwned.Add(new Magic() { Id = ShoppingList.SelectedItems[0].SubItems[4].Text });
                MyHero_Shop.Coins -= int.Parse(ShoppingList.SelectedItems[0].SubItems[1].Text);
                if (ShoppingList.SelectedItems[0].SubItems[2].Text == "Magic")
                    ShoppingList.Items.Remove(ShoppingList.SelectedItems[0]);

                MyHero_Shop.ItemsOwned = MyHero_Shop.ItemsOwned
                    .Join(
                    _allItems,
                    x => x.Id,
                    y => y.Id,
                    (x, y) => y)
                    .ToList();

                ExcludeBought();

                CoinsLabel.Text = $"Coins: {MyHero_Shop.Coins}";
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("All"))
            {
                show1 = "Potion";
                show2 = "Magic";
            }
            if (comboBox1.SelectedItem.Equals("Potions"))
            {
                show1 = "Potion";
                show2 = "";
            }
            if (comboBox1.SelectedItem.Equals("Magic"))
            {
                show1 = "";
                show2 = "Magic";
            }

            ShoppingListOrder(0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ExcludeBought()
        {
            toExclude = MyHero_Shop.ItemsOwned
                .Join(_allItems, x => x.Id, y => y.Id, (x, y) => y)
                .Where(x => x.GetType().Name == "Magic")
                .ToList();

            foreach (var item in toExclude)
            {
                item.Bought = true;
            }
            _items = _allItems
                .Except(toExclude)
                .ToList();
        }


        private void ShoppingListOrder(int order)
        {
            _items = _allItems
                .Where(x => !x.Bought && (x.GetType().Name == show1 || x.GetType().Name == show2))
                .ToList();

            switch (order)
            {
                case 0:
                    {
                        if (!_inverse)
                            _items = _items
                                .OrderBy(x => x.Name)
                                .ToList();
                        else

                            _items = _items
                                .OrderByDescending(x => x.Name)
                                .ToList();
                        break;
                    }

                case 1:
                    {
                        if (!_inverse)
                            _items = _items
                                .OrderBy(x => x.Price)
                                .ThenBy(x => x.Name)
                                .ToList();
                        else

                            _items = _items
                            .OrderByDescending(x => x.Price)
                            .ThenBy(x => x.Name)
                            .ToList();
                        break;
                    }
                case 2:
                    {
                        if (!_inverse)
                            _items = _items
                                .OrderBy(x => x.GetType().Name)
                                .ThenBy(x => x.Name)
                                .ToList();
                        else

                            _items = _items
                                .OrderByDescending(x => x.GetType().Name)
                                .ThenBy(x => x.Name)
                                .ToList();
                        break;
                    }

            }

            ShoppingList.Items.Clear();

            foreach (var item in _items)
            {
                ListViewItem lv1 = new ListViewItem($"{item.Name}");
                lv1.SubItems.Add($"{item.Price}");
                lv1.SubItems.Add(item.GetType().Name);
                lv1.SubItems.Add(item.Tip);
                lv1.SubItems.Add(item.Id);
                lv1.ImageKey = item.IconPath;

                ShoppingList.Items.Add(lv1);
            }
        }

        private void LabelsRefresh()
        {
            CoinsLabel.Text = $"Coins: {MyHero_Shop.Coins}";

            MaxLifePointsUpgradeLabel.Text = $"{MyHero_Shop.MaxLPUpgradeCost} coins";
            DefencePowerUpgradeLabel.Text = $"{MyHero_Shop.DefensePowerUpgradeCost} coins";
            AttackPowerUpgradeLabel.Text = $"{MyHero_Shop.AttackPowerUpgradeCost} coins";

            DefencePowerLabel.Text = $"Current: {MyHero_Shop.DefencePoints}";
            MaxLifePointsLabel.Text = $"Current: {MyHero_Shop.MaxLifePoints}";
            AttackPowerLabel.Text = $"Current: {MyHero_Shop.AttackPoints}";

        }

        #region Upgrade Buttons
        private void MaxLifePointsUpgrade_Click(object sender, EventArgs e)
        {
            if (MyHero_Shop.Coins >= MyHero_Shop.MaxLPUpgradeCost)
            {
                MyHero_Shop.MaxLifePoints += 100;
                MyHero_Shop.Coins -= MyHero_Shop.MaxLPUpgradeCost;
                MyHero_Shop.MaxLPUpgradeCost = Convert.ToInt32(MyHero_Shop.MaxLPUpgradeCost * 1.5);
                LabelsRefresh();
            }
            else
            {
                MessageBox.Show("Not enough coins");
            }
        }

        private void AttackPowerButton_Click(object sender, EventArgs e)
        {
            if (MyHero_Shop.Coins >= MyHero_Shop.AttackPowerUpgradeCost)
            {
                MyHero_Shop.AttackPoints += 30;
                MyHero_Shop.Coins -= MyHero_Shop.AttackPowerUpgradeCost;
                MyHero_Shop.AttackPowerUpgradeCost = Convert.ToInt32(MyHero_Shop.AttackPowerUpgradeCost * 1.5);
                LabelsRefresh();
            }
            else
            {
                MessageBox.Show("Not enough coins");
            }
        }

        private void DefencePowerButton_Click(object sender, EventArgs e)
        {
            if (MyHero_Shop.Coins >= MyHero_Shop.DefensePowerUpgradeCost)
            {
                MyHero_Shop.DefencePoints += 30;
                MyHero_Shop.Coins -= MyHero_Shop.DefensePowerUpgradeCost;
                MyHero_Shop.DefensePowerUpgradeCost = Convert.ToInt32(MyHero_Shop.DefensePowerUpgradeCost * 1.5);
                LabelsRefresh();
            }
            else
            {
                MessageBox.Show("Not enough coins");
            }
        }

        #endregion

    
    }
}
