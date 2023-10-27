using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptProjesi
{
    public class Donem
    {
        public string Isim { get; set; }
        public List<Ders> Ders{ get; set; }

        public override string ToString()
        {
            return Isim;
        }



    }
}
