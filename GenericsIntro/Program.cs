using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList <string>(); //String yerine int  yazsam bu sefer method benden int ister yani T yazarsam herhangi bir değişken türünü kullanabilirim
            isimler.Add("Alperen");
            Console.WriteLine(isimler.Length);
            isimler.Add("enes");
            Console.WriteLine(isimler.Length);


            Console.WriteLine("Hello World!");
        }
    }
}
