namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LblHitPoints = new Label();
            LblGold = new Label();
            LblExperience = new Label();
            LblLevel = new Label();
            label5 = new Label();
            CboWeapons = new ComboBox();
            CboPotions = new ComboBox();
            BtnUseWeapon = new Button();
            BtnUsePotion = new Button();
            BtnNorth = new Button();
            BtnEast = new Button();
            BtnSouth = new Button();
            BtnWest = new Button();
            RtbLocation = new RichTextBox();
            RtbMessages = new RichTextBox();
            DgvInventory = new DataGridView();
            DgvQuests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvQuests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hit Points: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 50);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Gold: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Experience: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 107);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Level: ";
            // 
            // LblHitPoints
            // 
            LblHitPoints.AutoSize = true;
            LblHitPoints.Location = new Point(112, 22);
            LblHitPoints.Name = "LblHitPoints";
            LblHitPoints.Size = new Size(0, 20);
            LblHitPoints.TabIndex = 4;
            // 
            // LblGold
            // 
            LblGold.AutoSize = true;
            LblGold.Location = new Point(110, 51);
            LblGold.Name = "LblGold";
            LblGold.Size = new Size(0, 20);
            LblGold.TabIndex = 5;
            // 
            // LblExperience
            // 
            LblExperience.AutoSize = true;
            LblExperience.Location = new Point(107, 80);
            LblExperience.Name = "LblExperience";
            LblExperience.Size = new Size(0, 20);
            LblExperience.TabIndex = 6;
            // 
            // LblLevel
            // 
            LblLevel.AutoSize = true;
            LblLevel.Location = new Point(73, 111);
            LblLevel.Name = "LblLevel";
            LblLevel.Size = new Size(0, 20);
            LblLevel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 531);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 8;
            label5.Text = "Select Action";
            // 
            // CboWeapons
            // 
            CboWeapons.FormattingEnabled = true;
            CboWeapons.Location = new Point(369, 559);
            CboWeapons.Name = "CboWeapons";
            CboWeapons.Size = new Size(151, 28);
            CboWeapons.TabIndex = 9;
            // 
            // CboPotions
            // 
            CboPotions.FormattingEnabled = true;
            CboPotions.Location = new Point(369, 593);
            CboPotions.Name = "CboPotions";
            CboPotions.Size = new Size(151, 28);
            CboPotions.TabIndex = 10;
            // 
            // BtnUseWeapon
            // 
            BtnUseWeapon.Location = new Point(620, 559);
            BtnUseWeapon.Name = "BtnUseWeapon";
            BtnUseWeapon.Size = new Size(94, 29);
            BtnUseWeapon.TabIndex = 11;
            BtnUseWeapon.Text = "Use";
            BtnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // BtnUsePotion
            // 
            BtnUsePotion.Location = new Point(620, 593);
            BtnUsePotion.Name = "BtnUsePotion";
            BtnUsePotion.Size = new Size(94, 29);
            BtnUsePotion.TabIndex = 12;
            BtnUsePotion.Text = "Use";
            BtnUsePotion.UseVisualStyleBackColor = true;
            // 
            // BtnNorth
            // 
            BtnNorth.Location = new Point(493, 433);
            BtnNorth.Name = "BtnNorth";
            BtnNorth.Size = new Size(94, 29);
            BtnNorth.TabIndex = 13;
            BtnNorth.Text = "North";
            BtnNorth.UseVisualStyleBackColor = true;
            BtnNorth.Click += BtnNorth_Click;
            // 
            // BtnEast
            // 
            BtnEast.Location = new Point(593, 457);
            BtnEast.Name = "BtnEast";
            BtnEast.Size = new Size(74, 29);
            BtnEast.TabIndex = 14;
            BtnEast.Text = "East";
            BtnEast.UseVisualStyleBackColor = true;
            // 
            // BtnSouth
            // 
            BtnSouth.Location = new Point(493, 487);
            BtnSouth.Name = "BtnSouth";
            BtnSouth.Size = new Size(94, 29);
            BtnSouth.TabIndex = 15;
            BtnSouth.Text = "South";
            BtnSouth.UseVisualStyleBackColor = true;
            // 
            // BtnWest
            // 
            BtnWest.Location = new Point(412, 457);
            BtnWest.Name = "BtnWest";
            BtnWest.Size = new Size(75, 29);
            BtnWest.TabIndex = 16;
            BtnWest.Text = "West";
            BtnWest.UseVisualStyleBackColor = true;
            // 
            // RtbLocation
            // 
            RtbLocation.Location = new Point(347, 19);
            RtbLocation.Name = "RtbLocation";
            RtbLocation.ReadOnly = true;
            RtbLocation.Size = new Size(360, 105);
            RtbLocation.TabIndex = 17;
            RtbLocation.Text = "";
            // 
            // RtbMessages
            // 
            RtbMessages.Location = new Point(347, 130);
            RtbMessages.Name = "RtbMessages";
            RtbMessages.ReadOnly = true;
            RtbMessages.Size = new Size(360, 286);
            RtbMessages.TabIndex = 18;
            RtbMessages.Text = "";
            // 
            // DgvInventory
            // 
            DgvInventory.AllowUserToAddRows = false;
            DgvInventory.AllowUserToDeleteRows = false;
            DgvInventory.AllowUserToResizeRows = false;
            DgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvInventory.Enabled = false;
            DgvInventory.Location = new Point(16, 130);
            DgvInventory.MultiSelect = false;
            DgvInventory.Name = "DgvInventory";
            DgvInventory.ReadOnly = true;
            DgvInventory.RowHeadersWidth = 51;
            DgvInventory.RowTemplate.Height = 29;
            DgvInventory.Size = new Size(312, 309);
            DgvInventory.TabIndex = 19;
            // 
            // DgvQuests
            // 
            DgvQuests.AllowUserToAddRows = false;
            DgvQuests.AllowUserToDeleteRows = false;
            DgvQuests.AllowUserToResizeRows = false;
            DgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvQuests.Enabled = false;
            DgvQuests.Location = new Point(16, 446);
            DgvQuests.MultiSelect = false;
            DgvQuests.Name = "DgvQuests";
            DgvQuests.ReadOnly = true;
            DgvQuests.RowHeadersWidth = 51;
            DgvQuests.RowTemplate.Height = 29;
            DgvQuests.Size = new Size(312, 189);
            DgvQuests.TabIndex = 20;
            // 
            // SuperAdventure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 643);
            Controls.Add(DgvQuests);
            Controls.Add(DgvInventory);
            Controls.Add(RtbMessages);
            Controls.Add(RtbLocation);
            Controls.Add(BtnWest);
            Controls.Add(BtnSouth);
            Controls.Add(BtnEast);
            Controls.Add(BtnNorth);
            Controls.Add(BtnUsePotion);
            Controls.Add(BtnUseWeapon);
            Controls.Add(CboPotions);
            Controls.Add(CboWeapons);
            Controls.Add(label5);
            Controls.Add(LblLevel);
            Controls.Add(LblExperience);
            Controls.Add(LblGold);
            Controls.Add(LblHitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuperAdventure";
            Text = "My Game";
            ((System.ComponentModel.ISupportInitialize)DgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvQuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LblHitPoints;
        private Label LblGold;
        private Label LblExperience;
        private Label LblLevel;
        private Label label5;
        private ComboBox CboWeapons;
        private ComboBox CboPotions;
        private Button BtnUseWeapon;
        private Button BtnUsePotion;
        private Button BtnNorth;
        private Button BtnEast;
        private Button BtnSouth;
        private Button BtnWest;
        private RichTextBox RtbLocation;
        private RichTextBox RtbMessages;
        private DataGridView DgvInventory;
        private DataGridView DgvQuests;
    }
}