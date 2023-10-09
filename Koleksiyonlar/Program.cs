using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Alperen","Adem","Caner" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]); //bu şekilde array oluşturursak sonradan ekleme yapamayız bu yüzden list yapısını kullanmalıyız
            isimler[3] = "İlker";
            //Console.WriteLine(isimler[3]); Hata verir kod çalışmaz

            List<string> isimler2 = new List<string>();
            isimler2.Add("Ahmet");
            //Veya bu şeklide list oluşturulur ...
            List<string> isimler3 = new List<string> {"Ahmet","Mehmet","Hasan" };
            Console.WriteLine(isimler3[0]);         
            Console.WriteLine(isimler3[1]);         
            Console.WriteLine(isimler3[2]);
            isimler3.Add("Fırfır");         //List yapısında sonradan elemean ekleyebiliriz 
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);
        }
    }
}
