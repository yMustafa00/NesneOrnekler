using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isimler[index] = textBox1.Text;
                index++;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Beşten Fazla İsim Girmeyiniz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < isimler.Length; i++)
                {
                    listBox1.Items.Add(isimler[i]);
                }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
