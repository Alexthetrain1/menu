using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fawfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.White;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.DarkRed;
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.White;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void colortextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
