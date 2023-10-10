using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Individual:Bireysel 
    class GercekMusteri :Musteri  //İnheritance-->Müşteride olan proplar Gerçekmusteride de vardır  
    {
        
        public string TCNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
