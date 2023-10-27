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
            if (txtOgrenciAd.Text.Any(c => !char.IsLetter(c) && c != ' '))
            { MessageBox.Show("Geçersiz İsim!"); return; }
            if (txtOgrenciSoyad.Text.Any(c => !char.IsLetter(c) && c != ' '))
            { MessageBox.Show("Geçersiz Soyad!"); return; }
            if (txtOgrenciNumarasi.Text.Trim().Any(c => !char.IsDigit(c)))
            { MessageBox.Show("Yalnızca Sayı Girişi Yapınız!"); return; }
            else if (string.IsNullOrEmpty(txtOgrenciNumarasi.Text) || txtOgrenciNumarasi.Text.Contains(" "))
            { MessageBox.Show("Öğrenci No Boş Bırakılamaz."); return; }
            else if (txtOgrenciNumarasi.Text.Length != 10) { MessageBox.Show("Geçersiz numara girişi!"); return; }
            foreach (var item in OgrenciKayitEkrani.Ogrenciler)
            {
                if (item.Numara != null)
                {
                    if (item.Numara.Contains(txtOgrenciNumarasi.Text) && (!(item.Numara == txtOgrenciNumarasi.Text)))
                    { MessageBox.Show("Bu numaraya sahip bir öğrenci var!"); return; }
                    MessageBox.Show("Öğrenci Güncellendi");                   
                }
            }
            duzenlenecekOgrenci.Ad = ad;
            duzenlenecekOgrenci.Soyad = soyad;
            duzenlenecekOgrenci.Numara = numara;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


