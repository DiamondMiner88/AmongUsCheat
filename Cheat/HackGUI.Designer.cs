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
            this.deadRadio = new System.Windows.Forms.RadioButton();
            this.aliveRadio = new System.Windows.Forms.RadioButton();
            this.imposterRadio = new System.Windows.Forms.RadioButton();
            this.playerStatusLabel = new System.Windows.Forms.Label();
            this.crewmateRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.normalRadio = new System.Windows.Forms.RadioButton();
            this.visionLabel = new System.Windows.Forms.Label();
            this.fullRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.imposterRadio);
            this.groupBox1.Controls.Add(this.playerStatusLabel);
            this.groupBox1.Controls.Add(this.crewmateRadio);
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
            this.panel1.Controls.Add(this.deadRadio);
            this.panel1.Controls.Add(this.aliveRadio);
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
            // deadRadio
            // 
            this.deadRadio.AutoSize = true;
            this.deadRadio.Location = new System.Drawing.Point(10, 50);
            this.deadRadio.Name = "deadRadio";
            this.deadRadio.Size = new System.Drawing.Size(51, 17);
            this.deadRadio.TabIndex = 5;
            this.deadRadio.TabStop = true;
            this.deadRadio.Text = "Dead";
            this.deadRadio.UseVisualStyleBackColor = true;
            this.deadRadio.CheckedChanged += new System.EventHandler(this.deadRadio_CheckedChanged);
            // 
            // aliveRadio
            // 
            this.aliveRadio.AutoSize = true;
            this.aliveRadio.Location = new System.Drawing.Point(10, 27);
            this.aliveRadio.Name = "aliveRadio";
            this.aliveRadio.Size = new System.Drawing.Size(48, 17);
            this.aliveRadio.TabIndex = 4;
            this.aliveRadio.TabStop = true;
            this.aliveRadio.Text = "Alive";
            this.aliveRadio.UseVisualStyleBackColor = true;
            this.aliveRadio.CheckedChanged += new System.EventHandler(this.aliveRadio_CheckedChanged);
            // 
            // imposterRadio
            // 
            this.imposterRadio.AutoSize = true;
            this.imposterRadio.Location = new System.Drawing.Point(10, 59);
            this.imposterRadio.Name = "imposterRadio";
            this.imposterRadio.Size = new System.Drawing.Size(65, 17);
            this.imposterRadio.TabIndex = 2;
            this.imposterRadio.TabStop = true;
            this.imposterRadio.Text = "Imposter";
            this.imposterRadio.UseVisualStyleBackColor = true;
            this.imposterRadio.CheckedChanged += new System.EventHandler(this.imposterRadio_CheckedChanged);
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
            // crewmateRadio
            // 
            this.crewmateRadio.AutoSize = true;
            this.crewmateRadio.Location = new System.Drawing.Point(10, 36);
            this.crewmateRadio.Name = "crewmateRadio";
            this.crewmateRadio.Size = new System.Drawing.Size(72, 17);
            this.crewmateRadio.TabIndex = 0;
            this.crewmateRadio.TabStop = true;
            this.crewmateRadio.Text = "Crewmate";
            this.crewmateRadio.UseVisualStyleBackColor = true;
            this.crewmateRadio.CheckedChanged += new System.EventHandler(this.crewmateRadio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
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
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kill Cooldown: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.normalRadio);
            this.groupBox3.Controls.Add(this.visionLabel);
            this.groupBox3.Controls.Add(this.fullRadio);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(134, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crewmate";
            // 
            // normalRadio
            // 
            this.normalRadio.AutoSize = true;
            this.normalRadio.Location = new System.Drawing.Point(12, 59);
            this.normalRadio.Name = "normalRadio";
            this.normalRadio.Size = new System.Drawing.Size(61, 17);
            this.normalRadio.TabIndex = 2;
            this.normalRadio.TabStop = true;
            this.normalRadio.Text = "Normal ";
            this.normalRadio.UseVisualStyleBackColor = true;
            this.normalRadio.CheckedChanged += new System.EventHandler(this.normalRadio_CheckedChanged);
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
            // fullRadio
            // 
            this.fullRadio.AutoSize = true;
            this.fullRadio.Location = new System.Drawing.Point(12, 36);
            this.fullRadio.Name = "fullRadio";
            this.fullRadio.Size = new System.Drawing.Size(41, 17);
            this.fullRadio.TabIndex = 0;
            this.fullRadio.TabStop = true;
            this.fullRadio.Text = "Full";
            this.fullRadio.UseVisualStyleBackColor = true;
            this.fullRadio.CheckedChanged += new System.EventHandler(this.fullRadio_CheckedChanged);
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
        private System.Windows.Forms.RadioButton crewmateRadio;
        private System.Windows.Forms.RadioButton imposterRadio;
        private System.Windows.Forms.RadioButton deadRadio;
        private System.Windows.Forms.RadioButton aliveRadio;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label visionLabel;
        private System.Windows.Forms.RadioButton fullRadio;
        private System.Windows.Forms.RadioButton normalRadio;
        private System.Windows.Forms.Panel panel1;
    }
}