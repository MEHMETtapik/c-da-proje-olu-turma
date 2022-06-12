using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ATM_Projesi
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string kullaniciadi, sifresi;
        ArrayList KullaniciAdi = new ArrayList() { "mehmetali", "makbule" };
        ArrayList sifre = new ArrayList() { "123qwe123", "12345" };
        
        Form2 islemler = new Form2();
        

        private void button1_Click(object sender, EventArgs e)
        {
            islemler.hesapnumarasi = 0;
            kullaniciadi = textBox1.Text;
            sifresi = textBox2.Text;
            for (int i = 0; i < KullaniciAdi.Count; i++)
            {
                if(kullaniciadi==KullaniciAdi[i].ToString()&&sifresi==sifre[i].ToString())
                {
                    islemler.hesapnumarasi++;
                    islemler.Show();
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
