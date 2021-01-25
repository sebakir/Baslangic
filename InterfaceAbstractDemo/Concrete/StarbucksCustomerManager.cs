using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerPersonCheckService customerPersonCheckService;

        public StarbucksCustomerManager(ICustomerPersonCheckService customerPersonCheckService)
        {
            this.customerPersonCheckService = customerPersonCheckService;
        }

        public override void Save(Customer customer)
        {
            if (customerPersonCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }


    }
}
