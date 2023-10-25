namespace TranskriptProjesi
{
    public partial class OgrenciKayýtAnaform : Form
    {
        public OgrenciKayýtAnaform()
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

        private void öðrenciKayýtEkranýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciKayitEkrani());
        }

        private void öðrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkleme());
        }

        private void transkriptGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciTranskript());
        }

        private void öðrenciDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciDersEkleme());
        }
    }
}