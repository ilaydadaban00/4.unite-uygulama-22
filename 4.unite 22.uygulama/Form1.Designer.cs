namespace _4.unite_22.uygulama
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
            this.btnListele = new System.Windows.Forms.Button();
            this.listeVeri = new System.Windows.Forms.ListBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(473, 77);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(95, 58);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // listeVeri
            // 
            this.listeVeri.FormattingEnabled = true;
            this.listeVeri.Location = new System.Drawing.Point(336, 17);
            this.listeVeri.Name = "listeVeri";
            this.listeVeri.Size = new System.Drawing.Size(120, 134);
            this.listeVeri.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(132, 28);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "kitap adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "kitap  yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "kitap  türü";
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(132, 58);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(100, 20);
            this.txtKitapYazar.TabIndex = 6;
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Location = new System.Drawing.Point(132, 92);
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(100, 20);
            this.txtKitapTuru.TabIndex = 7;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(111, 168);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 8;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.txtKitapTuru);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.listeVeri);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox listeVeri;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.Button btnKitapEkle;
    }
}

