using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Policy;

namespace TranskriptProjesi
{
    public partial class OgrenciDersEkleme : Form
    {
        static public List<Donem> Donemler = new List<Donem>()
        {
           new Donem{ Isim= "1.Sınıf Güz Dönemi" },
           new Donem{ Isim= "1.Sınıf Bahar Dönemi"},
           new Donem{ Isim= "2.Sınıf Güz Dönemi" },
           new Donem{ Isim= "2.Sınıf Bahar Dönemi"},
           new Donem{ Isim= "3.Sınıf Güz Dönemi" },
           new Donem{ Isim= "3.Sınıf Bahar Dönemi"},
           new Donem{ Isim= "4.Sınıf Güz Dönemi" },
           new Donem{ Isim= "4.Sınıf Bahar Dönemi"}
        };

        static public List<Donem> SecilenDonemler = new List<Donem>();
        static public Ogrenci? secilenOgrenci;
        static public Ders? selectedDers;
        public OgrenciDersEkleme()
        {
            InitializeComponent();
            Ders selectedDers = null; // varsayılan olarak null
            Donem secilenDonem = null; // varsayılan olarak null
            foreach (var item in OgrenciKayitEkrani.Ogrenciler)
            {
                cboOgrenciSec.Items.Add(item);
            }

            foreach (var item in DersEkleme.Dersler)
            {
                cboDersSec.Items.Add(item);
            }

            foreach (var item in Donemler)
            {
                cboDonem.Items.Add(item);
            }

            var harfNotuList = Enum.GetValues(typeof(HarfNotu)).Cast<HarfNotu>().ToList();
            cboHarf.DataSource = harfNotuList;
            cboHarf.SelectedIndex = -1;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            secilenOgrenci = (Ogrenci)cboOgrenciSec.SelectedItem;
            Donem secilenDonem = (Donem)cboDonem.SelectedItem;

            if (secilenOgrenci != null)
            {
                secilenOgrenci.donem = secilenDonem;
            }

            if (secilenDonem != null)
            {
                if (secilenDonem.Ders == null)
                {
                    secilenDonem.Ders = new List<Ders>();
                }

                selectedDers = (Ders)cboDersSec.SelectedItem;


                if (!secilenDonem.Ders.Contains(selectedDers))
                {
                    secilenDonem.Ders.Add(selectedDers);
                }
                else
                {
                    MessageBox.Show("Bu ders zaten ekli.");
                    return; // Exit the method to prevent further execution.
                }

                if (!SecilenDonemler.Contains(secilenDonem))
                    SecilenDonemler.Add(secilenDonem);

            }
            else
            {
                MessageBox.Show("Lütfen bir dönem seçiniz.");
            }

            HarfNotu secilenNot = (HarfNotu)cboHarf.SelectedItem;
            selectedDers.HarfNotu = secilenNot;

            MessageBox.Show("Ekleme başarılı");

        }

    }
}
