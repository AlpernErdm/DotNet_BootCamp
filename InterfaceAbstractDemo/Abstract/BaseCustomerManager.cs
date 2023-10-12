using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
   abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer custumer)
        {
            Console.WriteLine("Saved to Db :" +custumer.FirstName);
        }
    }
}
