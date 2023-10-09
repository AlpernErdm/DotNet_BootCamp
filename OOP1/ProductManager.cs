using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.productName+ " eklendi");   
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.productName +" güncellendi");
        }

        public int Topla(int num1, int num2)
        {
            return num1 + num2;
        }
        public void Topla2(int num1, int num2)
        {
            Console.WriteLine(num2+num1);
        }
    }
}
