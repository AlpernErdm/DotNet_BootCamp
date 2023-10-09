using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.productName = "Masa";
            product1.unitPrice = 1500;
            product1.UnitInStock = 12;

            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 3,
                productName = "Koltuk",
                unitPrice = 750,
                UnitInStock = 14
            };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //productManager.Topla2(5, 4);
            
            //int result = productManager.Topla(20, 42);
            //Console.WriteLine(result);



        }
    }
}
