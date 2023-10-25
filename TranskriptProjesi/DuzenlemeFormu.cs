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
    public partial class DuzenlemeFormu : Form
    {
        private readonly Ogrenci duzenlenecekOgrenci;
        public DuzenlemeFormu(Ogrenci ogrenci)
        {
            InitializeComponent();

            duzenlenecekOgrenci = ogrenci;
            txtOgrenciAd.Text = ogrenci.Ad;
            txtOgrenciSoyad.Text = ogrenci.Soyad;
            txtOgrenciNumarasi.Text = ogrenci.Numara;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtOgrenciAd.Text.Trim();
            string soyad = txtOgrenciSoyad.Text.Trim();
            string numara = txtOgrenciNumarasi.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) ){ MessageBox.Show("ad veya soyad boş bırakılamaz."); return; }

            duzenlenecekOgrenci.Ad= ad;
            duzenlenecekOgrenci.Soyad= soyad;
            duzenlenecekOgrenci.Numara = numara;
            Close();
          }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
