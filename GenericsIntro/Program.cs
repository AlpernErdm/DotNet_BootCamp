using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList <string>(); //String yerine int  yazsam bu sefer method benden int ister yani T yazarsam herhangi bir değişken türünü kullanabilirim


            Console.WriteLine("Hello World!");
        }
    }
}
