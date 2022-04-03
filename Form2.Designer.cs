namespace WindowsFormsApp3
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.backButton = new System.Windows.Forms.Button();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TupeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UseButton = new System.Windows.Forms.Button();
            this.listViewEquipped = new System.Windows.Forms.ListView();
            this.MagicNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PowerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipButton = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 301);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // listViewInventory
            // 
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.TupeHeader,
            this.TipHeader});
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.HideSelection = false;
            this.listViewInventory.Location = new System.Drawing.Point(13, 47);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(422, 248);
            this.listViewInventory.SmallImageList = this.imageList1;
            this.listViewInventory.TabIndex = 1;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            this.listViewInventory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ShoppingList_ColumnClick);
            this.listViewInventory.SelectedIndexChanged += new System.EventHandler(this.listViewInventory_SelectedIndexChanged);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 115;
            // 
            // TupeHeader
            // 
            this.TupeHeader.Text = "Type";
            // 
            // TipHeader
            // 
            this.TipHeader.Text = "Tip";
            this.TipHeader.Width = 243;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Air-potion.png");
            this.imageList1.Images.SetKeyName(1, "Earth-potion.png");
            this.imageList1.Images.SetKeyName(2, "Ebook-icon.png");
            this.imageList1.Images.SetKeyName(3, "ele-earth-icon.png");
            this.imageList1.Images.SetKeyName(4, "ele-fire-icon.png");
            this.imageList1.Images.SetKeyName(5, "ele-water-icon.png");
            this.imageList1.Images.SetKeyName(6, "ele-wind-icon.png");
            this.imageList1.Images.SetKeyName(7, "Gold-icon.png");
            this.imageList1.Images.SetKeyName(8, "Orb-RedMagic-icon.png");
            this.imageList1.Images.SetKeyName(9, "Potion-2-icon.png");
            this.imageList1.Images.SetKeyName(10, "Potion-icon.png");
            this.imageList1.Images.SetKeyName(11, "Potion-icon2.png");
            this.imageList1.Images.SetKeyName(12, "Potion-icon3.png");
            this.imageList1.Images.SetKeyName(13, "Potion-icon4.png");
            this.imageList1.Images.SetKeyName(14, "Shield-Security-icon.png");
            this.imageList1.Images.SetKeyName(15, "sword-icon (2).png");
            this.imageList1.Images.SetKeyName(16, "Water-potion.png");
            // 
            // UseButton
            // 
            this.UseButton.Enabled = false;
            this.UseButton.Location = new System.Drawing.Point(360, 301);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(75, 23);
            this.UseButton.TabIndex = 2;
            this.UseButton.Text = "Use";
            this.UseButton.UseVisualStyleBackColor = true;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // listViewEquipped
            // 
            this.listViewEquipped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MagicNameHeader,
            this.PowerHeader});
            this.listViewEquipped.FullRowSelect = true;
            this.listViewEquipped.HideSelection = false;
            this.listViewEquipped.Location = new System.Drawing.Point(441, 47);
            this.listViewEquipped.Name = "listViewEquipped";
            this.listViewEquipped.Size = new System.Drawing.Size(284, 248);
            this.listViewEquipped.SmallImageList = this.imageList1;
            this.listViewEquipped.TabIndex = 3;
            this.listViewEquipped.UseCompatibleStateImageBehavior = false;
            this.listViewEquipped.View = System.Windows.Forms.View.Details;
            // 
            // MagicNameHeader
            // 
            this.MagicNameHeader.Text = "Name";
            this.MagicNameHeader.Width = 230;
            // 
            // PowerHeader
            // 
            this.PowerHeader.Text = "Power";
            this.PowerHeader.Width = 50;
            // 
            // EquipButton
            // 
            this.EquipButton.Enabled = false;
            this.EquipButton.Location = new System.Drawing.Point(279, 301);
            this.EquipButton.Name = "EquipButton";
            this.EquipButton.Size = new System.Drawing.Size(75, 23);
            this.EquipButton.TabIndex = 4;
            this.EquipButton.Text = "Equip";
            this.EquipButton.UseVisualStyleBackColor = true;
            this.EquipButton.Click += new System.EventHandler(this.EquipButton_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "All",
            "Potions",
            "Magic"});
            this.comboBoxItems.Location = new System.Drawing.Point(13, 20);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(390, 21);
            this.comboBoxItems.TabIndex = 5;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(535, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipped Spells";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.EquipButton);
            this.Controls.Add(this.listViewEquipped);
            this.Controls.Add(this.UseButton);
            this.Controls.Add(this.listViewInventory);
            this.Controls.Add(this.backButton);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader TupeHeader;
        private System.Windows.Forms.ColumnHeader TipHeader;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewEquipped;
        private System.Windows.Forms.ColumnHeader MagicNameHeader;
        private System.Windows.Forms.ColumnHeader PowerHeader;
        private System.Windows.Forms.Button EquipButton;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label1;
    }
}