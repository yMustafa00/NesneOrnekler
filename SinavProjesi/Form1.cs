using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SinavProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeriTabaniİslemleri Vtİslemler = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri, aranacakUrun;

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = Vtİslemler.baglan();
                komutSatiri = "SELECT * FROM urunler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridUrunler.DataSource = dataTable;
                gridUrunler.Columns["fiyat"].HeaderText = "Fiyat";
                gridUrunler.Columns["urun_adi"].HeaderText = "Ürün Adı";
                gridUrunler.Columns["adet"].HeaderText = "Adet";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "INSERT INTO urunler (urun_adi,fiyat,adet) VALUES (@adi,@fiyat,@adet)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@adet", int.Parse(txtAdet.Text.ToString()));
                komut.Parameters.AddWithValue("@fiyat", (txtFiyat.Text));
                komut.Parameters.AddWithValue("@adi", (txtUrunAdi.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başaralı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Temizle()
        {
            txtAdet.Clear();
            txtFiyat.Clear();
            txtUrunAdi.Clear();
        }

        private void gridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAdet.Text = gridUrunler.CurrentRow.Cells["adet"].Value.ToString();
                txtFiyat.Text = gridUrunler.CurrentRow.Cells["fiyat"].Value.ToString();
                txtUrunAdi.Text = gridUrunler.CurrentRow.Cells["urun_adi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "DELETE FROM urunler WHERE urun_adi =@urun_adi";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@urun_adi", gridUrunler.CurrentRow.Cells["urun_adi"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "UPDATE urunler SET urun_adi=@urun_adi,fiyat=@fiyat,adet=@adet";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("fiyat", int.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("urun_adi", (txtUrunAdi.Text));
                komut.Parameters.AddWithValue("adet", (txtAdet.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            UrunArama(txtUrunAra.Text);
        }

        private void UrunArama(string text)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Select * From urunler Where ad LIKE '" + aranacakUrun + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridUrunler.DataSource = dataTable;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
