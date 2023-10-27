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
    public partial class OgrenciTranskript : Form
    {
        public OgrenciTranskript()
        {
            InitializeComponent();
            Label label1 = new Label();
            if (OgrenciDersEkleme.secilenOgrenci != null)
            { label1.Text = OgrenciDersEkleme.secilenOgrenci.Ad + " " + OgrenciDersEkleme.secilenOgrenci.Soyad + "  " + OgrenciDersEkleme.secilenOgrenci.Numara;
            label1.Location = new Point(12, 9);
            label1.AutoSize = true; }
            this.Controls.Add(label1);

   




            foreach (var donem in OgrenciDersEkleme.SecilenDonemler)
            {
                FlowLayoutPanel flow = new FlowLayoutPanel() { FlowDirection = FlowDirection.TopDown, BorderStyle = BorderStyle.FixedSingle, Size= new Size(800,300)};
                Label label = new Label() { AutoSize = true, Text = donem.Isim };

                flow.Controls.Add(label);

                foreach (var item in donem.Ders)
                {
                    Label label2 = new Label() { AutoSize = true };
                    label2.Text = " Ders Kodu: " + item.Kod + "           Ders Adı:   " + item.Ad + "               Harf Notu: " + item.HarfNotu;
                    flow.Controls.Add(label2);
                }

                Label label3 = new Label() { AutoSize = true };
                label3.Text = $"Dönem Ortalaması:{transkriptHesapla(donem).ToString()}";
                flow.Controls.Add(label3);


                flpTranskript1.Controls.Add(flow);
            }
        }
        private double transkriptHesapla(Donem donem)
        {
            double toplamPuan = 0;
            double toplamKredi = 0;
            foreach (var item in donem.Ders)
            {
                double puan = item.Kredi * ((int)item.HarfNotu) / 100;
                toplamPuan += puan;
                toplamKredi += item.Kredi;
            }
            return toplamPuan / toplamKredi;

        }
    }

}

