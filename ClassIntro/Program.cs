using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs(); //Aşağıdaki kurs classımdan bir nesne yarattım ve bu nesneyle o classtakı değişkenlere  ulaşabiliyorum
            kurs1.Egitmen = "Alperen Erdem";
            kurs1.izlenmeOran = 250;
            kurs1.kursAdi = "C# Geliştirme Kampı";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Adem Özalp";
            kurs2.izlenmeOran = 359;
            kurs2.kursAdi = "ASP.NET Geliştirme Kampı";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Caner On";
            kurs3.izlenmeOran = 120;
            kurs3.kursAdi = "Unit Test Geliştirme Kampı";
            //Console.WriteLine(kurs1.kursAdi + " :" + kurs1.Egitmen + " :" + "İzlenme Oranı :" + kurs1.izlenmeOran);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi +": " + kurs.Egitmen);
            }
            //Switch case Yapısı 
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Int32.Parse(Console.ReadLine());

            //switch (sayi)
            //{

            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;

            //    default: Console.WriteLine("Hata Böyle bir gün yok"); break;
            //}

            //Console.ReadLine();

            //While Döngüsü 

            //int i = 9;
            //while (i>2)
            //{
            //    Console.WriteLine(i);
            //    i--;

            //}


            Urun urun1 = new Urun();
            urun1.urunAd = "Samsung A32";
            urun1.urunFiyat = 12000;
            urun1.urunStok = 120;

            Urun urun2 = new Urun();
            urun2.urunAd = "Iphone 11";
            urun2.urunFiyat = 14500;
            urun2.urunStok = 80;

            Urun urun3 = new Urun();
            urun3.urunAd = "Huawei P40";
            urun3.urunFiyat = 15000;
            urun3.urunStok = 200;

            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

            Console.WriteLine("aşağıdaki foreach Döngüsü");
            foreach (var uruns in urunler)
            {
                Console.WriteLine(uruns.urunAd +" Fiyatı : "+ uruns.urunFiyat+" Stoğu  : "+uruns.urunStok);
            }
            Console.WriteLine("\naşağıdaki for Döngüsü");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAd +" "+ urunler[i].urunFiyat);
            }
            Console.WriteLine("\naşağıdaki while Döngüsü");
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].urunAd+ " " + urunler[j].urunFiyat);
                j++;
            }
        }
        class Kurs
        {
            public string kursAdi { get; set; }
            public string Egitmen { get; set; }
            public int izlenmeOran { get; set; }
        }

        class Urun
        {
            public string urunAd { get; set; }
            public int urunFiyat { get; set; }
            public int urunStok { get; set; }
        }
    }
}
