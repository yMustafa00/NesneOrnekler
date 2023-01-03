﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_81
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 3;
            ucgen.B = 4;
            ucgen.B = 5;
            Console.WriteLine("Ucgenin a kenar uzunluğu: {0}", ucgen.A);
            Console.WriteLine("Ucgenin b kenar uzunluğu: {0}", ucgen.B);
            Console.WriteLine("Ucgenin c kenar uzunluğu: {0}", ucgen.C);

            Console.ReadLine();
        }
    }



    public class Ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)

                    Console.WriteLine("Hatalı Bilgi");
                else
                    a = value;

            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatakı Bilgi");
                else
                    b = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı Bilgi");
                else
                    c = value;
            }
        }
    }
}
