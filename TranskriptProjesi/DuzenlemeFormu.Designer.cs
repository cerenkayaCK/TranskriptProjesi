namespace TranskriptProjesi
{
    partial class DuzenlemeFormu
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
            txtOgrenciNumarasi = new TextBox();
            txtOgrenciSoyad = new TextBox();
            txtOgrenciAd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnKaydet = new Button();
            label1 = new Label();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // txtOgrenciNumarasi
            // 
            txtOgrenciNumarasi.Location = new Point(163, 133);
            txtOgrenciNumarasi.Margin = new Padding(4);
            txtOgrenciNumarasi.Name = "txtOgrenciNumarasi";
            txtOgrenciNumarasi.Size = new Size(113, 23);
            txtOgrenciNumarasi.TabIndex = 23;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(163, 94);
            txtOgrenciSoyad.Margin = new Padding(4);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(113, 23);
            txtOgrenciSoyad.TabIndex = 22;
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(163, 53);
            txtOgrenciAd.Margin = new Padding(4);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(113, 23);
            txtOgrenciAd.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(44, 136);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 20;
            label4.Text = "Numarası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(44, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 19;
            label3.Text = "Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(44, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 18;
            label2.Text = "Adı:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(44, 174);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(232, 27);
            btnKaydet.TabIndex = 24;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 25;
            label1.Text = "Öğrenci Bilgileri";
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(183, 218);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(93, 23);
            btnIptal.TabIndex = 26;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // DuzenlemeFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 253);
            Controls.Add(btnIptal);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(txtOgrenciNumarasi);
            Controls.Add(txtOgrenciSoyad);
            Controls.Add(txtOgrenciAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "DuzenlemeFormu";
            Text = "DuzenlemeFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOgrenciNumarasi;
        private TextBox txtOgrenciSoyad;
        private TextBox txtOgrenciAd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnKaydet;
        private Label label1;
        private Button btnIptal;
    }
}