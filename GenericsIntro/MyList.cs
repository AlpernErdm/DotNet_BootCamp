using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> //Generics de T Type anlamına gelir ve herhangi bir değişken türünü main sınıfta verebiliriz
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];  //cons methodla arrayı newledık ve 0 elemanlı bir array oluşturduk
        }
        public void Add(T item)//method her çalıştığında newlenecek ve eleman sayısı 1 artacak
        {
            T[] tempArray = items; //geçiçci olarak cons methoda referans verdik verinin kaybolma şansı ortadan kayboldu
            items = new T[items.Length+1];//burda ise yeni eleman eklemek işini yaptık ve
                                          //sayı vermedğimiz için dizinin eleman sayısını 1 artırıyor
            for (int i = 0; i < items.Length; i++)
            {
                items[0] = tempArray[0];
            }
            items[items.Length - 1] = item; //işte eleman ekleme işlemi burda oluyor
        }
    }
}
