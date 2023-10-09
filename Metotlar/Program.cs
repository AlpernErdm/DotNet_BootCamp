using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.urunAdi = "Makarna";
            product1.urunFiyat = 75;
            product1.Aciklama = "Köri Soslu Tavuk";

            Product product2 = new Product();
            product2.urunAdi = "Tavuk";
            product2.urunFiyat = 120;
            product2.Aciklama = "Ballı Hardallı Tavuk";

            Product product3 = new Product();
            product3.urunAdi = "Et";
            product3.urunFiyat = 175;
            product3.Aciklama = "Antrikot";

            Product[] products = new Product[] {product1,product2,product3 };

            foreach (var urunler in products) //var kendimizinverdiğiad in arrayname
            {
                Console.WriteLine(urunler.urunAdi);
                Console.WriteLine(urunler.urunFiyat + "TL ");
                Console.WriteLine(urunler.Aciklama);
                Console.WriteLine("***********************");
               
            }
            Console.WriteLine("----------Metotlar-------------");
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            Console.WriteLine("***********************************************");
            sepetManager.Ekle2("Iphone 12", "Renk: Beyaz 128 GB", 25000,10);
            sepetManager.Ekle2("Iphone 13", "Renk: Siyah 128 GB", 30000,9);
            sepetManager.Ekle2("Iphone 14", "Renk: Zümrüt 128 GB", 35000,20);

        }
    }
}
