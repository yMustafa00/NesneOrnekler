﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue kuyruk = new Queue();
        int sira = 0;


        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }
        private void Listele()
        {
            listeSiralar.Items.Clear();
            foreach (var sirar in kuyruk)
            {
                listeSiralar.Items.Add(sira);
            }
        }

        private void btnSiraCikart_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
    }
 }
