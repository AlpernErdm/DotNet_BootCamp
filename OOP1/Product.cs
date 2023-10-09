using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string productName { get; set; }
        public double unitPrice { get; set; } //Fiyat
        public int UnitInStock { get; set; }//Stok
        
    }
}
