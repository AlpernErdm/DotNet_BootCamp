using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer {   Id=1,FirstName="ALperen",LastName="Erdem",DateOfBirth=new DateTime(2000,07,04),NationalityId="152315156155"  });;
        }
       
    }
}
