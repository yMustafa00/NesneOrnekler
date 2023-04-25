using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenciler> liste = new List<Ogrenciler>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumara.Text);
            ogrenci.AdSoyad = txtAdSoyad.Text;
            ogrenci.DersNotu = int.Parse(txtDersNotu.Text);
            liste.Add(ogrenci);
            Bagla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = gridListe.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = gridListe.CurrentRow.Cells[1].Value.ToString();
            txtDersNotu.Text = gridListe.CurrentRow.Cells[2].Value.ToString();
        }
        private void Bagla()
        {
            gridListe.DataSource = null;
            gridListe.DataSource = liste;
        }
    }
}


