using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -tip güvenliği
            //Don't repeat yourself

            //Variable
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 1500;
            double faizOran = 1.32;
            bool sistemGiris = true;
            double dolarDun = 26.45;
            double dolarBugun = 26.50;
            

            //Conditional
            if (sistemGiris==true)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else 
            {
                Console.WriteLine("Sisteme giriş yapılamadı");
            }

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar yükseldi");
            }
            else if (dolarBugun==dolarDun)
            {
                Console.WriteLine("Dolar sabit kaldı");
            }
            else
            {
                Console.WriteLine("Dolar düşmüş");
            }
           
        }
    }
}
