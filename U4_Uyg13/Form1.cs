using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg13
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();

        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(txtNumara1.Text));
            lbSayi.Items.Clear();
            foreach (var item in numaralarList)
            {
                lbSayi.Items.Add(item);
            }
        }

        private void btnNesneEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumara2.Text);
            ogrenci.AdSoyad = txtAdSoyad2.Text;
            ogrencilerList.Add(ogrenci);
            lbNesne.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                lbNesne.Items.Add(item.Numara + "" + item.AdSoyad);
            }
        }

        private void btnMetinEkle_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(txtAdSoyad1.Text));
            lbMetin.Items.Clear();
            foreach (var item in numaralarList)
            {
                lbMetin.Items.Add(item);
            }
        }

        private void lbSayi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
