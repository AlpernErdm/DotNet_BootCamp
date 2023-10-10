using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorparate:Tüzel
    class TuzelMusteri : Musteri   //İnheritance-->Müşteride olan proplar Tüzelmusteride de vardır  
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
