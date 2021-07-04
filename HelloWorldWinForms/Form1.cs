using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinForms
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

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl.Text = "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl.Text = "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl.Text = "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl.Text = "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl.Text = "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl.Text = "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl.Text = "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl.Text = "8";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl.Text = "";
            lbl.ForeColor = Color.Black;
        }

        private void red_CheckedChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.Red;
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.Green;
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.Blue;
        }

        private void yellow_CheckedChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.Yellow;
        }
    }
}
