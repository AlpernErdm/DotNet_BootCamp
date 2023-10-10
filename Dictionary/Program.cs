using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
            MyDictionary.Add("Dzeko Gol Sayısı", 6);
            MyDictionary.Add("Szymanski Gol Sayısı", 8);
            MyDictionary.Add("Tadic Gol Sayısı", 5);
            MyDictionary.Add("King Gol Sayısı", 3);

            Console.WriteLine("MyDictionary");
            foreach (var item in MyDictionary)
            {
                Console.WriteLine("Oyuncu: {0} - Gol Sayısı: {1} " , item.Key, item.Value);
            }
            Console.WriteLine("\n");

            Dictionary<string, int> cities = new Dictionary<string, int>();
            cities.Add("Ankara", 06);
            cities.Add("İstanbul", 34);
            cities.Add("Kırşehir", 40);

            foreach (var item in cities)
            {
                Console.WriteLine("Şehir Adı: {0} -Plaka Kodu : {1}",item.Key,item.Value);
            }
            

        }
    }
}
