using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Projesi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public int girilendeger2;
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Girilen değeri Onaylıyor musunuz?", "", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                girilendeger2 = 0;
                girilendeger2 = Convert.ToInt32(textBox1.Text);
                this.Hide();
                
            }
            else if (uyari == DialogResult.No)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = 10.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 20.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = 50.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = 100.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = 200.ToString();
        }
    }
}
