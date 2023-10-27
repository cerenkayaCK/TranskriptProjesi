namespace TranskriptProjesi
{
    partial class DersEkleme
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
            label1 = new Label();
            txtDers = new TextBox();
            label2 = new Label();
            txtKod = new TextBox();
            txtKredi = new TextBox();
            label3 = new Label();
            lstDersler = new ListBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Ders ";
            // 
            // txtDers
            // 
            txtDers.Location = new Point(57, 20);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(129, 23);
            txtDers.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Kod";
            // 
            // txtKod
            // 
            txtKod.Location = new Point(57, 63);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(129, 23);
            txtKod.TabIndex = 3;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(57, 102);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(129, 23);
            txtKredi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Kredi";
            // 
            // lstDersler
            // 
            lstDersler.FormattingEnabled = true;
            lstDersler.ItemHeight = 15;
            lstDersler.Location = new Point(205, 20);
            lstDersler.Name = "lstDersler";
            lstDersler.Size = new Size(177, 229);
            lstDersler.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 152);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(174, 29);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(12, 201);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 43);
            btnSil.TabIndex = 8;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(109, 201);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(77, 43);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // DersEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 272);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstDersler);
            Controls.Add(label3);
            Controls.Add(txtKredi);
            Controls.Add(txtKod);
            Controls.Add(label2);
            Controls.Add(txtDers);
            Controls.Add(label1);
            Name = "DersEkleme";
            Text = "DersEkleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        public TextBox txtDers;
        public TextBox txtKod;
        public TextBox txtKredi;
        public ListBox lstDersler;
    }
}