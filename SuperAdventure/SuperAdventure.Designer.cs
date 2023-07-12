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
            label4.Location = new Point(18, 110);
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
            // SuperAdventure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 583);
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
    }
}