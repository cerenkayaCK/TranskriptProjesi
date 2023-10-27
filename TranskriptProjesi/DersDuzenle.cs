using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptProjesi
{
    public partial class DersDuzenle : Form
    {
        private Ders duzenlenecekDers;
        public DersDuzenle(Ders ders)
        {
            InitializeComponent();
          
            duzenlenecekDers = ders;   
            txtDersAd.Text = ders.Ad;
            txtDersKod.Text = ders.Kod;
            txtDersKredi.Text = Convert.ToString(ders.Kredi);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtDersAd.Text.Trim();
            if (txtDersAd.Text.Any(c => !char.IsLetter(c) && c != ' '))
            { MessageBox.Show("Ders adı yalnızca harf içermelidir.!"); return; }
            else if (string.IsNullOrEmpty(txtDersAd.Text))
            { MessageBox.Show("Lütfen bir ders giriniz."); return; }
            string kod = txtDersKod.Text.Trim();
            if (!txtDersKod.Text.StartsWith("MIMFA")) { MessageBox.Show("DERS KODUNUZ 'MIMFA' İLE BAŞLAMALIDIR."); return; }
            else if (txtDersKod.Text.Length != 7) { MessageBox.Show("DERS KODU YANLIŞ GİRİLDİ!"); return; }
            else if (string.IsNullOrEmpty(txtDersKod.Text)) { MessageBox.Show("LÜTFEN DERS KODUNU GİRİNİZ!"); return; }

            double kredi = Convert.ToDouble(txtDersKredi.Text.Trim());
            if (Convert.ToDouble(txtDersKredi.Text) > 8) { MessageBox.Show("KREDİ EN FAZLA 8 OLABİLİR!"); return; }
            else if (string.IsNullOrEmpty(txtDersKredi.Text)) { MessageBox.Show("LÜTFEN DERS KREDİSİNİ GİRİNİZ!"); return; }

            duzenlenecekDers.Ad = ad;
            duzenlenecekDers.Kod = kod;
            duzenlenecekDers.Kredi = kredi;

            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
