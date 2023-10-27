using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptProjesi
{
    public partial class OgrenciKayitEkrani : Form
    {
        public OgrenciKayitEkrani()
        {
            InitializeComponent();

            lstOgrenciler.Items.AddRange(Ogrenciler.ToArray());
        }

        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtOgrenciAd.Text;
            if (txtOgrenciAd.Text.Any(c => !char.IsLetter(c) && c != ' '))
            { MessageBox.Show("Geçersiz İsim!"); return; }
            ogrenci.Soyad = txtOgrenciSoyad.Text;
            if (txtOgrenciSoyad.Text.Any(c => !char.IsLetter(c) && c != ' '))
            { MessageBox.Show("Geçersiz Soyad!"); return; }
            ogrenci.Numara = txtOgrenciNumarasi.Text;
            if (txtOgrenciNumarasi.Text.Trim().Any(c => !char.IsDigit(c)))
            { MessageBox.Show("Yalnızca Sayı Girişi Yapınız!"); return; }
            else if (string.IsNullOrEmpty(txtOgrenciNumarasi.Text) || txtOgrenciNumarasi.Text.Contains(" "))
            { MessageBox.Show("Öğrenci No Boş Bırakılamaz."); return; }
            else if (txtOgrenciNumarasi.Text.Length != 10) { MessageBox.Show("Geçersiz numara girişi!"); return; }
            foreach (var item in Ogrenciler)
            {
                if (item.Numara.Contains(txtOgrenciNumarasi.Text)) { MessageBox.Show("Bu numaraya sahip bir öğrenci var!"); return; }
                else MessageBox.Show("Öğrenci Eklendi");
            }
            Ogrenciler.Add(ogrenci);
            OgrencileriListele();
            lstOgrenciler.SelectedItem = ogrenci;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedItem == null)
                MessageBox.Show("silinecek öğrenciyi seçiniz.");
            else
            {
                int i = lstOgrenciler.SelectedIndex;
                DialogResult dr = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Ogrenci silinecekOgrenci = (Ogrenci)lstOgrenciler.SelectedItem;
                    lstOgrenciler.Items.Remove(silinecekOgrenci);
                    Ogrenciler.Remove(silinecekOgrenci);
                    OgrencileriListele();
                    lstOgrenciler.SelectedIndex = Math.Min(i, lstOgrenciler.Items.Count - 1);
                }

            }
        }

        private void OgrencileriListele()
        {
            lstOgrenciler.Items.Clear();
            foreach (var item in Ogrenciler)
            {
                lstOgrenciler.Items.Add(item);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Düzenlemek İstediğiniz öğrenciyi Seçiniz.");
                return;
            }

            Ogrenci duzenlenecekOgrenci = (Ogrenci)lstOgrenciler.SelectedItem;
            DuzenlemeFormu duzenle = new DuzenlemeFormu(duzenlenecekOgrenci);
            duzenle.ShowDialog(); //duzenlendi
            OgrencileriListele(); //tekrar listeleme yapılmalıdır.
            lstOgrenciler.SelectedItem = duzenlenecekOgrenci;

        }

    }
}