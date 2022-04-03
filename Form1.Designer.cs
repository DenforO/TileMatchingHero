namespace WindowsFormsApp3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InventoryButton = new System.Windows.Forms.Button();
            this.ToShopButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LifePointsLabel = new System.Windows.Forms.Label();
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.ToBattleButton = new System.Windows.Forms.Button();
            this.StartOverButton = new System.Windows.Forms.Button();
            this.ToBattleButton2 = new System.Windows.Forms.Button();
            this.ToBattleButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtremeLevelButton = new System.Windows.Forms.Button();
            this.BossBattleButton = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(205, 301);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(75, 23);
            this.InventoryButton.TabIndex = 0;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // ToShopButton
            // 
            this.ToShopButton.Location = new System.Drawing.Point(61, 301);
            this.ToShopButton.Name = "ToShopButton";
            this.ToShopButton.Size = new System.Drawing.Size(75, 23);
            this.ToShopButton.TabIndex = 4;
            this.ToShopButton.Text = "Shop";
            this.ToShopButton.UseVisualStyleBackColor = true;
            this.ToShopButton.Click += new System.EventHandler(this.ToShopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Hero_icon_big_;
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LifePointsLabel
            // 
            this.LifePointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.LifePointsLabel.Image = global::WindowsFormsApp3.Properties.Resources.Orb_RedMagic_icon;
            this.LifePointsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LifePointsLabel.Location = new System.Drawing.Point(14, 173);
            this.LifePointsLabel.Name = "LifePointsLabel";
            this.LifePointsLabel.Size = new System.Drawing.Size(148, 23);
            this.LifePointsLabel.TabIndex = 2;
            this.LifePointsLabel.Text = "Life Points:";
            this.LifePointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CoinsLabel.Image = global::WindowsFormsApp3.Properties.Resources.Gold_icon;
            this.CoinsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CoinsLabel.Location = new System.Drawing.Point(17, 205);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(145, 19);
            this.CoinsLabel.TabIndex = 1;
            this.CoinsLabel.Text = "Coins:";
            this.CoinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToBattleButton
            // 
            this.ToBattleButton.Location = new System.Drawing.Point(506, 74);
            this.ToBattleButton.Name = "ToBattleButton";
            this.ToBattleButton.Size = new System.Drawing.Size(75, 23);
            this.ToBattleButton.TabIndex = 5;
            this.ToBattleButton.Text = "Easy";
            this.ToBattleButton.UseVisualStyleBackColor = true;
            this.ToBattleButton.Click += new System.EventHandler(this.ToBattleButton_Click);
            // 
            // StartOverButton
            // 
            this.StartOverButton.Location = new System.Drawing.Point(541, 301);
            this.StartOverButton.Name = "StartOverButton";
            this.StartOverButton.Size = new System.Drawing.Size(75, 23);
            this.StartOverButton.TabIndex = 6;
            this.StartOverButton.Text = "Start Over";
            this.StartOverButton.UseVisualStyleBackColor = true;
            this.StartOverButton.Click += new System.EventHandler(this.StartOverButton_Click);
            // 
            // ToBattleButton2
            // 
            this.ToBattleButton2.Location = new System.Drawing.Point(506, 104);
            this.ToBattleButton2.Name = "ToBattleButton2";
            this.ToBattleButton2.Size = new System.Drawing.Size(75, 23);
            this.ToBattleButton2.TabIndex = 7;
            this.ToBattleButton2.Text = "Medium";
            this.ToBattleButton2.UseVisualStyleBackColor = true;
            this.ToBattleButton2.Click += new System.EventHandler(this.ToBattleButton2_Click);
            // 
            // ToBattleButton3
            // 
            this.ToBattleButton3.Location = new System.Drawing.Point(506, 134);
            this.ToBattleButton3.Name = "ToBattleButton3";
            this.ToBattleButton3.Size = new System.Drawing.Size(75, 23);
            this.ToBattleButton3.TabIndex = 8;
            this.ToBattleButton3.Text = "Hard";
            this.ToBattleButton3.UseVisualStyleBackColor = true;
            this.ToBattleButton3.Click += new System.EventHandler(this.ToBattleButton3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(506, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "To Battle!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExtremeLevelButton
            // 
            this.ExtremeLevelButton.Location = new System.Drawing.Point(506, 164);
            this.ExtremeLevelButton.Name = "ExtremeLevelButton";
            this.ExtremeLevelButton.Size = new System.Drawing.Size(75, 23);
            this.ExtremeLevelButton.TabIndex = 10;
            this.ExtremeLevelButton.Text = "Extreme";
            this.ExtremeLevelButton.UseVisualStyleBackColor = true;
            this.ExtremeLevelButton.Click += new System.EventHandler(this.ExtremeLevelButton_Click);
            // 
            // BossBattleButton
            // 
            this.BossBattleButton.Location = new System.Drawing.Point(506, 225);
            this.BossBattleButton.Name = "BossBattleButton";
            this.BossBattleButton.Size = new System.Drawing.Size(75, 23);
            this.BossBattleButton.TabIndex = 11;
            this.BossBattleButton.Text = "Boss";
            this.BossBattleButton.UseVisualStyleBackColor = true;
            this.BossBattleButton.Click += new System.EventHandler(this.BossBattleButton_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 336);
            this.Controls.Add(this.BossBattleButton);
            this.Controls.Add(this.ExtremeLevelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToBattleButton3);
            this.Controls.Add(this.ToBattleButton2);
            this.Controls.Add(this.StartOverButton);
            this.Controls.Add(this.ToBattleButton);
            this.Controls.Add(this.ToShopButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LifePointsLabel);
            this.Controls.Add(this.CoinsLabel);
            this.Controls.Add(this.InventoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.Label LifePointsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ToShopButton;
        private System.Windows.Forms.Button ToBattleButton;
        private System.Windows.Forms.Button StartOverButton;
        private System.Windows.Forms.Button ToBattleButton2;
        private System.Windows.Forms.Button ToBattleButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExtremeLevelButton;
        private System.Windows.Forms.Button BossBattleButton;
        private System.Diagnostics.EventLog eventLog1;
    }
}

