using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SinavProjesi
{
    class VeriTabaniİslemleri
    {
        string baglantiCumlesi = ConfigurationManager.ConnectionStrings["urunlerBaglantiCumlesi"].ConnectionString;


        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);

            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}