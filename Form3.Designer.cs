namespace WindowsFormsApp3
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ShoppingList = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PirceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.upgradesLabel = new System.Windows.Forms.Label();
            this.MaxLifePointsUpgrade = new System.Windows.Forms.Button();
            this.AttackPowerButton = new System.Windows.Forms.Button();
            this.DefencePowerButton = new System.Windows.Forms.Button();
            this.MaxLifePointsUpgradeLabel = new System.Windows.Forms.Label();
            this.AttackPowerUpgradeLabel = new System.Windows.Forms.Label();
            this.DefencePowerUpgradeLabel = new System.Windows.Forms.Label();
            this.MaxLifePointsLabel = new System.Windows.Forms.Label();
            this.AttackPowerLabel = new System.Windows.Forms.Label();
            this.DefencePowerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.Image = global::WindowsFormsApp3.Properties.Resources.Gold_icon;
            this.CoinsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CoinsLabel.Location = new System.Drawing.Point(12, 52);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(145, 19);
            this.CoinsLabel.TabIndex = 2;
            this.CoinsLabel.Text = "Coins:";
            this.CoinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shop";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 301);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(126, 301);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 5;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ShoppingList
            // 
            this.ShoppingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.PirceHeader,
            this.TypeHeader,
            this.TipHeader});
            this.ShoppingList.FullRowSelect = true;
            this.ShoppingList.GridLines = true;
            this.ShoppingList.HideSelection = false;
            this.ShoppingList.LargeImageList = this.imageList2;
            this.ShoppingList.Location = new System.Drawing.Point(15, 133);
            this.ShoppingList.MultiSelect = false;
            this.ShoppingList.Name = "ShoppingList";
            this.ShoppingList.Size = new System.Drawing.Size(445, 162);
            this.ShoppingList.SmallImageList = this.imageList1;
            this.ShoppingList.TabIndex = 6;
            this.ShoppingList.UseCompatibleStateImageBehavior = false;
            this.ShoppingList.View = System.Windows.Forms.View.Details;
            this.ShoppingList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ShoppingList_ColumnClick);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 133;
            // 
            // PirceHeader
            // 
            this.PirceHeader.Text = "Price";
            this.PirceHeader.Width = 42;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Type";
            // 
            // TipHeader
            // 
            this.TipHeader.Text = "Tip";
            this.TipHeader.Width = 219;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Video-icon.png");
            this.imageList2.Images.SetKeyName(1, "sword-icon.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Gold-icon.png");
            this.imageList1.Images.SetKeyName(1, "Orb-RedMagic-icon.png");
            this.imageList1.Images.SetKeyName(2, "Shield-Security-icon.png");
            this.imageList1.Images.SetKeyName(3, "Storage-icon.png");
            this.imageList1.Images.SetKeyName(4, "SwordAxe-icon.png");
            this.imageList1.Images.SetKeyName(5, "sword-icon (2).png");
            this.imageList1.Images.SetKeyName(6, "Water-potion.png");
            this.imageList1.Images.SetKeyName(7, "Air-potion.png");
            this.imageList1.Images.SetKeyName(8, "Earth-potion.png");
            this.imageList1.Images.SetKeyName(9, "Ebook-icon.png");
            this.imageList1.Images.SetKeyName(10, "ele-earth-icon.png");
            this.imageList1.Images.SetKeyName(11, "ele-fire-icon.png");
            this.imageList1.Images.SetKeyName(12, "ele-water-icon.png");
            this.imageList1.Images.SetKeyName(13, "ele-wind-icon.png");
            this.imageList1.Images.SetKeyName(14, "Potion-2-icon.png");
            this.imageList1.Images.SetKeyName(15, "Potion-icon.png");
            this.imageList1.Images.SetKeyName(16, "Potion-icon2.png");
            this.imageList1.Images.SetKeyName(17, "Potion-icon3.png");
            this.imageList1.Images.SetKeyName(18, "Potion-icon4.png");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Potions",
            "Magic"});
            this.comboBox1.Location = new System.Drawing.Point(15, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // upgradesLabel
            // 
            this.upgradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.upgradesLabel.Location = new System.Drawing.Point(519, 106);
            this.upgradesLabel.Name = "upgradesLabel";
            this.upgradesLabel.Size = new System.Drawing.Size(73, 22);
            this.upgradesLabel.TabIndex = 9;
            this.upgradesLabel.Text = "Upgrades";
            // 
            // MaxLifePointsUpgrade
            // 
            this.MaxLifePointsUpgrade.Location = new System.Drawing.Point(466, 143);
            this.MaxLifePointsUpgrade.Name = "MaxLifePointsUpgrade";
            this.MaxLifePointsUpgrade.Size = new System.Drawing.Size(94, 23);
            this.MaxLifePointsUpgrade.TabIndex = 10;
            this.MaxLifePointsUpgrade.Text = "Max Life Points";
            this.MaxLifePointsUpgrade.UseVisualStyleBackColor = true;
            this.MaxLifePointsUpgrade.Click += new System.EventHandler(this.MaxLifePointsUpgrade_Click);
            // 
            // AttackPowerButton
            // 
            this.AttackPowerButton.Location = new System.Drawing.Point(466, 202);
            this.AttackPowerButton.Name = "AttackPowerButton";
            this.AttackPowerButton.Size = new System.Drawing.Size(94, 23);
            this.AttackPowerButton.TabIndex = 11;
            this.AttackPowerButton.Text = "Attack Power";
            this.AttackPowerButton.UseVisualStyleBackColor = true;
            this.AttackPowerButton.Click += new System.EventHandler(this.AttackPowerButton_Click);
            // 
            // DefencePowerButton
            // 
            this.DefencePowerButton.Location = new System.Drawing.Point(466, 253);
            this.DefencePowerButton.Name = "DefencePowerButton";
            this.DefencePowerButton.Size = new System.Drawing.Size(94, 23);
            this.DefencePowerButton.TabIndex = 12;
            this.DefencePowerButton.Text = "Defence Power";
            this.DefencePowerButton.UseVisualStyleBackColor = true;
            this.DefencePowerButton.Click += new System.EventHandler(this.DefencePowerButton_Click);
            // 
            // MaxLifePointsUpgradeLabel
            // 
            this.MaxLifePointsUpgradeLabel.AutoSize = true;
            this.MaxLifePointsUpgradeLabel.Location = new System.Drawing.Point(566, 148);
            this.MaxLifePointsUpgradeLabel.Name = "MaxLifePointsUpgradeLabel";
            this.MaxLifePointsUpgradeLabel.Size = new System.Drawing.Size(47, 13);
            this.MaxLifePointsUpgradeLabel.TabIndex = 13;
            this.MaxLifePointsUpgradeLabel.Text = "10 coins";
            // 
            // AttackPowerUpgradeLabel
            // 
            this.AttackPowerUpgradeLabel.AutoSize = true;
            this.AttackPowerUpgradeLabel.Location = new System.Drawing.Point(566, 207);
            this.AttackPowerUpgradeLabel.Name = "AttackPowerUpgradeLabel";
            this.AttackPowerUpgradeLabel.Size = new System.Drawing.Size(47, 13);
            this.AttackPowerUpgradeLabel.TabIndex = 14;
            this.AttackPowerUpgradeLabel.Text = "15 coins";
            // 
            // DefencePowerUpgradeLabel
            // 
            this.DefencePowerUpgradeLabel.AutoSize = true;
            this.DefencePowerUpgradeLabel.Location = new System.Drawing.Point(566, 258);
            this.DefencePowerUpgradeLabel.Name = "DefencePowerUpgradeLabel";
            this.DefencePowerUpgradeLabel.Size = new System.Drawing.Size(47, 13);
            this.DefencePowerUpgradeLabel.TabIndex = 15;
            this.DefencePowerUpgradeLabel.Text = "10 coins";
            // 
            // MaxLifePointsLabel
            // 
            this.MaxLifePointsLabel.AutoSize = true;
            this.MaxLifePointsLabel.Location = new System.Drawing.Point(467, 168);
            this.MaxLifePointsLabel.Name = "MaxLifePointsLabel";
            this.MaxLifePointsLabel.Size = new System.Drawing.Size(35, 13);
            this.MaxLifePointsLabel.TabIndex = 16;
            this.MaxLifePointsLabel.Text = "label2";
            // 
            // AttackPowerLabel
            // 
            this.AttackPowerLabel.AutoSize = true;
            this.AttackPowerLabel.Location = new System.Drawing.Point(470, 225);
            this.AttackPowerLabel.Name = "AttackPowerLabel";
            this.AttackPowerLabel.Size = new System.Drawing.Size(35, 13);
            this.AttackPowerLabel.TabIndex = 17;
            this.AttackPowerLabel.Text = "label3";
            // 
            // DefencePowerLabel
            // 
            this.DefencePowerLabel.AutoSize = true;
            this.DefencePowerLabel.Location = new System.Drawing.Point(470, 279);
            this.DefencePowerLabel.Name = "DefencePowerLabel";
            this.DefencePowerLabel.Size = new System.Drawing.Size(35, 13);
            this.DefencePowerLabel.TabIndex = 18;
            this.DefencePowerLabel.Text = "label4";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 336);
            this.Controls.Add(this.DefencePowerLabel);
            this.Controls.Add(this.AttackPowerLabel);
            this.Controls.Add(this.MaxLifePointsLabel);
            this.Controls.Add(this.DefencePowerUpgradeLabel);
            this.Controls.Add(this.AttackPowerUpgradeLabel);
            this.Controls.Add(this.MaxLifePointsUpgradeLabel);
            this.Controls.Add(this.DefencePowerButton);
            this.Controls.Add(this.AttackPowerButton);
            this.Controls.Add(this.MaxLifePointsUpgrade);
            this.Controls.Add(this.upgradesLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ShoppingList);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoinsLabel);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView ShoppingList;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader PirceHeader;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader TypeHeader;
        private System.Windows.Forms.Label upgradesLabel;
        private System.Windows.Forms.Button MaxLifePointsUpgrade;
        private System.Windows.Forms.Button AttackPowerButton;
        private System.Windows.Forms.Button DefencePowerButton;
        private System.Windows.Forms.Label MaxLifePointsUpgradeLabel;
        private System.Windows.Forms.Label AttackPowerUpgradeLabel;
        private System.Windows.Forms.Label DefencePowerUpgradeLabel;
        private System.Windows.Forms.Label MaxLifePointsLabel;
        private System.Windows.Forms.Label AttackPowerLabel;
        private System.Windows.Forms.Label DefencePowerLabel;
        private System.Windows.Forms.ColumnHeader TipHeader;
    }
}