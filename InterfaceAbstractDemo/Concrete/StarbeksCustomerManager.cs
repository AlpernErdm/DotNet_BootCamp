using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbeksCustomerManager :BaseCustomerManager
    {
       private ICustomerCheckService _customerCheckService;
        public override void Save(Customer custumer)
        {
            CheckIfRealPerson(custumer);
            base.Save(custumer);
        }

        private void CheckIfRealPerson(Customer custumer)
        {
            
        }
    }
}
