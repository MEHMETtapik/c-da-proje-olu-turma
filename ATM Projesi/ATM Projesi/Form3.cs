using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ATM_Projesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public int girilendeger;

    private void Form3_Load(object sender,EventArgs e)
    {
            girilendeger = 0;
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

    private void button7_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
    }

    private void button6_Click(object sender, EventArgs e)
    {
        DialogResult uyari = MessageBox.Show("Girilen değeri Onaylıyor musunuz?", "", MessageBoxButtons.YesNo);
        if (uyari == DialogResult.Yes)
        {
                girilendeger = 0;
                girilendeger = Convert.ToInt32(textBox1.Text);
            this.Hide();
                
        }
        else if (uyari == DialogResult.No)
        {

        }
    }

}
        
    }


