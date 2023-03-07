
namespace U4_Uyg5
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
            this.btnDiziOlustur = new System.Windows.Forms.Button();
            this.listeAsil = new System.Windows.Forms.ListBox();
            this.btnDiziKopyala = new System.Windows.Forms.Button();
            this.listeKopya = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDiziOlustur
            // 
            this.btnDiziOlustur.Location = new System.Drawing.Point(12, 12);
            this.btnDiziOlustur.Name = "btnDiziOlustur";
            this.btnDiziOlustur.Size = new System.Drawing.Size(124, 38);
            this.btnDiziOlustur.TabIndex = 0;
            this.btnDiziOlustur.Text = "Dizi Oluştur";
            this.btnDiziOlustur.UseVisualStyleBackColor = true;
            this.btnDiziOlustur.Click += new System.EventHandler(this.btnDiziOlustur_Click);
            // 
            // listeAsil
            // 
            this.listeAsil.FormattingEnabled = true;
            this.listeAsil.Location = new System.Drawing.Point(157, 12);
            this.listeAsil.Name = "listeAsil";
            this.listeAsil.Size = new System.Drawing.Size(120, 277);
            this.listeAsil.TabIndex = 1;
            // 
            // btnDiziKopyala
            // 
            this.btnDiziKopyala.Location = new System.Drawing.Point(306, 12);
            this.btnDiziKopyala.Name = "btnDiziKopyala";
            this.btnDiziKopyala.Size = new System.Drawing.Size(111, 38);
            this.btnDiziKopyala.TabIndex = 2;
            this.btnDiziKopyala.Text = "Dizi Kopyala";
            this.btnDiziKopyala.UseVisualStyleBackColor = true;
            this.btnDiziKopyala.Click += new System.EventHandler(this.btnDiziKopyala_Click);
            // 
            // listeKopya
            // 
            this.listeKopya.FormattingEnabled = true;
            this.listeKopya.Location = new System.Drawing.Point(442, 12);
            this.listeKopya.Name = "listeKopya";
            this.listeKopya.Size = new System.Drawing.Size(120, 277);
            this.listeKopya.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeKopya);
            this.Controls.Add(this.btnDiziKopyala);
            this.Controls.Add(this.listeAsil);
            this.Controls.Add(this.btnDiziOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiziOlustur;
        private System.Windows.Forms.ListBox listeAsil;
        private System.Windows.Forms.Button btnDiziKopyala;
        private System.Windows.Forms.ListBox listeKopya;
    }
}

