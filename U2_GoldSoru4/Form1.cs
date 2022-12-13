using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                if (sayi1 < sayi2)
                {
                    for (int i = sayi1; i < sayi2; i++)
                    {
                        if (i % 2 == 0)
                        {
                            listBox2.Items.Add(i);
                        }
                        else
                        {
                            listBox1.Items.Add(i);
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Büyük Sayı Kısmına Büyük Bir Sayı Giriniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
            }

        }
    }
}
