using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 01;
            musteri.musteriAd = "Alperen";
            musteri.musteriSoyad = "Erdem";
            musteri.sepetTutar = 1250;
            musteri.telNo = 0505050505;
            musteri.Cinsiyet = "Erkek";

            Musteri musteri1 = new Musteri();
            musteri1.Id = 01;
            musteri1.musteriAd = "Enes";
            musteri1.musteriSoyad = "Erdem";
            musteri1.sepetTutar = 1750;
            musteri1.telNo = 0505050505;
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 01;
            musteri2.musteriAd = "Mehmet";
            musteri2.musteriSoyad = "Erdem";
            musteri2.sepetTutar = 1750;
            musteri2.telNo = 0505050505;
            musteri2.Cinsiyet = "Erkek";

            Musteri[] musteriList = new Musteri[] {musteri,musteri1,musteri2 };
            foreach (var musteriler in musteriList)
            {
                Console.WriteLine("Müşteriler listedeki gibidir "+musteriler.musteriAd+ musteriler.musteriSoyad);
               
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musterıEkleme(musteri);
            musteriManager.musteriSilme(musteri);
            musteriManager.musteriListele(musteri1);
            



        }
    }
}
