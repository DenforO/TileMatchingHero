using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        Hero MyHero = new Hero();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("MyHeroProgress"))
            {
                var binFormatter = new BinaryFormatter();
                using (var fileStream = new FileStream("MyHeroProgress", FileMode.Open, FileAccess.Read))
                    MyHero = (Hero)binFormatter.Deserialize(fileStream);
                if (MyHero.ItemsOwned == null)
                    MyHero.ItemsOwned = new List<IShopping>();
            }

            //MyHero.Coins += 250;
            CoinsLabel.Text = $"Coins: {MyHero.Coins}";
            LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
        }

        private void MainForm_Show(object sender, EventArgs e)
        {
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            using (var f = new InventoryForm())
            {
                f.MyHero_Inventory = this.MyHero;
                f.ShowDialog();
            }
        }
        private void ToShopButton_Click(object sender, EventArgs e)
        {
            using (var f = new ShopForm())
            {
                f.MyHero_Shop = this.MyHero;
                f.ShowDialog();
                this.MyHero = f.MyHero_Shop;
                CoinsLabel.Text = $"Coins: {MyHero.Coins}";
            }
        }

        #region ToBattle

        private void ToBattleButton_Click(object sender, EventArgs e)
        {
            using (var f = new BattleForm())
            {
                f.MyHero_Battle = this.MyHero;
                f.battleLevel = 1;
                f.ShowDialog();
                this.MyHero = f.MyHero_Battle;
                CoinsLabel.Text = $"Coins: {MyHero.Coins}";
                LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
            }
        }
        private void ToBattleButton2_Click(object sender, EventArgs e)
        {
            using (var f = new BattleForm())
            {
                f.MyHero_Battle = this.MyHero;
                f.battleLevel = 2;
                f.ShowDialog();
                this.MyHero = f.MyHero_Battle;
                CoinsLabel.Text = $"Coins: {MyHero.Coins}";
                LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
            }
        }
        private void ToBattleButton3_Click(object sender, EventArgs e)
        {
            using (var f = new BattleForm())
            {
                f.MyHero_Battle = this.MyHero;
                f.battleLevel = 5;
                f.ShowDialog();
                this.MyHero = f.MyHero_Battle;
                CoinsLabel.Text = $"Coins: {MyHero.Coins}";
                LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
            }
        }
        private void BossBattleButton_Click(object sender, EventArgs e)
        {
            using (var f = new BattleForm())
            {
                f.MyHero_Battle = this.MyHero;
                f.battleLevel = 10;
                f.bossBattle = true;
                f.ShowDialog();
                this.MyHero = f.MyHero_Battle;
                CoinsLabel.Text = $"Coins: {MyHero.Coins}";
                LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
            }
        }
        private void ExtremeLevelButton_Click(object sender, EventArgs e)
        {
            using (var f = new BattleForm())
            {
                f.MyHero_Battle = this.MyHero;
                f.battleLevel = 7;
                f.ShowDialog();
                this.MyHero = f.MyHero_Battle;
                CoinsLabel.Text = $"Coins: {MyHero.Coins}";
                LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
            }
        }
        #endregion

        private void StartOverButton_Click(object sender, EventArgs e)
        {
            MyHero = new Hero();
            CoinsLabel.Text = $"Coins: {MyHero.Coins}";
            LifePointsLabel.Text = $"Life Points: {MyHero.LifePoints}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var binFormatter = new BinaryFormatter();

            using (var fileStream = new FileStream("MyHeroProgress", FileMode.Create, FileAccess.Write))
            {
                binFormatter.Serialize(fileStream, MyHero);
            }
        }

        
    }
}
