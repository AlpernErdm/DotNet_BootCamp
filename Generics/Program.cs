using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            MyList<string> cities = new MyList <string>();//int yazarsak aşağısıda otomatik int oluyor
            cities.Add("Ankara");

        }
        class MyList<T> //Generic type 
        {
            public void Add(T item) //Yukarda Myliste string atadıgımız için T nin içine de string atanmış oluyor
                //Yani burdaki T bizim gönderdiğimiz tip oluyor
            {
                Console.WriteLine("Eleman eklendi");
            }
        }
    }
}
