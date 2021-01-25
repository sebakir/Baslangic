using System;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager1.Save(new Customer { DateOfBirth = new DateTime(1998), FirstName = "Seçkin Emre", LastName = "Bakır", NationalityId = "1123123" });

        }
    }
}
