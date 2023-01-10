using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_100
{
    class OkulPersoneli
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }
    }

    class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            OkulPersoneli per = new OkulPersoneli();
            Ogretmen ogrt = new Ogretmen();

            ogrt.Ad = "Mustafa";
            ogrt.Soyad = "Öztürk";
            ogrt.Brans = "Bilişim";
            Console.WriteLine("Öğretmen Sınıfında Türetilen {0} {1} {2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);


            per.Ad = "Ramazan";
            per.Soyad = "Güneş;";
            Console.WriteLine("Okul Personeli Sınıfından Tüketilen {0} {1} {2}", per.Ad, per.Soyad);
        }
    }
}
