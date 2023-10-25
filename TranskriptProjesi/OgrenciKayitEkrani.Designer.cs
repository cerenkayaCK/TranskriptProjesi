namespace TranskriptProjesi
{
    partial class OgrenciKayitEkrani
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
            btnGuncelle = new Button();
            btnSil = new Button();
            lstOgrenciler = new ListBox();
            btnEkle = new Button();
            txtOgrenciNumarasi = new TextBox();
            txtOgrenciSoyad = new TextBox();
            txtOgrenciAd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(322, 231);
            btnGuncelle.Margin = new Padding(4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(89, 27);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(418, 231);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(73, 27);
            btnSil.TabIndex = 20;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.ItemHeight = 15;
            lstOgrenciler.Location = new Point(323, 48);
            lstOgrenciler.Margin = new Padding(4);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(175, 169);
            lstOgrenciler.TabIndex = 19;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(42, 231);
            btnEkle.Margin = new Padding(4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(233, 27);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtOgrenciNumarasi
            // 
            txtOgrenciNumarasi.Location = new Point(162, 167);
            txtOgrenciNumarasi.Margin = new Padding(4);
            txtOgrenciNumarasi.Name = "txtOgrenciNumarasi";
            txtOgrenciNumarasi.Size = new Size(113, 23);
            txtOgrenciNumarasi.TabIndex = 17;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(162, 128);
            txtOgrenciSoyad.Margin = new Padding(4);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(113, 23);
            txtOgrenciSoyad.TabIndex = 16;
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(162, 87);
            txtOgrenciAd.Margin = new Padding(4);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(113, 23);
            txtOgrenciAd.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(43, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 14;
            label4.Text = "Numarası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(43, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 13;
            label3.Text = "Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(43, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 12;
            label2.Text = "Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(43, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 11;
            label1.Text = "Öğrenci Kayıt Ekranı";
            // 
            // OgrenciKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 304);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(lstOgrenciler);
            Controls.Add(btnEkle);
            Controls.Add(txtOgrenciNumarasi);
            Controls.Add(txtOgrenciSoyad);
            Controls.Add(txtOgrenciAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciKayitEkrani";
            Text = "OgrenciKayitEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnSil;
        private ListBox lstOgrenciler;
        private Button btnEkle;
        private TextBox txtOgrenciNumarasi;
        private TextBox txtOgrenciSoyad;
        private TextBox txtOgrenciAd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}