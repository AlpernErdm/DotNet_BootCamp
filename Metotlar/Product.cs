using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Product
    {
        //Bunların herbiri bir property
        public int Id { get; set; }
        public string urunAdi { get; set; }
        public double urunFiyat { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }
    }
}
