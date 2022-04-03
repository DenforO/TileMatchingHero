namespace WindowsFormsApp3
{
    partial class BattleForm
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
            this.WaterPointsLabel = new System.Windows.Forms.Label();
            this.EnemyLifePointsLabel = new System.Windows.Forms.Label();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.LastActionLabel = new System.Windows.Forms.Label();
            this.EnemyNumberLabel = new System.Windows.Forms.Label();
            this.ActionButtonsGroup = new System.Windows.Forms.GroupBox();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.AirButton = new System.Windows.Forms.Button();
            this.FireButton = new System.Windows.Forms.Button();
            this.EarthButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.AttackButton = new System.Windows.Forms.Button();
            this.EnemyManaPointsLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.AirPointsLabel = new System.Windows.Forms.Label();
            this.EarthPointsLabel = new System.Windows.Forms.Label();
            this.FirePointsLabel = new System.Windows.Forms.Label();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.LifePointsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnemyDefenseLabel = new System.Windows.Forms.Label();
            this.DefensePointsLabel = new System.Windows.Forms.Label();
            this.ActionButtonsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WaterPointsLabel
            // 
            this.WaterPointsLabel.AllowDrop = true;
            this.WaterPointsLabel.Location = new System.Drawing.Point(12, 265);
            this.WaterPointsLabel.Name = "WaterPointsLabel";
            this.WaterPointsLabel.Size = new System.Drawing.Size(88, 20);
            this.WaterPointsLabel.TabIndex = 6;
            this.WaterPointsLabel.Text = "Water:";
            this.WaterPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WaterPointsLabel.UseMnemonic = false;
            // 
            // EnemyLifePointsLabel
            // 
            this.EnemyLifePointsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnemyLifePointsLabel.Location = new System.Drawing.Point(648, 227);
            this.EnemyLifePointsLabel.Name = "EnemyLifePointsLabel";
            this.EnemyLifePointsLabel.Size = new System.Drawing.Size(148, 23);
            this.EnemyLifePointsLabel.TabIndex = 7;
            this.EnemyLifePointsLabel.Text = "Enemy Life Points:";
            this.EnemyLifePointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Location = new System.Drawing.Point(781, 326);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(75, 23);
            this.EndTurnButton.TabIndex = 8;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // LastActionLabel
            // 
            this.LastActionLabel.AllowDrop = true;
            this.LastActionLabel.Location = new System.Drawing.Point(12, 31);
            this.LastActionLabel.Name = "LastActionLabel";
            this.LastActionLabel.Size = new System.Drawing.Size(844, 20);
            this.LastActionLabel.TabIndex = 10;
            this.LastActionLabel.Text = "Last action";
            this.LastActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LastActionLabel.UseMnemonic = false;
            // 
            // EnemyNumberLabel
            // 
            this.EnemyNumberLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnemyNumberLabel.Location = new System.Drawing.Point(648, 8);
            this.EnemyNumberLabel.Name = "EnemyNumberLabel";
            this.EnemyNumberLabel.Size = new System.Drawing.Size(148, 23);
            this.EnemyNumberLabel.TabIndex = 11;
            this.EnemyNumberLabel.Text = "Enemy Number";
            this.EnemyNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActionButtonsGroup
            // 
            this.ActionButtonsGroup.Controls.Add(this.InventoryButton);
            this.ActionButtonsGroup.Controls.Add(this.AirButton);
            this.ActionButtonsGroup.Controls.Add(this.FireButton);
            this.ActionButtonsGroup.Controls.Add(this.EarthButton);
            this.ActionButtonsGroup.Controls.Add(this.WaterButton);
            this.ActionButtonsGroup.Controls.Add(this.AttackButton);
            this.ActionButtonsGroup.Location = new System.Drawing.Point(3, 314);
            this.ActionButtonsGroup.Name = "ActionButtonsGroup";
            this.ActionButtonsGroup.Size = new System.Drawing.Size(243, 93);
            this.ActionButtonsGroup.TabIndex = 13;
            this.ActionButtonsGroup.TabStop = false;
            // 
            // InventoryButton
            // 
            this.InventoryButton.Image = global::WindowsFormsApp3.Properties.Resources.Storage_icon__1_;
            this.InventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryButton.Location = new System.Drawing.Point(128, 12);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(109, 23);
            this.InventoryButton.TabIndex = 16;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // AirButton
            // 
            this.AirButton.Image = global::WindowsFormsApp3.Properties.Resources.ele_wind_icon__1_;
            this.AirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AirButton.Location = new System.Drawing.Point(128, 70);
            this.AirButton.Name = "AirButton";
            this.AirButton.Size = new System.Drawing.Size(109, 23);
            this.AirButton.TabIndex = 15;
            this.AirButton.Text = "Air";
            this.AirButton.UseVisualStyleBackColor = true;
            this.AirButton.Click += new System.EventHandler(this.AirButton_Click);
            // 
            // FireButton
            // 
            this.FireButton.Image = global::WindowsFormsApp3.Properties.Resources.ele_fire_icon__2_;
            this.FireButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FireButton.Location = new System.Drawing.Point(6, 70);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(116, 23);
            this.FireButton.TabIndex = 14;
            this.FireButton.Text = "Fire";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // EarthButton
            // 
            this.EarthButton.Image = global::WindowsFormsApp3.Properties.Resources.ele_earth_icon__1_;
            this.EarthButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EarthButton.Location = new System.Drawing.Point(128, 41);
            this.EarthButton.Name = "EarthButton";
            this.EarthButton.Size = new System.Drawing.Size(109, 23);
            this.EarthButton.TabIndex = 13;
            this.EarthButton.Text = "Earth";
            this.EarthButton.UseVisualStyleBackColor = true;
            this.EarthButton.Click += new System.EventHandler(this.EarthButton_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Image = global::WindowsFormsApp3.Properties.Resources.ele_water_icon__1_;
            this.WaterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WaterButton.Location = new System.Drawing.Point(6, 41);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(116, 23);
            this.WaterButton.TabIndex = 12;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.Image = global::WindowsFormsApp3.Properties.Resources.sword_icon__1_;
            this.AttackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttackButton.Location = new System.Drawing.Point(6, 12);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(116, 23);
            this.AttackButton.TabIndex = 9;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // EnemyManaPointsLabel
            // 
            this.EnemyManaPointsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnemyManaPointsLabel.Location = new System.Drawing.Point(624, 262);
            this.EnemyManaPointsLabel.Name = "EnemyManaPointsLabel";
            this.EnemyManaPointsLabel.Size = new System.Drawing.Size(202, 23);
            this.EnemyManaPointsLabel.TabIndex = 14;
            this.EnemyManaPointsLabel.Text = "Enemy Mana Points:";
            this.EnemyManaPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // AirPointsLabel
            // 
            this.AirPointsLabel.AllowDrop = true;
            this.AirPointsLabel.Location = new System.Drawing.Point(113, 285);
            this.AirPointsLabel.Name = "AirPointsLabel";
            this.AirPointsLabel.Size = new System.Drawing.Size(88, 20);
            this.AirPointsLabel.TabIndex = 15;
            this.AirPointsLabel.Text = "Air:";
            this.AirPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirPointsLabel.UseMnemonic = false;
            // 
            // EarthPointsLabel
            // 
            this.EarthPointsLabel.AllowDrop = true;
            this.EarthPointsLabel.Location = new System.Drawing.Point(113, 265);
            this.EarthPointsLabel.Name = "EarthPointsLabel";
            this.EarthPointsLabel.Size = new System.Drawing.Size(88, 20);
            this.EarthPointsLabel.TabIndex = 16;
            this.EarthPointsLabel.Text = "Earth:";
            this.EarthPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EarthPointsLabel.UseMnemonic = false;
            // 
            // FirePointsLabel
            // 
            this.FirePointsLabel.AllowDrop = true;
            this.FirePointsLabel.Location = new System.Drawing.Point(12, 285);
            this.FirePointsLabel.Name = "FirePointsLabel";
            this.FirePointsLabel.Size = new System.Drawing.Size(88, 20);
            this.FirePointsLabel.TabIndex = 17;
            this.FirePointsLabel.Text = "Fire:";
            this.FirePointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirePointsLabel.UseMnemonic = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Image = global::WindowsFormsApp3.Properties.Resources.Witch;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(651, 90);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(165, 134);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEnemy.TabIndex = 18;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // LifePointsLabel
            // 
            this.LifePointsLabel.Image = global::WindowsFormsApp3.Properties.Resources.Orb_RedMagic_icon;
            this.LifePointsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LifePointsLabel.Location = new System.Drawing.Point(17, 219);
            this.LifePointsLabel.Name = "LifePointsLabel";
            this.LifePointsLabel.Size = new System.Drawing.Size(148, 23);
            this.LifePointsLabel.TabIndex = 5;
            this.LifePointsLabel.Text = "Life Points:";
            this.LifePointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Hero_icon_big_;
            this.pictureBox1.Location = new System.Drawing.Point(59, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 134);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EnemyDefenseLabel
            // 
            this.EnemyDefenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnemyDefenseLabel.Location = new System.Drawing.Point(648, 300);
            this.EnemyDefenseLabel.Name = "EnemyDefenseLabel";
            this.EnemyDefenseLabel.Size = new System.Drawing.Size(148, 23);
            this.EnemyDefenseLabel.TabIndex = 19;
            this.EnemyDefenseLabel.Text = "Enemy Defense Points:";
            this.EnemyDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefensePointsLabel
            // 
            this.DefensePointsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DefensePointsLabel.Location = new System.Drawing.Point(17, 242);
            this.DefensePointsLabel.Name = "DefensePointsLabel";
            this.DefensePointsLabel.Size = new System.Drawing.Size(148, 23);
            this.DefensePointsLabel.TabIndex = 20;
            this.DefensePointsLabel.Text = "Defense Points:";
            this.DefensePointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(868, 419);
            this.Controls.Add(this.DefensePointsLabel);
            this.Controls.Add(this.EnemyDefenseLabel);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.FirePointsLabel);
            this.Controls.Add(this.EarthPointsLabel);
            this.Controls.Add(this.AirPointsLabel);
            this.Controls.Add(this.EnemyManaPointsLabel);
            this.Controls.Add(this.ActionButtonsGroup);
            this.Controls.Add(this.EnemyNumberLabel);
            this.Controls.Add(this.LastActionLabel);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.EnemyLifePointsLabel);
            this.Controls.Add(this.WaterPointsLabel);
            this.Controls.Add(this.LifePointsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BattleForm";
            this.Text = "Battle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BattleForm_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ActionButtonsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LifePointsLabel;
        private System.Windows.Forms.Label WaterPointsLabel;
        private System.Windows.Forms.Label EnemyLifePointsLabel;
        private System.Windows.Forms.Button EndTurnButton;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Label LastActionLabel;
        private System.Windows.Forms.Label EnemyNumberLabel;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.GroupBox ActionButtonsGroup;
        private System.Windows.Forms.Label EnemyManaPointsLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label AirPointsLabel;
        private System.Windows.Forms.Label EarthPointsLabel;
        private System.Windows.Forms.Label FirePointsLabel;
        private System.Windows.Forms.Button AirButton;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button EarthButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Label EnemyDefenseLabel;
        private System.Windows.Forms.Label DefensePointsLabel;
    }
}