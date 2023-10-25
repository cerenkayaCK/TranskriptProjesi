namespace TranskriptProjesi
{
    public partial class OgrenciKay�tAnaform : Form
    {
        public OgrenciKay�tAnaform()
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

        private void ��renciKay�tEkran�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciKayitEkrani());
        }

        private void ��renciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkleme());
        }

        private void transkriptG�r�nt�leToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciTranskript());
        }

        private void ��renciDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciDersEkleme());
        }
    }
}