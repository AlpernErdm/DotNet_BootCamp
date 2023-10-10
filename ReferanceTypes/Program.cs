using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal float double boolen enum değer tip olarak geçer ve stackde tutulur heape geçmez
            int num1 = 10;
            int num2 = 20;
            num1 = num2;
            num2 = 100;
            Console.WriteLine(num1);

            //class interface array gibi yapılarda ise referans tip olarak geçer ve heapde tutulur
            int[] sayilar = new int[] { 1,2,3};
            int[] sayilar1 = new int[] { 4,5,6};
            sayilar = sayilar1;
            sayilar1[0] = 99;
            Console.WriteLine(sayilar[0]);

            Person person = new Person();
            Person person1 = new Person();
            person.firstName = "Alperen";
            person1 = person; //referans tip olduğu için en son ne atandıysa person'un değeri de  o olur
            person.firstName = "Enes";
            Console.WriteLine(person1.firstName);

        }
        class Person
        {
            public int Id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        class Customer : Person //inheritance
        {
            public string creditCardNumber { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }
    }
}
