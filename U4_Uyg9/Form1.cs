using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        int satirSayisi;
        int sutunSayisi;
        private void btnDiziOlustur_Click(object sender, EventArgs e)
        {
            int rastgeleMin = int.Parse(txtRastgeleMin.Text);
            int rastgeleMax = int.Parse(txtRastgeleMax.Text);
            satirSayisi = int.Parse(txtSatirSayisi.Text);
            sutunSayisi = int.Parse(txtSutunSayisi.Text);
            dizi = new int[satirSayisi, sutunSayisi];
            Random random = new Random();
            for (int x = 0; x < satirSayisi; x++)
            {
                dizi[x, y] = rastgele.Next(rastgeleMin, rastgeleMax);
            }
        }
    }
}
