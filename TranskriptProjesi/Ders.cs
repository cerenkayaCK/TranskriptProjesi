using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptProjesi
{
    public class Ders
    {
        public string Ad { get; set; }

        public string Kod { get; set; }

        public double Kredi {  get; set; }

        public HarfNotu HarfNotu { get; set; }

        public override string ToString()
        {
            return Ad + ", " + Kod+ ", "+Kredi.ToString();
        }
    }
}
