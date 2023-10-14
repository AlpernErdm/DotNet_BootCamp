using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> {
            new Category{CategoryId=1,CategoryName="Bilgisayar"},
            new Category { CategoryId=2,CategoryName="Telefon"},

            };

            List<Product> products = new List<Product> {
            new Product{ProductId=1,CategoryId=1,ProductName="Monster Abra",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitInStock=10},
            new Product{ProductId=2,CategoryId=1,ProductName="Macbook Air",QuantityPerUnit="32 Gb Ram",UnitPrice=15000,UnitInStock=8},
            new Product{ProductId=3,CategoryId=2,ProductName="Samsung A31",QuantityPerUnit="64 Gb Memory",UnitPrice=8000,UnitInStock=5},
            new Product{ProductId=4,CategoryId=2,ProductName="Samsung A51",QuantityPerUnit="16 Gb Ram",UnitPrice=12000,UnitInStock=20},
            new Product{ProductId=5,CategoryId=2,ProductName="Apple Iphone 13",QuantityPerUnit="8 Gb Ram",UnitPrice=5231,UnitInStock=0},
            };

            foreach (var product in products)
            {
                if (product.UnitPrice > 8250 && product.UnitInStock > 12)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("********************");

            var result = products.Where(p => p.UnitPrice > 8250 && p.UnitInStock > 12);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProduct(products);

        }
        static List<Product> GetProduct(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 8250 && product.UnitInStock > 12)
                {
                    filteredProducts.Add(product);

                }
               
            }
            return filteredProducts;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 8250 && p.UnitInStock > 12).ToList();
        }

       


        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; } //İlişkisel veri kullanmak için hhangı kategoride oldugunu anlamak için
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
