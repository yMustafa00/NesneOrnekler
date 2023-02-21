using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_115
{
    class Program
    {

        enum Seviyeler
        {
            Çok_Düşük,
            Düşük,
            Orta,
            Yüksek,
            Çok_Yüksek,
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Seviyeler.Çok_Yüksek);
            Console.WriteLine((int)Seviyeler.Çok_Yüksek);

            Console.ReadLine();
        }
    }
}
