using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[3];
        int[,] notlar = new int[3, 4];
        int index = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
            isimler[index] = txtAdSoyad.Text;
            notlar[index, 0] = int.Parse(txtNot1.Text);
            notlar[index, 1] = int.Parse(txtNot2.Text);
            notlar[index, 2] = int.Parse(txtNot3.Text);
            notlar[index, 3] = int.Parse(txtNot4.Text);
            index++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Bir Hata Oluştu Lütfen Tekrar Deneyiniz");
            }
           
        }
    }
}
