using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BattleForm : Form
    {
        #region Fields

        public Hero MyHero_Battle = new Hero();

        private Enemy[] enemies = new Enemy[3];
        private int enemyCounter = 0;
        public int battleLevel;
        public bool bossBattle;
        private int loot;
        private bool gameOver;

        private List<Shape> shapes = new List<Shape>();
        private Cell[,] cells = new Cell[5, 5];

        private bool dragging = false;
        private Point dragPoint = new Point();
        private int offsetX;
        private int offsetY;

        private bool atLeasOneToChange = true;

        private bool inPlace;

        private int multiplier = 1;

        private bool enabledShapes = true;

        #endregion


        public BattleForm()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MyToolTip.SetToolTip(AttackButton, $"A basic attack with roughly {MyHero_Battle.AttackPoints} Points of power.");
            MyToolTip.SetToolTip(InventoryButton, $"Check your inventory for something useful.");
            AirButton.Text = MyHero_Battle.EquippedMagic[3].Name;
            MyToolTip.SetToolTip(AirButton, MyHero_Battle.EquippedMagic[3].Tip);
            WaterButton.Text = MyHero_Battle.EquippedMagic[0].Name;
            MyToolTip.SetToolTip(WaterButton, MyHero_Battle.EquippedMagic[0].Tip);
            EarthButton.Text = MyHero_Battle.EquippedMagic[1].Name;
            MyToolTip.SetToolTip(EarthButton, MyHero_Battle.EquippedMagic[1].Tip);
            FireButton.Text = MyHero_Battle.EquippedMagic[2].Name;
            MyToolTip.SetToolTip(FireButton, MyHero_Battle.EquippedMagic[2].Tip);

            MyHero_Battle.Mana = MyHero_Battle.MaxMana;
            if (bossBattle)
            {
                enemies = new Enemy[1];
                enemies[0] = new Dragon(10);
                pictureBoxEnemy.Image = Properties.Resources.Fire_Dragon_icon;
            }
            else
            {
                enemies = new Enemy[2 + battleLevel];
                enemies[0] = RandomEnemy(battleLevel);
                enemies[0].DefencePoints = 75 * enemies[0].Level;
            }

            LabelsRefresh();
            LastActionLabel.Text = $"A new {enemies[enemyCounter].GetType().Name} appeared!";


            Point cellCenter = new Point(290, 90);
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                cells[i, 0] = new Cell(cellCenter) { Height = 70, Width = 70, Row = i + 1, Col = 1, Color = Color.Blue };

                for (int j = 0; j < cells.GetLength(1) - 1; j++)
                {
                    cellCenter.X += 70;
                    cells[i, j + 1] = new Cell(cellCenter) { Height = 70, Width = 70, Row = i + 1, Col = j + 2, Color = Color.Blue };
                }

                cellCenter.X = 290;
                cellCenter.Y += 70;
            }

            foreach (var cell in cells)
            {
                System.Threading.Thread.Sleep(10);
                var shape = RandomShape(new Point(cell.Center.X, cell.Center.Y));
                shape.OccupiedCell = cell;
                cell.ContainedShape = shape;
                cell.IsEmpty = false;
                shapes.Add(shape);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j].Paint(e.Graphics);
                }
            }

            foreach (var shape in shapes)
                shape.Paint(e.Graphics);
        }


        private void AttackButton_Click(object sender, EventArgs e)
        {
            MyHero_Battle.Attack(enemies[enemyCounter]);
            LabelsRefresh();
            LastActionLabel.Text = $"{MyHero_Battle.LastActionText}";
            AttackButton.Enabled = false;
        }

        private void WaterButton_Click(object sender, EventArgs e)
        {
            //MyHero_Battle.MagicAttack(enemies[enemyCounter]);
            //LabelsRefresh();
            //LastActionLabel.Text = $"{MyHero_Battle.LastActionText}";
            //if (MyHero_Battle.SuccsessfulAction)
            //    ActionButtonsGroup.Enabled = false;

            MyHero_Battle.Magic(MyHero_Battle.EquippedMagic[0], enemies[enemyCounter]);
            LabelsRefresh();
            LastActionLabel.Text = $"{MyHero_Battle.LastActionText}";
        }

        private void EarthButton_Click(object sender, EventArgs e)
        {
            MyHero_Battle.Magic(MyHero_Battle.EquippedMagic[1], enemies[enemyCounter]);
            LabelsRefresh();
            LastActionLabel.Text = $"{MyHero_Battle.LastActionText}";
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            MyHero_Battle.Magic(MyHero_Battle.EquippedMagic[2], enemies[enemyCounter]);
            LabelsRefresh();
            LastActionLabel.Text = $"{MyHero_Battle.LastActionText}";
        }

        private void AirButton_Click(object sender, EventArgs e)
        {
            MyHero_Battle.Magic(MyHero_Battle.EquippedMagic[3], enemies[enemyCounter]);
            LabelsRefresh();
            LastActionLabel.Text = $"{MyHero_Battle.LastActionText}";
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            using (var f = new InventoryForm())
            {
                f.MyHero_Inventory = this.MyHero_Battle;
                f.duringBattle = true;
                f.ShowDialog();
            }
            LabelsRefresh();
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            MyHero_Battle.EndTurn();

            AttackButton.Enabled = true;

            enabledShapes = true;

            if (enemies[enemyCounter].IsDestroyed())
            {
                loot += enemies[enemyCounter].Loot;
                enemyCounter++;
                if (enemyCounter + 1 > enemies.Length)
                {
                    MyHero_Battle.Coins += loot;
                    this.Close();
                    return;
                }
                enemies[enemyCounter] = RandomEnemy(battleLevel);
                enemies[enemyCounter].DefencePoints = 75 * enemies[enemyCounter].Level;
                LastActionLabel.Text = $"A new {enemies[enemyCounter].GetType().Name} appeared!";
                LabelsRefresh();
                return;
            }
            LabelsRefresh();


            while (!enemies[enemyCounter].EndingTurn)
            {
                enemies[enemyCounter].StartOfTurn(MyHero_Battle);
            }
            enemies[enemyCounter].EndOfTurn();
            LabelsRefresh();
            LastActionLabel.Text = $"{enemies[enemyCounter].LastActionText}";


            MyHero_Battle.TemporaryShieldPoints = 0;
            if (MyHero_Battle.LifePoints <= 0)
            {
                MyHero_Battle = new Hero();
                MessageBox.Show("Game over!");
                gameOver = true;
                Close();
            }

        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DefensePointsLabel.Text = $"Defense points: {MyHero_Battle.DefencePoints + MyHero_Battle.TemporaryShieldPoints}";
            GameTimer.Enabled = false;

            if (enabledShapes)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Contains(e.Location))
                    {
                        offsetX = e.Location.X - shape.Center.X;
                        offsetY = e.Location.Y - shape.Center.Y;
                        shape.Drag = true;
                        dragging = true;
                        break;
                    }
                }
            }

            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Drag)
                    {
                        dragPoint.X = e.Location.X - offsetX;
                        dragPoint.Y = e.Location.Y - offsetY;
                        shape.Center = dragPoint;
                        Invalidate();
                        Application.DoEvents();

                        foreach (var cell in cells)
                        {
                            if (cell == shape.OccupiedCell)
                                continue;
                            if (cell.Contains(e.Location))
                            {
                                foreach (var otherShape in shapes)
                                {
                                    if (otherShape.OccupiedCell == cell)
                                        shape.SwitchWith(otherShape);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

            foreach (var shape in shapes)
            {
                shape.Drag = false;

                shape.Center = shape.OccupiedCell.Center;
                foreach (var cell in cells)
                {
                    if (cell.Center == shape.Center)
                        cell.ContainedShape = shape;
                }
            }

            do
            {
                atLeasOneToChange = false;

                MoreThanTwoTogether();

                foreach (var shape in shapes)
                {
                    if (shape.ToChange)
                    {
                        atLeasOneToChange = true;
                        shape.OccupiedCell.IsEmpty = true;
                        shape.OccupiedCell.ContainedShape = null;

                        switch (shape.Element)
                        {
                            case "Water":
                                MyHero_Battle.CollectedWaterPoints++;
                                break;
                            case "Earth":
                                MyHero_Battle.CollectedEarthPoints++;
                                break;
                            case "Fire":
                                MyHero_Battle.CollectedFirePoints++;
                                break;
                            case "Air":
                                MyHero_Battle.CollectedAirPoints++;
                                break;
                            case "Heal":
                                MyHero_Battle.HealPoints++;
                                break;
                        }
                    }
                }

                shapes = shapes
                    .Where(x => !x.ToChange)
                    .ToList();

                Fill();

                GameTimer.Enabled = true;

                Invalidate();

                System.Threading.Thread.Sleep(250);

                Application.DoEvents();

            } while (atLeasOneToChange);

            MyHero_Battle.WaterPoints += MyHero_Battle.CollectedWaterPoints * multiplier;
            MyHero_Battle.EarthPoints += MyHero_Battle.CollectedEarthPoints * multiplier;
            MyHero_Battle.FirePoints += MyHero_Battle.CollectedFirePoints * multiplier;
            MyHero_Battle.AirPoints += MyHero_Battle.CollectedAirPoints * multiplier;
            MyHero_Battle.HealPoints *= multiplier;

            MyHero_Battle.LifePoints += MyHero_Battle.HealPoints;

            MyHero_Battle.CollectedWaterPoints = 0;
            MyHero_Battle.CollectedEarthPoints = 0;
            MyHero_Battle.CollectedFirePoints = 0;
            MyHero_Battle.CollectedAirPoints = 0;
            MyHero_Battle.HealPoints = 0;

            multiplier = 1;

            enabledShapes = false;

            LabelsRefresh();
        }



        private void MoreThanTwoTogether()
        {
            int counter = 0;

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    for (int k = i + 1; k < cells.GetLength(0); k++)
                    {
                        if (cells[i, j].ContainedShape.Color == cells[k, j].ContainedShape.Color)
                        {
                            counter++;
                            if (counter >= 2)
                            {
                                cells[i, j].ContainedShape.ToChange = true;
                                cells[k - 1, j].ContainedShape.ToChange = true;
                                cells[k, j].ContainedShape.ToChange = true;

                                if (counter == 2)
                                    multiplier++;
                            }
                        }
                        else
                            break;
                    }
                    counter = 0;

                    for (int k = j + 1; k < cells.GetLength(1); k++)
                    {
                        if (cells[i, j].ContainedShape.Color == cells[i, k].ContainedShape.Color)
                        {
                            counter++;
                            if (counter >= 2)
                            {
                                cells[i, j].ContainedShape.ToChange = true;
                                cells[i, k - 1].ContainedShape.ToChange = true;
                                cells[i, k].ContainedShape.ToChange = true;

                                if (counter == 2)
                                    multiplier++;
                            }
                        }
                        else
                            break;
                    }
                    counter = 0;
                }
            }
        }

        private void Fill()
        {
            bool isFull = false;
            while (!isFull)
            {
                isFull = true;

                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    for (int i = 0; i < cells.GetLength(0); i++)
                    {
                        if (cells[i, j].IsEmpty)
                        {
                            isFull = false;

                            if (i == 0)
                            {
                                System.Threading.Thread.Sleep(15);
                                var shape = RandomShape(new Point(cells[i, j].Center.X, cells[i, j].Center.Y - 100));
                                shape.OccupiedCell = cells[i, j];
                                cells[i, j].ContainedShape = shape;
                                cells[i, j].IsEmpty = false;
                                shapes.Add(shape);
                            }

                            else
                            {
                                cells[i, j].ContainedShape = cells[i - 1, j].ContainedShape;
                                cells[i - 1, j].ContainedShape.OccupiedCell = cells[i, j];
                                cells[i - 1, j].IsEmpty = true;
                                cells[i - 1, j].ContainedShape = null;
                                cells[i, j].IsEmpty = false;
                            }
                        }
                    }
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            inPlace = false;

            while (!inPlace)
            {
                inPlace = true;
                foreach (var shape in shapes)
                {
                    if (shape.Center != shape.OccupiedCell.Center)
                    {
                        inPlace = false;
                        shape.Center = new Point(shape.Center.X, shape.Center.Y + 5);
                        Invalidate();
                        Application.DoEvents();
                    }
                }
            }
        }



        private Enemy RandomEnemy(int level)
        {
            Random rnd = new Random();
            int num = rnd.Next(10);
            //More likely to battle a Goblin
            if (num < 5)
            {
                pictureBoxEnemy.Image = Properties.Resources.Goblin2;
                return new Goblin(level);
            }
            else if (num >= 5 && num < 9)
            {
                pictureBoxEnemy.Image = Properties.Resources.Witch;
                return new Witch(level);
            }
            else
            {
                pictureBoxEnemy.Image = Properties.Resources.Fire_Dragon_icon;
                return new Dragon(level);
            }
        }

        private Shape RandomShape(Point center)
        {
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[4];
                rg.GetBytes(rno);
                int randomvalue = BitConverter.ToInt32(rno, 0);

                //Random rnd = new Random();
                //int n = rnd.Next(1, 4);
                switch (Math.Abs(randomvalue % 5))
                {
                    case 0:
                        return new Rectangle(center);
                    case 1:
                        return new Circle(center);
                    case 2:
                        return new Diamond(center);
                    case 3:
                        return new ReverseTriangle(center);
                    default:
                        return new Triangle(center);
                }
            }
        }

        private void LabelsRefresh()
        {
            LifePointsLabel.Text = $"Life Points: {MyHero_Battle.LifePoints}";
            WaterPointsLabel.Text = $"Water: {MyHero_Battle.WaterPoints}";
            EarthPointsLabel.Text = $"Earth: {MyHero_Battle.EarthPoints}";
            FirePointsLabel.Text = $"Fire: {MyHero_Battle.FirePoints}";
            AirPointsLabel.Text = $"Air: {MyHero_Battle.AirPoints}";
            DefensePointsLabel.Text = $"Defense points: {MyHero_Battle.DefencePoints + MyHero_Battle.TemporaryShieldPoints}";
            EnemyNumberLabel.Text = $"Enemy {enemyCounter + 1}/{enemies.Length}";
            EnemyLifePointsLabel.Text = $"Enemy life points: {enemies[enemyCounter].LifePoints}";
            EnemyManaPointsLabel.Text = $"Enemy Mana points: {enemies[enemyCounter].ManaPoints}/{enemies[enemyCounter].MaxManaPoints}";
            EnemyDefenseLabel.Text = $"Enemy Defense points: {enemies[enemyCounter].DefencePoints}";
        }

        private void BattleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enemyCounter < 1 + battleLevel && !gameOver)
            {
                string message = "Are you sure you want to exit? All collected loot will be lost.";
                string caption = "Exit confirmation";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    MyHero_Battle.WaterPoints = 0;
                    MyHero_Battle.EarthPoints = 0;
                    MyHero_Battle.FirePoints = 0;
                    MyHero_Battle.AirPoints = 0;
                    MyHero_Battle.TemporaryShieldPoints = 0;
                }
                e.Cancel = result == DialogResult.No;
            }
            else
            {
                MyHero_Battle.WaterPoints = 0;
                MyHero_Battle.EarthPoints = 0;
                MyHero_Battle.FirePoints = 0;
                MyHero_Battle.AirPoints = 0;
                MyHero_Battle.TemporaryShieldPoints = 0;
            }
        }
    }
}