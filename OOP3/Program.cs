using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            //başvuru yap metodunun parametresini interface'e verdiğimiz için 
            //o interface'i implement eden her classı referans olarak kullanabiliriz ve hata almayız
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager); //bu sayede bütün kredileri hata almadan basvuru yapta kullanabiliyoruz
            basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);//oluşturduğumuz listteki verileri basvurumanagerdan çağırdıgımız metotta kullandık

        }
    }
}
