using System;

namespace OdevMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20);
            Console.WriteLine(result);
            Add2(20, 30);
            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Multiply(2, 5, 10));

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine(Add3(ref num1,num2));
        }
        static void Add()
        {
            Console.WriteLine("Added !");
        }
        static int Add2(int num1,int num2=30)//burda herhangi bir değer verilmezse default olarak 30 atıyoruz
            //default değerler en sağda olmalıdır yoksa hata alırız 
            //static void yapsaydık geriye bişi döndüremezdik o yüzden static int yaptık 
        {
            var result = num1 + num2;
            return result;
           
        }
        static int Add3(ref int num1,int num2) // -->ref keyword
        {
            num1 = 40;
            return num1 + num2;
        }
        
        static int Multiply(int num1,int num2)
        {
            return num1 * num2; ;
        }
        static int Multiply(int num1, int num2,int num3) // -->Method Overloading :Aynı method ismi fakat içerdikleri parametreler farklı
        {
            return num1 * num2*num3 ;
        }
    }
}
