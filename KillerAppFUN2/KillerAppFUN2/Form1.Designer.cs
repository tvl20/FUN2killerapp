namespace KillerAppFUN2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_AddNewPlayer = new System.Windows.Forms.Button();
            this.tb_PlayerName = new System.Windows.Forms.TextBox();
            this.nm_Lvl = new System.Windows.Forms.NumericUpDown();
            this.lb_Players = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_Defence = new System.Windows.Forms.NumericUpDown();
            this.lb_WeaponName = new System.Windows.Forms.Label();
            this.tb_WeaponName = new System.Windows.Forms.TextBox();
            this.lb_WeaponDMG = new System.Windows.Forms.Label();
            this.nm_WeaponDMG = new System.Windows.Forms.NumericUpDown();
            this.nm_WeaponCrit = new System.Windows.Forms.NumericUpDown();
            this.lb_WeaponCRT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nm_HP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nm_MaxHP = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Defence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_WeaponDMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_WeaponCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_MaxHP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select player:";
            // 
            // bt_AddNewPlayer
            // 
            this.bt_AddNewPlayer.Location = new System.Drawing.Point(12, 370);
            this.bt_AddNewPlayer.Name = "bt_AddNewPlayer";
            this.bt_AddNewPlayer.Size = new System.Drawing.Size(139, 48);
            this.bt_AddNewPlayer.TabIndex = 1;
            this.bt_AddNewPlayer.Text = "New player";
            this.bt_AddNewPlayer.UseVisualStyleBackColor = true;
            this.bt_AddNewPlayer.Click += new System.EventHandler(this.bt_AddNewPlayer_Click);
            // 
            // tb_PlayerName
            // 
            this.tb_PlayerName.Location = new System.Drawing.Point(178, 132);
            this.tb_PlayerName.Name = "tb_PlayerName";
            this.tb_PlayerName.ReadOnly = true;
            this.tb_PlayerName.Size = new System.Drawing.Size(113, 22);
            this.tb_PlayerName.TabIndex = 2;
            // 
            // nm_Lvl
            // 
            this.nm_Lvl.Location = new System.Drawing.Point(178, 216);
            this.nm_Lvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_Lvl.Name = "nm_Lvl";
            this.nm_Lvl.ReadOnly = true;
            this.nm_Lvl.Size = new System.Drawing.Size(113, 22);
            this.nm_Lvl.TabIndex = 3;
            this.nm_Lvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_Players
            // 
            this.lb_Players.FormattingEnabled = true;
            this.lb_Players.ItemHeight = 16;
            this.lb_Players.Location = new System.Drawing.Point(12, 31);
            this.lb_Players.Name = "lb_Players";
            this.lb_Players.Size = new System.Drawing.Size(279, 84);
            this.lb_Players.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Defence:";
            // 
            // nm_Defence
            // 
            this.nm_Defence.Location = new System.Drawing.Point(178, 244);
            this.nm_Defence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_Defence.Name = "nm_Defence";
            this.nm_Defence.ReadOnly = true;
            this.nm_Defence.Size = new System.Drawing.Size(113, 22);
            this.nm_Defence.TabIndex = 7;
            this.nm_Defence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_WeaponName
            // 
            this.lb_WeaponName.AutoSize = true;
            this.lb_WeaponName.Location = new System.Drawing.Point(9, 275);
            this.lb_WeaponName.Name = "lb_WeaponName";
            this.lb_WeaponName.Size = new System.Drawing.Size(106, 17);
            this.lb_WeaponName.TabIndex = 9;
            this.lb_WeaponName.Text = "Weapon Name:";
            // 
            // tb_WeaponName
            // 
            this.tb_WeaponName.Location = new System.Drawing.Point(178, 272);
            this.tb_WeaponName.Name = "tb_WeaponName";
            this.tb_WeaponName.ReadOnly = true;
            this.tb_WeaponName.Size = new System.Drawing.Size(113, 22);
            this.tb_WeaponName.TabIndex = 10;
            // 
            // lb_WeaponDMG
            // 
            this.lb_WeaponDMG.AutoSize = true;
            this.lb_WeaponDMG.Location = new System.Drawing.Point(9, 303);
            this.lb_WeaponDMG.Name = "lb_WeaponDMG";
            this.lb_WeaponDMG.Size = new System.Drawing.Size(122, 17);
            this.lb_WeaponDMG.TabIndex = 11;
            this.lb_WeaponDMG.Text = "Weapon Damage:";
            // 
            // nm_WeaponDMG
            // 
            this.nm_WeaponDMG.Location = new System.Drawing.Point(178, 301);
            this.nm_WeaponDMG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_WeaponDMG.Name = "nm_WeaponDMG";
            this.nm_WeaponDMG.ReadOnly = true;
            this.nm_WeaponDMG.Size = new System.Drawing.Size(113, 22);
            this.nm_WeaponDMG.TabIndex = 12;
            this.nm_WeaponDMG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nm_WeaponCrit
            // 
            this.nm_WeaponCrit.Location = new System.Drawing.Point(178, 329);
            this.nm_WeaponCrit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_WeaponCrit.Name = "nm_WeaponCrit";
            this.nm_WeaponCrit.ReadOnly = true;
            this.nm_WeaponCrit.Size = new System.Drawing.Size(113, 22);
            this.nm_WeaponCrit.TabIndex = 14;
            this.nm_WeaponCrit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_WeaponCRT
            // 
            this.lb_WeaponCRT.AutoSize = true;
            this.lb_WeaponCRT.Location = new System.Drawing.Point(9, 331);
            this.lb_WeaponCRT.Name = "lb_WeaponCRT";
            this.lb_WeaponCRT.Size = new System.Drawing.Size(142, 17);
            this.lb_WeaponCRT.TabIndex = 13;
            this.lb_WeaponCRT.Text = "Weapon Crit Chance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "HP:";
            // 
            // nm_HP
            // 
            this.nm_HP.Location = new System.Drawing.Point(178, 160);
            this.nm_HP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_HP.Name = "nm_HP";
            this.nm_HP.ReadOnly = true;
            this.nm_HP.Size = new System.Drawing.Size(113, 22);
            this.nm_HP.TabIndex = 15;
            this.nm_HP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Max HP:";
            // 
            // nm_MaxHP
            // 
            this.nm_MaxHP.Location = new System.Drawing.Point(178, 188);
            this.nm_MaxHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_MaxHP.Name = "nm_MaxHP";
            this.nm_MaxHP.ReadOnly = true;
            this.nm_MaxHP.Size = new System.Drawing.Size(113, 22);
            this.nm_MaxHP.TabIndex = 17;
            this.nm_MaxHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Edit selected player";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nm_MaxHP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nm_HP);
            this.Controls.Add(this.nm_WeaponCrit);
            this.Controls.Add(this.lb_WeaponCRT);
            this.Controls.Add(this.nm_WeaponDMG);
            this.Controls.Add(this.lb_WeaponDMG);
            this.Controls.Add(this.tb_WeaponName);
            this.Controls.Add(this.lb_WeaponName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nm_Defence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Players);
            this.Controls.Add(this.nm_Lvl);
            this.Controls.Add(this.tb_PlayerName);
            this.Controls.Add(this.bt_AddNewPlayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nm_Lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Defence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_WeaponDMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_WeaponCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_MaxHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_AddNewPlayer;
        private System.Windows.Forms.TextBox tb_PlayerName;
        private System.Windows.Forms.NumericUpDown nm_Lvl;
        private System.Windows.Forms.ListBox lb_Players;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_Defence;
        private System.Windows.Forms.Label lb_WeaponName;
        private System.Windows.Forms.TextBox tb_WeaponName;
        private System.Windows.Forms.Label lb_WeaponDMG;
        private System.Windows.Forms.NumericUpDown nm_WeaponDMG;
        private System.Windows.Forms.NumericUpDown nm_WeaponCrit;
        private System.Windows.Forms.Label lb_WeaponCRT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nm_HP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nm_MaxHP;
        private System.Windows.Forms.Button button1;
    }
}

