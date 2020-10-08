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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkbox_fullbright = new System.Windows.Forms.CheckBox();
            this.checkbox_highlightImposters = new System.Windows.Forms.CheckBox();
            this.checkbox_showConsole = new System.Windows.Forms.CheckBox();
            this.checkbox_instaKill = new System.Windows.Forms.CheckBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.checkbox_imposter = new System.Windows.Forms.CheckBox();
            this.checkbox_dead = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkbox_fullbright);
            this.groupBox2.Controls.Add(this.checkbox_highlightImposters);
            this.groupBox2.Controls.Add(this.checkbox_showConsole);
            this.groupBox2.Controls.Add(this.checkbox_instaKill);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(107, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abilities";
            // 
            // checkbox_fullbright
            // 
            this.checkbox_fullbright.AutoSize = true;
            this.checkbox_fullbright.Location = new System.Drawing.Point(6, 62);
            this.checkbox_fullbright.Name = "checkbox_fullbright";
            this.checkbox_fullbright.Size = new System.Drawing.Size(68, 17);
            this.checkbox_fullbright.TabIndex = 5;
            this.checkbox_fullbright.Text = "Fullbright";
            this.checkbox_fullbright.UseVisualStyleBackColor = true;
            this.checkbox_fullbright.CheckedChanged += new System.EventHandler(this.checkbox_fullbright_CheckedChanged);
            // 
            // checkbox_highlightImposters
            // 
            this.checkbox_highlightImposters.AutoSize = true;
            this.checkbox_highlightImposters.Location = new System.Drawing.Point(6, 39);
            this.checkbox_highlightImposters.Name = "checkbox_highlightImposters";
            this.checkbox_highlightImposters.Size = new System.Drawing.Size(108, 17);
            this.checkbox_highlightImposters.TabIndex = 4;
            this.checkbox_highlightImposters.Text = "Red Name Impst.";
            this.checkbox_highlightImposters.UseVisualStyleBackColor = true;
            this.checkbox_highlightImposters.CheckedChanged += new System.EventHandler(this.checkbox_highlightImposters_CheckedChanged);
            // 
            // checkbox_showConsole
            // 
            this.checkbox_showConsole.AutoSize = true;
            this.checkbox_showConsole.Location = new System.Drawing.Point(6, 141);
            this.checkbox_showConsole.Name = "checkbox_showConsole";
            this.checkbox_showConsole.Size = new System.Drawing.Size(94, 17);
            this.checkbox_showConsole.TabIndex = 3;
            this.checkbox_showConsole.Text = "Show Console";
            this.checkbox_showConsole.UseVisualStyleBackColor = true;
            this.checkbox_showConsole.CheckedChanged += new System.EventHandler(this.checkbox_showConsole_CheckedChanged);
            // 
            // checkbox_instaKill
            // 
            this.checkbox_instaKill.AutoSize = true;
            this.checkbox_instaKill.Location = new System.Drawing.Point(6, 16);
            this.checkbox_instaKill.Name = "checkbox_instaKill";
            this.checkbox_instaKill.Size = new System.Drawing.Size(65, 17);
            this.checkbox_instaKill.TabIndex = 2;
            this.checkbox_instaKill.Text = "Insta-Kill";
            this.checkbox_instaKill.UseVisualStyleBackColor = true;
            this.checkbox_instaKill.CheckedChanged += new System.EventHandler(this.checkbox_instaKill_CheckedChanged);
            // 
            // button_reset
            // 
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(12, 182);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(220, 23);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "Sync Players/Reset/New Game";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // checkbox_imposter
            // 
            this.checkbox_imposter.AutoSize = true;
            this.checkbox_imposter.Location = new System.Drawing.Point(6, 16);
            this.checkbox_imposter.Name = "checkbox_imposter";
            this.checkbox_imposter.Size = new System.Drawing.Size(66, 17);
            this.checkbox_imposter.TabIndex = 8;
            this.checkbox_imposter.Text = "Imposter";
            this.checkbox_imposter.UseVisualStyleBackColor = true;
            this.checkbox_imposter.CheckedChanged += new System.EventHandler(this.checkbox_imposter_CheckedChanged);
            // 
            // checkbox_dead
            // 
            this.checkbox_dead.AutoSize = true;
            this.checkbox_dead.Location = new System.Drawing.Point(6, 39);
            this.checkbox_dead.Name = "checkbox_dead";
            this.checkbox_dead.Size = new System.Drawing.Size(52, 17);
            this.checkbox_dead.TabIndex = 9;
            this.checkbox_dead.Text = "Dead";
            this.checkbox_dead.UseVisualStyleBackColor = true;
            this.checkbox_dead.CheckedChanged += new System.EventHandler(this.checkbox_dead_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox_dead);
            this.groupBox1.Controls.Add(this.checkbox_imposter);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // HackGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(245, 216);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HackGUI";
            this.Text = "I\'m Among Them";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HackGUI_Closed);
            this.Load += new System.EventHandler(this.HackGUI_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkbox_instaKill;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.CheckBox checkbox_imposter;
        private System.Windows.Forms.CheckBox checkbox_dead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbox_showConsole;
        private System.Windows.Forms.CheckBox checkbox_highlightImposters;
        private System.Windows.Forms.CheckBox checkbox_fullbright;
    }
}