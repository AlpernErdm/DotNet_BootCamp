using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musterıEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi :" + musteri.musteriAd);
        }
        public void musteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi !!" + musteri.musteriAd);
        }
        public void musteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler listedeki gibidir "+musteri.musteriAd + musteri.musteriSoyad);
        }
    }
}
