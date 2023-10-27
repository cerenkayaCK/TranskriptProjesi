namespace TranskriptProjesi
{
    partial class DersDuzenle
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
            btnIptal = new Button();
            label1 = new Label();
            btnKaydet = new Button();
            txtDersKredi = new TextBox();
            txtDersKod = new TextBox();
            txtDersAd = new TextBox();
            label4 = new Label();
            lblKod = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(188, 238);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(93, 23);
            btnIptal.TabIndex = 35;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 34;
            label1.Text = "Ders Bilgileri";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(49, 194);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(232, 27);
            btnKaydet.TabIndex = 33;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtDersKredi
            // 
            txtDersKredi.Location = new Point(168, 153);
            txtDersKredi.Margin = new Padding(4);
            txtDersKredi.Name = "txtDersKredi";
            txtDersKredi.Size = new Size(113, 23);
            txtDersKredi.TabIndex = 32;
            // 
            // txtDersKod
            // 
            txtDersKod.Location = new Point(168, 114);
            txtDersKod.Margin = new Padding(4);
            txtDersKod.Name = "txtDersKod";
            txtDersKod.Size = new Size(113, 23);
            txtDersKod.TabIndex = 31;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(168, 73);
            txtDersAd.Margin = new Padding(4);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(113, 23);
            txtDersAd.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(49, 156);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 29;
            label4.Text = "Kod";
            // 
            // lblKod
            // 
            lblKod.AutoSize = true;
            lblKod.BackColor = Color.Transparent;
            lblKod.Location = new Point(49, 114);
            lblKod.Margin = new Padding(4, 0, 4, 0);
            lblKod.Name = "lblKod";
            lblKod.Size = new Size(28, 15);
            lblKod.TabIndex = 28;
            lblKod.Text = "Kod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(49, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 27;
            label2.Text = "Ad";
            // 
            // DersDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 308);
            Controls.Add(btnIptal);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(txtDersKredi);
            Controls.Add(txtDersKod);
            Controls.Add(txtDersAd);
            Controls.Add(label4);
            Controls.Add(lblKod);
            Controls.Add(label2);
            Name = "DersDuzenle";
            Text = "DersDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIptal;
        private Label label1;
        private Button btnKaydet;
        private TextBox txtDersKredi;
        private TextBox txtDersKod;
        public TextBox txtDersAd;
        private Label label4;
        private Label lblKod;
        private Label label2;
    }
}