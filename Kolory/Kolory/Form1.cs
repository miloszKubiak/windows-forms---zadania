using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.trackBar4_ValueChanged(this, null);
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001B') Close();
        }
    }
}
