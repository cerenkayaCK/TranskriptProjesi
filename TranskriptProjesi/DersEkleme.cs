using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptProjesi
{
    public partial class DersEkleme : Form
    {
        public DersEkleme()
        {
            InitializeComponent();
            lstDersler.Items.AddRange(Dersler.ToArray());  // DERSLERİ lstDersler.Items.Add(ders) olarak atınca çalışıyor. 
        }

        public static List<Ders> Dersler = new List<Ders>();


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            if(txtDers.Text.Any(c => !char.IsLetter(c) && c != ' '))
            { MessageBox.Show("Ders adı yalnızca harf içermelidir.!"); return; }
            else if (string.IsNullOrEmpty(txtDers.Text))
            { MessageBox.Show("Lütfen bir ders giriniz."); return; }
            ders.Ad = txtDers.Text.Trim();

            if (!txtKod.Text.StartsWith("MIMFA")) { MessageBox.Show("DERS KODUNUZ 'MIMFA' İLE BAŞLAMALIDIR."); return; }
            else if (txtKod.Text.Length != 7) { MessageBox.Show("DERS KODU YANLIŞ GİRİLDİ!"); return; }
            else if (string.IsNullOrEmpty(txtKod.Text)) { MessageBox.Show("LÜTFEN DERS KODUNU GİRİNİZ!"); return; }

            ders.Kod = txtKod.Text;

            if (Convert.ToDouble(txtKredi.Text) > 8) { MessageBox.Show("KREDİ EN FAZLA 8 OLABİLİR!"); return; }
            else if (string.IsNullOrEmpty(txtKredi.Text)) { MessageBox.Show("LÜTFEN DERS KREDİSİNİ GİRİNİZ!"); return; }

            ders.Kredi = Convert.ToDouble(txtKredi.Text);

            Dersler.Add(ders);
            DersleriListele();


        }
        private void DersleriListele()
        {
            lstDersler.Items.Clear();
            foreach (var item in Dersler)
            {
                lstDersler.Items.Add(item);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDersler.SelectedItem != null)
            {
                Dersler.Remove((Ders)lstDersler.SelectedItem);
                DersleriListele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ders duzenlenecekDers = (Ders)lstDersler.SelectedItem;
            if (duzenlenecekDers == null) { MessageBox.Show("Lütfen düzenlenecek dersi seçiniz <3"); return; }
            DersDuzenle duzenlemeForm = new DersDuzenle(duzenlenecekDers);
            duzenlemeForm.ShowDialog();
            DersleriListele();



        }
    }
}
