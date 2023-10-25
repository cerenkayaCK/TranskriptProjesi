namespace TranskriptProjesi
{
    partial class OgrenciKayıtAnaform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            öğrenciKayıtEkranıToolStripMenuItem = new ToolStripMenuItem();
            öğrenciToolStripMenuItem = new ToolStripMenuItem();
            transkriptGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciDersEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrenciToolStripMenuItem, öğrenciKayıtEkranıToolStripMenuItem, öğrenciDersEkleToolStripMenuItem, transkriptGörüntüleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(537, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciKayıtEkranıToolStripMenuItem
            // 
            öğrenciKayıtEkranıToolStripMenuItem.Name = "öğrenciKayıtEkranıToolStripMenuItem";
            öğrenciKayıtEkranıToolStripMenuItem.Size = new Size(125, 20);
            öğrenciKayıtEkranıToolStripMenuItem.Text = "Öğrenci Kayıt Ekranı";
            öğrenciKayıtEkranıToolStripMenuItem.Click += öğrenciKayıtEkranıToolStripMenuItem_Click;
            // 
            // öğrenciToolStripMenuItem
            // 
            öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            öğrenciToolStripMenuItem.Size = new Size(66, 20);
            öğrenciToolStripMenuItem.Text = "Ders Ekle";
            öğrenciToolStripMenuItem.Click += öğrenciToolStripMenuItem_Click;
            // 
            // transkriptGörüntüleToolStripMenuItem
            // 
            transkriptGörüntüleToolStripMenuItem.Name = "transkriptGörüntüleToolStripMenuItem";
            transkriptGörüntüleToolStripMenuItem.Size = new Size(126, 20);
            transkriptGörüntüleToolStripMenuItem.Text = "Transkript Görüntüle";
            transkriptGörüntüleToolStripMenuItem.Click += transkriptGörüntüleToolStripMenuItem_Click;
            // 
            // öğrenciDersEkleToolStripMenuItem
            // 
            öğrenciDersEkleToolStripMenuItem.Name = "öğrenciDersEkleToolStripMenuItem";
            öğrenciDersEkleToolStripMenuItem.Size = new Size(111, 20);
            öğrenciDersEkleToolStripMenuItem.Text = "Öğrenci Ders Ekle";
            öğrenciDersEkleToolStripMenuItem.Click += öğrenciDersEkleToolStripMenuItem_Click;
            // 
            // OgrenciKayıtAnaform
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 304);
            Controls.Add(menuStrip1);
            Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "OgrenciKayıtAnaform";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrenciToolStripMenuItem;
        private ToolStripMenuItem transkriptGörüntüleToolStripMenuItem;
        private ToolStripMenuItem öğrenciKayıtEkranıToolStripMenuItem;
        private ToolStripMenuItem öğrenciDersEkleToolStripMenuItem;
    }
}