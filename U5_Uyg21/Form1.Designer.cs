
namespace U5_Uyg21
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
            this.btnVeriBagla = new System.Windows.Forms.Button();
            this.listeVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVeriBagla
            // 
            this.btnVeriBagla.Location = new System.Drawing.Point(12, 165);
            this.btnVeriBagla.Name = "btnVeriBagla";
            this.btnVeriBagla.Size = new System.Drawing.Size(120, 37);
            this.btnVeriBagla.TabIndex = 0;
            this.btnVeriBagla.Text = "Veri Bağla";
            this.btnVeriBagla.UseVisualStyleBackColor = true;
            this.btnVeriBagla.Click += new System.EventHandler(this.btnVeriBagla_Click);
            // 
            // listeVeriler
            // 
            this.listeVeriler.FormattingEnabled = true;
            this.listeVeriler.Location = new System.Drawing.Point(12, 12);
            this.listeVeriler.Name = "listeVeriler";
            this.listeVeriler.Size = new System.Drawing.Size(120, 134);
            this.listeVeriler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeVeriler);
            this.Controls.Add(this.btnVeriBagla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeriBagla;
        private System.Windows.Forms.ListBox listeVeriler;
    }
}

