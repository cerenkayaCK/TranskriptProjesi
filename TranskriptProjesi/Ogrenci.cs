using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TranskriptProjesi
{
    public class Ogrenci
    {      
        public string? Ad { get; set; }
        public  string? Soyad { get; set; }
        public string? Numara { get; set; }
        public Donem donem{ get; set; }

        public override string ToString()
        {
            return Numara + " " + Ad + " " + Soyad;
        }
    }
}
