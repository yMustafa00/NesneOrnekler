using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // 1.yol: while döngüsü kullanılarak
            int say = 1;
            while (say<=10)
            {
                listBox1.Items.Add(say);
                say++;
            }
            
            // 2.yol: for döngüsü kullanılarak
            for (int say1 = 1; say1 <= 10; say1++)
            {
                listBox1.Items.Add(say1);
            }
        }
    }
}
