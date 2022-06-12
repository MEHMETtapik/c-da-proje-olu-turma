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
    
    public partial class Form2 : Form
    {
        
        Form3 yatirmaekrani = new Form3();
        Form4 paracekmeekrani=new Form4();
        public ArrayList kisilerinhesaplari = new ArrayList() { 0, 0 };
        public Form2()
        {
            InitializeComponent();
        }
        public int hesapnumarasi = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

           


        }

        int deger,toplam=0;
        int islemne;
        private void button1_Click(object sender, EventArgs e)
        {
            islemne = 1;
            yatirmaekrani.Show();
             deger= Convert.ToInt32(kisilerinhesaplari[hesapnumarasi]) + yatirmaekrani.girilendeger;
            
            label1.Text = deger.ToString();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            islemne = 2;
            paracekmeekrani.Show();
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesapnumarasi = 0;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(islemne==1)
            {
                kisilerinhesaplari[hesapnumarasi] = Convert.ToInt32(kisilerinhesaplari[hesapnumarasi]) + yatirmaekrani.girilendeger;
                
                label1.Text = kisilerinhesaplari[hesapnumarasi].ToString();
            }
            else if(islemne==2)
            {
                kisilerinhesaplari[hesapnumarasi] = Convert.ToInt32(kisilerinhesaplari[hesapnumarasi]) - paracekmeekrani.girilendeger2;
                
                label1.Text = kisilerinhesaplari[hesapnumarasi].ToString();
            }
            islemne = 0;
            
        }
    }   
}
