using System;
using System.Windows.Forms;

namespace Cheat
{
    public partial class HackGUI : Form
    {
        public HackGUI()
        {
            TopMost = true;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            panel1.BorderStyle = BorderStyle.None;
        }

        private void HackGUI_Load(object sender, EventArgs e)
        {
            // set default values if any
        }

        private void HackGUI_Closed(object sender, FormClosedEventArgs e) =>
            Program.Exit();

        private void SetKillCooldown_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
        }

        private void SetVisionFull_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;

            Memory.RunCommand("fullbright");
        }

        private void SetVisionNormal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;

            Memory.RunCommand("nofullbright");
        }

        private void SetAlive_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;

            Memory.RunCommand("alive");
        }

        private void SetDead_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;

            Memory.RunCommand("dead");
        }

        private void SetCrewmate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;

            Memory.RunCommand("crewmate");
        }

        private void SetImposter_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;

            Memory.RunCommand("imposter");
        }
    }
}
