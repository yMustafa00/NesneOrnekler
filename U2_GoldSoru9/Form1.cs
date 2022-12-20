using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru9
{
    public partial class Form1 : Form
    {
        int sayi;
        int tutulan;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = 100;
            Random random = new Random();
            button2.Enabled = true;
            label2.Text = "" + sayi.ToString();
            tutulan = random.Next(101);
            MessageBox.Show("Oyun Başlamıştır Aklımdan Bir Sayı Tuttum Bol Şanslar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                if (tahmin < tutulan)
                {
                    MessageBox.Show("Yukarı");
                    sayi = sayi - 10;
                }
                else if (tahmin > tutulan)
                {
                    MessageBox.Show("Aşağı");
                    sayi = sayi - 10;
                }
                else
                {
                    MessageBox.Show("Tebrikler Çatal Bıcak Seti Kazandınız...");
                }


                if (sayi == 0)
                {
                    MessageBox.Show("Oyunu Kaybettiniz Lütfen Tekrar Başlayınız");
                    button2.Enabled = false;
                }
                label2.Text = sayi.ToString();
                textBox1.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
                throw;
            }

        }
    }
}
