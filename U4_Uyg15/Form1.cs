using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg15
{
    using System.Collections;
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        Stack yigin = new Stack();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            yigin.Push(txtAdSoyad.Text);
            Listele();
        }
        private void Listele()
        {
            listeStack.Items.Clear();
            foreach (var eleman in yigin)
            {
                listeStack.Items.Add(eleman);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }
    }

