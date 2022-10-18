using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_off_Click(object sender, EventArgs e)
        {
            tb_screen.Text = "";
            tb_screen.Enabled = false;
            tableLayoutPanel1.Enabled = false;
            tableLayoutPanel2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_on_Click(object sender, EventArgs e)
        {
            tb_screen.Text = "";
            tb_screen.Enabled = true;
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel2.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            tb_screen.Text += ".";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            tb_screen.Text = "";
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "+";
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "-";
        }

        private void bt_multiple_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "*";
        }

        private void bt_divide_Click(object sender, EventArgs e)
        {
            tb_screen.Text += "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
