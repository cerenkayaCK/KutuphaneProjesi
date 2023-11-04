using KutuphaneProjesi.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi.CLASS
{
    public class Kitap
    {
        public Kitap()
        {
            
        }
        public Kitap(string _isim,Tur KitapCesidi)
        {
            İsim = _isim;
            this.KitapCesidi = KitapCesidi;
        }
        public string İsim{ get; set; }
        public Tur KitapCesidi { get; set; }

        public string Yazar { get; set; }

        public int SayfaSayisi { get; set; }


        public override string ToString()
        {
            return İsim;
        }


    }
}
