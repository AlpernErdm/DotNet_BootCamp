using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, firstName = "Alperen", lastName = "Erdem", City = "İstanbul" };
            Customer customer1 = new Customer(1, "Caner", "On", "Van"); //constructor method ile hata almadık
            Console.WriteLine(customer1.firstName);
            Console.WriteLine(customer1.lastName);
        }
        class Customer
        {
            public Customer()//default constructor parametresi olmayan constructor customer burda çalıştı
            {

            }
            public Customer(int id ,string FirstName,string LastName,string city) //customer1 burda çalıştı
            {
                firstName = FirstName;
                lastName = LastName;
                id = Id;
                City = city;
                
                Console.WriteLine("Constructor metot çalıştı");
            }
            public int Id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string City { get; set; }
        }
    }
}
