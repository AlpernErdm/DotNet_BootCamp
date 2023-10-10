using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager //interfaceler I harfiyle başlar
    {
        //İnterfacelerde o interfaceı implement eden classları referans edebilir 
        //Yani insteance oluştururken classın adı değilde interface'in adıyla oluşturabilirsin
         void Hesapla();
        void BiseyYap();
        
    }
}
