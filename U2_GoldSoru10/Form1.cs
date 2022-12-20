using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int takimSayisi = listBox1.Items.Count;

            for (int i = 1; i <= takimSayisi; i++)
            {
                int tutulan = random.Next(0, listBox1.Items.Count);
                if (i % 4 == 0)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else if (i % 4 == 1)
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else if (i % 4 == 2)
                {
                    listBox4.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox5.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }
    }
}



