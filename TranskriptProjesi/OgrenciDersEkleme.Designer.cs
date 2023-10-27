namespace TranskriptProjesi
{
    partial class OgrenciDersEkleme
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
            cboOgrenciSec = new ComboBox();
            cboHarf = new ComboBox();
            cboDonem = new ComboBox();
            cboDersSec = new ComboBox();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cboOgrenciSec
            // 
            cboOgrenciSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOgrenciSec.FormattingEnabled = true;
            cboOgrenciSec.Location = new Point(110, 75);
            cboOgrenciSec.Name = "cboOgrenciSec";
            cboOgrenciSec.Size = new Size(121, 23);
            cboOgrenciSec.TabIndex = 0;
            // 
            // cboHarf
            // 
            cboHarf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHarf.FormattingEnabled = true;
            cboHarf.Location = new Point(275, 134);
            cboHarf.Name = "cboHarf";
            cboHarf.Size = new Size(121, 23);
            cboHarf.TabIndex = 1;
            // 
            // cboDonem
            // 
            cboDonem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonem.FormattingEnabled = true;
            cboDonem.Location = new Point(110, 134);
            cboDonem.Name = "cboDonem";
            cboDonem.Size = new Size(121, 23);
            cboDonem.TabIndex = 2;
            cboDonem.Tag = "Donem";
            // 
            // cboDersSec
            // 
            cboDersSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDersSec.FormattingEnabled = true;
            cboDersSec.Location = new Point(275, 75);
            cboDersSec.Name = "cboDersSec";
            cboDersSec.Size = new Size(121, 23);
            cboDersSec.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(110, 183);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(286, 33);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 57);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Ders ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Öğrenci";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Harf Notu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 116);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Dönem";
            // 
            // OgrenciDersEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 304);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(cboDersSec);
            Controls.Add(cboDonem);
            Controls.Add(cboHarf);
            Controls.Add(cboOgrenciSec);
            Name = "OgrenciDersEkleme";
            Text = "Öğrenci-Puan-Ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboHarf;
        private ComboBox cboDonem;
        private ComboBox cboDersSec;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public ComboBox cboOgrenciSec;
    }
}