using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays-Diziler-For
            string[] kurslar = new string[] { "C# Yazılım Geliştirme Kampı", "Junior C# Geliştirme Kampı", "Senior C# Geliştirme Kampı",
                
                "Mid C# Geliştirme Kampı" };

            Console.WriteLine("For Döngüsü İle");
            for (int i =0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Foreach Döngüsü İle");

            //Foreach Loop =Dizi temelli yapıları tek tek dönmeye yarar
            Console.WriteLine("Foreach Döngüsü İle ");
            foreach (string kurs in kurslar) //kurs kendimizin verdiği döngüde kullanmak için bir değişken 
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
