using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 2)
                {
                    txtBilgi.Text = "";
                    txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                    txtBilgi.Text += txtAdres.Text + "\r\n";
                    txtBilgi.Text += txtTelefon.Text + "\r\n";
                    decimal hesap = 0;
                    if (nCorba.Value > 0)
                    {
                        hesap += nCorba.Value * 35;
                        txtBilgi.Text += string.Format("Çorba {0:C}", nCorba.Value * 40) + "\r\n";
                    }

                    if (nYemek.Value > 0)
                    {
                        hesap += nYemek.Value * 75;
                        txtBilgi.Text += string.Format("Yemek {0:C}", nCorba.Value * 40) + "\r\n";
                    }

                    if (nTatli.Value > 0)
                    {
                        hesap += nTatli.Value * 40;
                        txtBilgi.Text += string.Format("Tatlı {0:C}", nTatli.Value * 40);
                    }
                    if (nSalata.Value > 0)
                    {
                        hesap += nSalata.Value * 25;
                        txtBilgi.Text += string.Format("Salata {0:C}", nSalata.Value * 25);
                    }


                    txtBilgi.Text += string.Format("Toplam{0:C}", hesap);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Spariş Verirken Bir Hata Oluştu Lütfen Eksiksiz Tekrar Deneyiniz");
                throw;
            }
        }
    }
}

