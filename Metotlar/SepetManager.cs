using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi :"+product.urunAdi);

        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat, int stok)
        {
            Console.WriteLine("Sepete eklendi :" +urunAdi);
        }
    }
}
