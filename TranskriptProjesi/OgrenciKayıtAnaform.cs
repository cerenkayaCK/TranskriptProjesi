namespace TranskriptProjesi
{
    public partial class OgrenciKayıtAnaform : Form
    {
        public OgrenciKayıtAnaform()
        {
            InitializeComponent();
            
        }

        public void FormGoster(Form secilenForm)
        {
            secilenForm.StartPosition = 0;
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show();
                }
                else
                {
                    form.Close();
                }
            }
            if (!durum)
            {

                secilenForm.MdiParent = this;
                secilenForm.Show();
            }

        }

        private void öğrenciKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciKayitEkrani());
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkleme());                                                                    
        }

        private void transkriptGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciTranskript());
        }

        private void öğrenciDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciDersEkleme());
        }
    }
}