using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi;
            long parola;
            try
            {
                kullanici_adi = textBox1.Text.ToString();
                parola = long.Parse(textBox2.Text.ToString());
                MessageBox.Show("Giriş Başarılı. Hoşgeldiniz" + kullanici_adi);
            }
            catch (Exception)
            {
                MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmaktadır. Düzgün Giriniz");
                textBox2.Text = "";
            }
        }
    }
}
