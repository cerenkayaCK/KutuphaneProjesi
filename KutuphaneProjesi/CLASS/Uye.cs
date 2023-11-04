using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi.CLASS
{
    public class Uye
    {
        public Uye(string TCKN)
        {
            this.TCKN = TCKN;
        }
        public string TCKN { get; set; }
        public List<Kitap> OduncAlinanKitap { get; set; } = new List<Kitap>();

        public override string ToString()
        {
            return TCKN;
        }



    }
}
