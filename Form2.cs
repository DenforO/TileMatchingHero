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
    public partial class InventoryForm : Form
    {
        public Hero MyHero_Inventory = new Hero();
        public bool duringBattle;

        private bool _inverse;
        private int _lastClickedColumn;
        string show1;
        string show2;

        public InventoryForm()
        {
            InitializeComponent();
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            show1 = duringBattle ? "" : "Magic";
            show2 = duringBattle ? "Potion" : "";
            comboBoxItems.SelectedItem = duringBattle ? "Potions" : "Magic";

            ItemsOrder(1);

            EquippedMagicRefresh();
        }
        private void ShoppingList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 2) return; //Tip Column
            if (e.Column == _lastClickedColumn && !_inverse)
                _inverse = true;
            else
                _inverse = false;
            ItemsOrder(e.Column);
            _lastClickedColumn = e.Column;
        }

        private void comboBoxItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem.Equals("All"))
            {
                show1 = "Potion";
                show2 = "Magic";
            }
            if (comboBoxItems.SelectedItem.Equals("Potions"))
            {
                show1 = "Potion";
                show2 = "";
            }
            if (comboBoxItems.SelectedItem.Equals("Magic"))
            {
                show1 = "";
                show2 = "Magic";
            }

            ItemsOrder(0);
        }

        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipButton.Enabled = false;
            UseButton.Enabled = false;

            if (listViewInventory.SelectedItems.Count > 0)
            {
                if (listViewInventory.SelectedItems[0].SubItems[1].Text == "Magic" && !duringBattle)
                    EquipButton.Enabled = true;

                if (listViewInventory.SelectedItems[0].SubItems[1].Text == "Potion" && duringBattle && !MyHero_Inventory.HasUsedPotionThisTurn)
                    UseButton.Enabled = true;
            }
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedItems != null &&
                listViewInventory.SelectedItems[0].SubItems[1].Text == "Potion" &&
                duringBattle)
            {
                Potion p = (Potion)MyHero_Inventory.ItemsOwned
                    .Where(x => x.Id == listViewInventory.SelectedItems[0].SubItems[3].Text)
                    .Where(x => x.GetType().Equals(typeof(Potion)))
                    .First();
                p.Use(MyHero_Inventory);
                MyHero_Inventory.ItemsOwned.Remove(p);
                listViewInventory.Items.Remove(listViewInventory.SelectedItems[0]);
                MyHero_Inventory.HasUsedPotionThisTurn = true;
            }
        }
        private void EquipButton_Click(object sender, EventArgs e)
        {
            switch(listViewInventory.SelectedItems[0].SubItems[4].Text)
            {
                case "Earth":
                    MyHero_Inventory.EquippedMagic[1] = (Magic)MyHero_Inventory.ItemsOwned
                        .Where(x => x.Id == listViewInventory.SelectedItems[0].SubItems[3].Text)
                        .Single();
                    break;

                case "Fire":
                    MyHero_Inventory.EquippedMagic[2] = (Magic)MyHero_Inventory.ItemsOwned
                        .Where(x => x.Id == listViewInventory.SelectedItems[0].SubItems[3].Text)
                        .Single();
                    break;

                case "Air":
                    MyHero_Inventory.EquippedMagic[3] = (Magic)MyHero_Inventory.ItemsOwned
                        .Where(x => x.Id == listViewInventory.SelectedItems[0].SubItems[3].Text)
                        .Single();
                    break;

                case "Water":
                    MyHero_Inventory.EquippedMagic[0] = (Magic)MyHero_Inventory.ItemsOwned
                        .Where(x => x.Id == listViewInventory.SelectedItems[0].SubItems[3].Text)
                        .Single();
                    break;

            }

            EquippedMagicRefresh();
        }
        private void EquippedMagicRefresh()
        {
            listViewEquipped.Items.Clear();
            foreach (var item in MyHero_Inventory.EquippedMagic)
            {
                ListViewItem lv1 = new ListViewItem($"{item.Name}");
                lv1.SubItems.Add($"{item.Power}");
                lv1.SubItems.Add($"{item.Id}");
                lv1.ImageKey = item.IconPath;

                listViewEquipped.Items.Add(lv1);
            }
        }

        private void ItemsOrder(int order)
        {
            var itemsFiltered = MyHero_Inventory.ItemsOwned
                .Where(x => x.GetType().Name == show1 || x.GetType().Name == show2);

            switch (order)
            {
                case 0:
                    itemsFiltered = !_inverse ?
                        itemsFiltered
                        .OrderBy(x => x.Name)
                        .ToList() 
                        :
                        itemsFiltered
                        .OrderByDescending(x => x.Name)
                        .ToList();
                    break;

                case 1:
                    itemsFiltered = !_inverse  ?
                        itemsFiltered
                        .OrderBy(x => x.GetType().Name)
                        .ThenBy(x => x.Name)
                        .ToList()
                        :
                        itemsFiltered
                        .OrderByDescending(x => x.GetType().Name)
                        .ThenBy(x => x.Name)
                        .ToList();

                    break;
            }
            listViewInventory.Items.Clear();

            foreach (var item in itemsFiltered)
            {
                ListViewItem lv1 = new ListViewItem($"{item.Name}");
                lv1.SubItems.Add($"{item.GetType().Name}");
                lv1.SubItems.Add($"{item.Tip}");
                lv1.SubItems.Add($"{item.Id}");
                lv1.SubItems.Add($"{item.Element}");
                lv1.ImageKey = item.IconPath;

                listViewInventory.Items.Add(lv1);
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}