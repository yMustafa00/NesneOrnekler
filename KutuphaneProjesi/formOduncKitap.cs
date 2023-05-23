using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formOduncKitap : Form
    {
        public formOduncKitap()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtİşlemler = new VeriTabaniIslemleri;
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;

        private void formOduncKitap_Load(object sender, EventArgs e)
        {
            Listele();
            KitapYukle();
        }

        private void Listele()
        {
            try
            {
                baglanti = vtİşlemler.baglan();
                komutSatiri = "Select id, ogrenci_no,ad,soyad,kitap_adi,verilis_tarihi,teslim_tarihi,aciklama" + "From kitaplar,ogrenciler,odunc_kitaplar" + "where ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitarplar.kitap_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOduncKitaplar.DataSource = dataTable;

                gridOduncKitaplar.Columns["id"].HeaderText = "ID";
                gridOduncKitaplar.Columns["id"].Width = 30;
                gridOduncKitaplar.Columns["ogrenci_no"].HeaderText = "Öğrenci No";
                gridOduncKitaplar.Columns["ogrenci_no"].Width = 40;
                gridOduncKitaplar.Columns["ad"].HeaderText = "Ad";
                gridOduncKitaplar.Columns["ad"].Width = 70;
                gridOduncKitaplar.Columns["soyad"].HeaderText = "Soyad";
                gridOduncKitaplar.Columns["soyad"].Width = 70;
                gridOduncKitaplar.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                gridOduncKitaplar.Columns["kitap_adi"].Width = 100;
                gridOduncKitaplar.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
                gridOduncKitaplar.Columns["verilis_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
                gridOduncKitaplar.Columns["teslim_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["aciklama"].HeaderText = "Açıklama";
                gridOduncKitaplar.Columns["aciklama"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KitapYukle()
        {
            try
            {
                komutSatiri = "Select * from kitaplar where kitap_id not in (select kitap_id from odunc_kitaplar where teslim_tarihi IS NULL";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitap.DataSource = dataTable;
                comboKitap.ValueMember = "kitap_id";
                comboKitap.DisplayMember = "kitap_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    komut = new MySqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO odunc_kitaplar (ogr_no, kitap_id, verilis_tarihi,aciklama)" + "VALUES(@ogr_no,@kitap_id,@verilis_tarihi,@aciklama";
                    komut.Parameters.AddWithValue("@ogr_no", int.Parse(txtNo.Text));
                    komut.Parameters.AddWithValue("@kitap_id", int.Parse(comboKitap.SelectedValue.ToString()));
                    komut.Parameters.AddWithValue("@verilis_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                    komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Temizle();
                    KitapYukle();
                    Listele();
                    MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtNo.Clear();
            txtAciklama.Clear();
        }
    }
}
