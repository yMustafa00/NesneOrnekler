
namespace U4_Uyg9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatirSayisi = new System.Windows.Forms.TextBox();
            this.txtSutunSayisi = new System.Windows.Forms.TextBox();
            this.txtRastgeleMin = new System.Windows.Forms.TextBox();
            this.txtRastgeleMax = new System.Windows.Forms.TextBox();
            this.btnDiziOlustur = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.listeDizi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizi Satır Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dizi Sütun Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rastgele En Düşük Sayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rastgele En Büyük Sayı";
            // 
            // txtSatirSayisi
            // 
            this.txtSatirSayisi.Location = new System.Drawing.Point(194, 26);
            this.txtSatirSayisi.Name = "txtSatirSayisi";
            this.txtSatirSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSatirSayisi.TabIndex = 4;
            // 
            // txtSutunSayisi
            // 
            this.txtSutunSayisi.Location = new System.Drawing.Point(194, 69);
            this.txtSutunSayisi.Name = "txtSutunSayisi";
            this.txtSutunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSutunSayisi.TabIndex = 5;
            // 
            // txtRastgeleMin
            // 
            this.txtRastgeleMin.Location = new System.Drawing.Point(194, 114);
            this.txtRastgeleMin.Name = "txtRastgeleMin";
            this.txtRastgeleMin.Size = new System.Drawing.Size(100, 20);
            this.txtRastgeleMin.TabIndex = 6;
            // 
            // txtRastgeleMax
            // 
            this.txtRastgeleMax.Location = new System.Drawing.Point(194, 164);
            this.txtRastgeleMax.Name = "txtRastgeleMax";
            this.txtRastgeleMax.Size = new System.Drawing.Size(100, 20);
            this.txtRastgeleMax.TabIndex = 7;
            // 
            // btnDiziOlustur
            // 
            this.btnDiziOlustur.Location = new System.Drawing.Point(164, 208);
            this.btnDiziOlustur.Name = "btnDiziOlustur";
            this.btnDiziOlustur.Size = new System.Drawing.Size(130, 23);
            this.btnDiziOlustur.TabIndex = 8;
            this.btnDiziOlustur.Text = "Dizi Oluştur";
            this.btnDiziOlustur.UseVisualStyleBackColor = true;
            this.btnDiziOlustur.Click += new System.EventHandler(this.btnDiziOlustur_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(372, 24);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(130, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Dizi Göster";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // listeDizi
            // 
            this.listeDizi.FormattingEnabled = true;
            this.listeDizi.Location = new System.Drawing.Point(350, 53);
            this.listeDizi.Name = "listeDizi";
            this.listeDizi.Size = new System.Drawing.Size(174, 186);
            this.listeDizi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeDizi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnDiziOlustur);
            this.Controls.Add(this.txtRastgeleMax);
            this.Controls.Add(this.txtRastgeleMin);
            this.Controls.Add(this.txtSutunSayisi);
            this.Controls.Add(this.txtSatirSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatirSayisi;
        private System.Windows.Forms.TextBox txtSutunSayisi;
        private System.Windows.Forms.TextBox txtRastgeleMin;
        private System.Windows.Forms.TextBox txtRastgeleMax;
        private System.Windows.Forms.Button btnDiziOlustur;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox listeDizi;
    }
}

