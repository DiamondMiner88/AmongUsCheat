using System;
using System.Windows.Forms;

namespace Cheat
{
    public partial class HackGUI : Form
    {
        public bool isOpen = false;

        public HackGUI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            TopMost = true;
            MinimizeBox = true;
            MaximizeBox = false;
        }

        #region Elements
        public CheckBox element_instaKill
        {
            get
            {
                return checkbox_instaKill;
            }
        }

        public CheckBox element_fullbright
        {
            get
            {
                return checkbox_fullbright;
            }
        }

        public CheckBox element_highlightImposters
        {
            get
            {
                return checkbox_highlightImposters;
            }
        }
        #endregion

        private void HackGUI_Load(object sender, EventArgs e) =>
            isOpen = true;

        private void HackGUI_Closed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
            Program.Exit();
        }

        private void button_reset_Click(object sender, EventArgs e) =>
            Memory.RunCommand("reset");

        private void checkbox_instaKill_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) Memory.RunCommand("disablecooldown");
            else Memory.RunCommand("enablecooldown");
        }

        private void checkbox_dead_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) Memory.RunCommand("dead");
            else Memory.RunCommand("alive");
        }

        private void checkbox_showConsole_CheckedChanged(object sender, EventArgs e) =>
            Program.DisplayConsole((sender as CheckBox).Checked);

        private void checkbox_highlightImposters_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) Memory.RunCommand("highlightimposters");
            else Memory.RunCommand("nohighlight");
        }

        private void checkbox_fullbright_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) Memory.RunCommand("fullbright");
            else Memory.RunCommand("nofullbright");
        }
    }
}
