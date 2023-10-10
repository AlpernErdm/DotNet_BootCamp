using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Alperen";
            musteri1.Soyadi = "Erdem";
            musteri1.TCNo = "12345212231";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2341";
            musteri2.SirketAdi = "Vbt";
            musteri2.VergiNo = "84832";

            Musteri musteri3 = new GercekMusteri(); //Müşteri hem tüzel hem gerçek classının bilgilerini tutuyor
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}