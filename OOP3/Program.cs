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
            ILoggerService loggerService = new DatabaseLoggerService();
            ILoggerService loggerService1 = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,loggerService);//loggerservice1 de kullanabilirdik
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggerService);//Esnaf kredisini metotun içinde new ledik insteance oluşturmadan
            //bu sayede bütün kredileri hata almadan basvuru yapta kullanabiliyoruz ihtiyac yerıne konutveya taşıt da yazabiliriz
            basvuruManager.BasvuruYap(tasitKrediManager, loggerService1);
            basvuruManager.BasvuruYap(konutKrediManager, new SmsLoggerManager()); //smsloggerı metotun içinde new ledik insteance oluşturmadan



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);//oluşturduğumuz listteki verileri basvurumanagerdan çağırdıgımız metotta kullandık

        }
    }
}
