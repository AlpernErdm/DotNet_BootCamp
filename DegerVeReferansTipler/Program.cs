using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal float double bool =değer tip(sayısal değerler genelde değer tip olur)
            //array class interface =referans tip
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;

            int[] Sayilar1 = new int[] { 10, 20, 30 };
            int[] Sayilar2 = new int[] { 100, 200, 300 };
            Sayilar1 = Sayilar2;
            Sayilar2[0] = 999;
            Console.WriteLine(Sayilar1[0]);
            Console.WriteLine(num1);
        }
    }
}
