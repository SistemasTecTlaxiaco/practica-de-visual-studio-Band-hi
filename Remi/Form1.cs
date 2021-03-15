using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 8;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 10;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 11;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 9;
        }
    }
}
