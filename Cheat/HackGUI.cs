using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat {
    public partial class HackGUI : Form {
        public HackGUI() {
            TopMost = true;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            panel1.BorderStyle = BorderStyle.None;
        }

        private void crewmateRadio_CheckedChanged(object sender, EventArgs e) {
            Memory.RunCommand("noimp");
        }

        private void imposterRadio_CheckedChanged(object sender, EventArgs e) {
            Memory.RunCommand("imp");
        }

        private void aliveRadio_CheckedChanged(object sender, EventArgs e) {
            Memory.RunCommand("alive");
        }

        private void deadRadio_CheckedChanged(object sender, EventArgs e) {
            Memory.RunCommand("dead");
        }

        private void fullRadio_CheckedChanged(object sender, EventArgs e) {
            Memory.RunCommand("fullbright");
        }

        private void normalRadio_CheckedChanged(object sender, EventArgs e) {
            Memory.RunCommand("nofullbright");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                
            } catch {

            }
        }
    }
}
