using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptProjesi
{
    public partial class OgrenciKayitEkrani : Form
    {
        public OgrenciKayitEkrani()
        {
            InitializeComponent();
        }

        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtOgrenciAd.Text;
            ogrenci.Soyad = txtOgrenciSoyad.Text;
            ogrenci.Numara = txtOgrenciNumarasi.Text;
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