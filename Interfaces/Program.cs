using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            NewMethod();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal() ,
                new OracleServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDals.add();
            }
        }

        private static void NewMethod()
        {
            CustomerManager customer = new CustomerManager();
            customer.add(new SqlServerCustomerDal());
            customer.add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Seçkin",
                LastName = "Bakır",
                Address = "Antalya"
            };
            personManager.Add(customer);
        }
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
