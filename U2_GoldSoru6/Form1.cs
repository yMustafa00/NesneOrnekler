﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru6
{
    public partial class Form1 : Form
    {
        int senesonuortalaması;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y1, y2, y3, ortalama;
            progressBar1.ForeColor = Color.Red;
            progressBar2.ForeColor = Color.DarkGreen;
            progressBar3.ForeColor = Color.DarkBlue;
            progressBar4.ForeColor = Color.DarkBlue;
            try
            {
                y1 = Convert.ToInt32(textBox1.Text);
                y2 = Convert.ToInt32(textBox2.Text);
                y3 = Convert.ToInt32(textBox3.Text);
                ortalama = (y1 + y2 + y3) / 3;
                senesonuortalaması = ortalama / 4;
                progressBar5.Value += senesonuortalaması;
                if ((y1 > 100 || y1 < 0) || (y2 > 100 || y2 < 0) || (y3 > 100 || y3 < 0))
                {
                    MessageBox.Show("Lütfen 0-100 arasında rakam Giriniz");
                }
                else
                {

                    label5.Text = ortalama.ToString();                   
                    if (radioButton1.Checked == true)
                    {
                        progressBar1.Value = ortalama;
                        label4.Text = "Matematik";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        progressBar2.Value = ortalama;
                        label4.Text = "Türkçe";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        progressBar3.Value = ortalama;
                        label4.Text = "Nesne Programlama";
                    }
                    else if (radioButton4.Checked == true)
                    {
                        progressBar4.Value = ortalama;
                        label4.Text = "Robotik Kodlama";
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bir Ders Seçiniz");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Rakam Giriniz");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
    }
}


