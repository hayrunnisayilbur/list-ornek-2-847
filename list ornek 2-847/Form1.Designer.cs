namespace list_ornek_2_847
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
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.txtKisiEkle = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSira = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnRemoveİleSilme = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnArtan = new System.Windows.Forms.Button();
            this.btnAzalan = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnOgrenciler = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBaslayan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.BackColor = System.Drawing.Color.OldLace;
            this.btnKisiEkle.Location = new System.Drawing.Point(53, 23);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(130, 32);
            this.btnKisiEkle.TabIndex = 0;
            this.btnKisiEkle.Text = "kişi ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = false;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // txtKisiEkle
            // 
            this.txtKisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiEkle.Location = new System.Drawing.Point(373, 22);
            this.txtKisiEkle.Name = "txtKisiEkle";
            this.txtKisiEkle.Size = new System.Drawing.Size(133, 29);
            this.txtKisiEkle.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(373, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 264);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(53, 61);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(130, 32);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSira
            // 
            this.btnSira.Location = new System.Drawing.Point(53, 99);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(130, 33);
            this.btnSira.TabIndex = 4;
            this.btnSira.Text = "kaçıncı sıra";
            this.btnSira.UseVisualStyleBackColor = true;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(53, 138);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 32);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "RemoveAt ile silme";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnRemoveİleSilme
            // 
            this.btnRemoveİleSilme.Location = new System.Drawing.Point(53, 176);
            this.btnRemoveİleSilme.Name = "btnRemoveİleSilme";
            this.btnRemoveİleSilme.Size = new System.Drawing.Size(130, 37);
            this.btnRemoveİleSilme.TabIndex = 6;
            this.btnRemoveİleSilme.Text = "Remove ile silme";
            this.btnRemoveİleSilme.UseVisualStyleBackColor = true;
            this.btnRemoveİleSilme.Click += new System.EventHandler(this.btnRemoveİleSilme_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(53, 219);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 33);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnArtan
            // 
            this.btnArtan.Location = new System.Drawing.Point(53, 258);
            this.btnArtan.Name = "btnArtan";
            this.btnArtan.Size = new System.Drawing.Size(130, 36);
            this.btnArtan.TabIndex = 8;
            this.btnArtan.Text = "artan sıralama";
            this.btnArtan.UseVisualStyleBackColor = true;
            this.btnArtan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAzalan
            // 
            this.btnAzalan.Location = new System.Drawing.Point(53, 300);
            this.btnAzalan.Name = "btnAzalan";
            this.btnAzalan.Size = new System.Drawing.Size(130, 31);
            this.btnAzalan.TabIndex = 9;
            this.btnAzalan.Text = "azalan sıralama";
            this.btnAzalan.UseVisualStyleBackColor = true;
            this.btnAzalan.Click += new System.EventHandler(this.btnAzalan_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(53, 337);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(130, 33);
            this.btnOgrenci.TabIndex = 10;
            this.btnOgrenci.Text = "5 harfli öğrenci";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.Location = new System.Drawing.Point(53, 377);
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.Size = new System.Drawing.Size(130, 42);
            this.btnOgrenciler.TabIndex = 11;
            this.btnOgrenciler.Text = "M harfli öğrenciler";
            this.btnOgrenciler.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(203, 22);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 33);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "kişileri temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBaslayan
            // 
            this.btnBaslayan.Location = new System.Drawing.Point(203, 62);
            this.btnBaslayan.Name = "btnBaslayan";
            this.btnBaslayan.Size = new System.Drawing.Size(128, 40);
            this.btnBaslayan.TabIndex = 13;
            this.btnBaslayan.Text = "A harfi ile başlayan öğrenciler";
            this.btnBaslayan.UseVisualStyleBackColor = true;
            this.btnBaslayan.Click += new System.EventHandler(this.btnBaslayan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(561, 479);
            this.Controls.Add(this.btnBaslayan);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOgrenciler);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnAzalan);
            this.Controls.Add(this.btnArtan);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnRemoveİleSilme);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKisiEkle);
            this.Controls.Add(this.btnKisiEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.TextBox txtKisiEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSira;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRemoveİleSilme;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnArtan;
        private System.Windows.Forms.Button btnAzalan;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnOgrenciler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBaslayan;
    }
}

