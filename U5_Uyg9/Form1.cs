using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void kEsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu uygulamayı kapatmak istediğinize emin misiniz ?", "Dosyayı Kapat", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cevap==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası |*.txt | Tüm Dosyalar|*.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap==DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
