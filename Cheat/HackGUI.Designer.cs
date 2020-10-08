namespace Cheat {
    partial class HackGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HackGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SetDead = new System.Windows.Forms.RadioButton();
            this.SetAlive = new System.Windows.Forms.RadioButton();
            this.SetImposter = new System.Windows.Forms.RadioButton();
            this.playerStatusLabel = new System.Windows.Forms.Label();
            this.SetCrewmate = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SetVisionNormal = new System.Windows.Forms.RadioButton();
            this.visionLabel = new System.Windows.Forms.Label();
            this.SetVisionFull = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.SetImposter);
            this.groupBox1.Controls.Add(this.playerStatusLabel);
            this.groupBox1.Controls.Add(this.SetCrewmate);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.SetDead);
            this.panel1.Controls.Add(this.SetAlive);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 82);
            this.panel1.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(7, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status";
            // 
            // SetDead
            // 
            this.SetDead.AutoSize = true;
            this.SetDead.Location = new System.Drawing.Point(10, 50);
            this.SetDead.Name = "SetDead";
            this.SetDead.Size = new System.Drawing.Size(51, 17);
            this.SetDead.TabIndex = 5;
            this.SetDead.TabStop = true;
            this.SetDead.Text = "Dead";
            this.SetDead.UseVisualStyleBackColor = true;
            this.SetDead.CheckedChanged += new System.EventHandler(this.SetDead_CheckedChanged);
            // 
            // SetAlive
            // 
            this.SetAlive.AutoSize = true;
            this.SetAlive.Location = new System.Drawing.Point(10, 27);
            this.SetAlive.Name = "SetAlive";
            this.SetAlive.Size = new System.Drawing.Size(48, 17);
            this.SetAlive.TabIndex = 4;
            this.SetAlive.TabStop = true;
            this.SetAlive.Text = "Alive";
            this.SetAlive.UseVisualStyleBackColor = true;
            this.SetAlive.CheckedChanged += new System.EventHandler(this.SetAlive_CheckedChanged);
            // 
            // SetImposter
            // 
            this.SetImposter.AutoSize = true;
            this.SetImposter.Location = new System.Drawing.Point(10, 59);
            this.SetImposter.Name = "SetImposter";
            this.SetImposter.Size = new System.Drawing.Size(65, 17);
            this.SetImposter.TabIndex = 2;
            this.SetImposter.TabStop = true;
            this.SetImposter.Text = "Imposter";
            this.SetImposter.UseVisualStyleBackColor = true;
            this.SetImposter.CheckedChanged += new System.EventHandler(this.SetImposter_CheckedChanged);
            // 
            // playerStatusLabel
            // 
            this.playerStatusLabel.AutoSize = true;
            this.playerStatusLabel.Location = new System.Drawing.Point(7, 20);
            this.playerStatusLabel.Name = "playerStatusLabel";
            this.playerStatusLabel.Size = new System.Drawing.Size(69, 13);
            this.playerStatusLabel.TabIndex = 1;
            this.playerStatusLabel.Text = "Player Status";
            // 
            // SetCrewmate
            // 
            this.SetCrewmate.AutoSize = true;
            this.SetCrewmate.Location = new System.Drawing.Point(10, 36);
            this.SetCrewmate.Name = "SetCrewmate";
            this.SetCrewmate.Size = new System.Drawing.Size(72, 17);
            this.SetCrewmate.TabIndex = 0;
            this.SetCrewmate.TabStop = true;
            this.SetCrewmate.Text = "Crewmate";
            this.SetCrewmate.UseVisualStyleBackColor = true;
            this.SetCrewmate.CheckedChanged += new System.EventHandler(this.SetCrewmate_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(134, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imposter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insta-kill";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetVisionNormal);
            this.groupBox3.Controls.Add(this.visionLabel);
            this.groupBox3.Controls.Add(this.SetVisionFull);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(134, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crewmate";
            // 
            // SetVisionNormal
            // 
            this.SetVisionNormal.AutoSize = true;
            this.SetVisionNormal.Location = new System.Drawing.Point(12, 59);
            this.SetVisionNormal.Name = "SetVisionNormal";
            this.SetVisionNormal.Size = new System.Drawing.Size(61, 17);
            this.SetVisionNormal.TabIndex = 2;
            this.SetVisionNormal.TabStop = true;
            this.SetVisionNormal.Text = "Normal ";
            this.SetVisionNormal.UseVisualStyleBackColor = true;
            this.SetVisionNormal.CheckedChanged += new System.EventHandler(this.SetVisionNormal_CheckedChanged);
            // 
            // visionLabel
            // 
            this.visionLabel.AutoSize = true;
            this.visionLabel.Location = new System.Drawing.Point(9, 20);
            this.visionLabel.Name = "visionLabel";
            this.visionLabel.Size = new System.Drawing.Size(35, 13);
            this.visionLabel.TabIndex = 1;
            this.visionLabel.Text = "Vision";
            // 
            // SetVisionFull
            // 
            this.SetVisionFull.AutoSize = true;
            this.SetVisionFull.Location = new System.Drawing.Point(12, 36);
            this.SetVisionFull.Name = "SetVisionFull";
            this.SetVisionFull.Size = new System.Drawing.Size(41, 17);
            this.SetVisionFull.TabIndex = 0;
            this.SetVisionFull.TabStop = true;
            this.SetVisionFull.Text = "Full";
            this.SetVisionFull.UseVisualStyleBackColor = true;
            this.SetVisionFull.CheckedChanged += new System.EventHandler(this.SetVisionFull_CheckedChanged);
            // 
            // HackGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(245, 192);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HackGUI";
            this.Text = "I\'m Among Us | Among Us Hacks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HackGUI_Closed);
            this.Load += new System.EventHandler(this.HackGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label playerStatusLabel;
        private System.Windows.Forms.RadioButton SetCrewmate;
        private System.Windows.Forms.RadioButton SetImposter;
        private System.Windows.Forms.RadioButton SetDead;
        private System.Windows.Forms.RadioButton SetAlive;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label visionLabel;
        private System.Windows.Forms.RadioButton SetVisionFull;
        private System.Windows.Forms.RadioButton SetVisionNormal;
        private System.Windows.Forms.Panel panel1;
    }
}