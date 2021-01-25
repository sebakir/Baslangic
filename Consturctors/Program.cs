using System;

namespace Consturctors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.list();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product1 = new Product
            {
                Id = 2,
                Name = "Computer"
            };
            EmployeeManager employeeManager = new EmployeeManager(new DataBaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DosSomething2();
        }


        class CustomerManager
        {
            private int _count = 15;
            public CustomerManager(int count)
            {
                _count = count;
            }
            public CustomerManager()
            {

            }
            public void list()
            {
                Console.WriteLine("Listed {0} items", _count);
            }
            public void Add()
            {
                Console.WriteLine("Adeed");
            }
        }
        class Product
        {
            public Product()
            {

            }
            private int _id;
            private string _name;
            public Product(int id, string name)
            {
                _id = id;
                _name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }
        }
        interface ILogger
        {
            void log();
        }
        class DataBaseLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged to database");
            }
        }
        class FileLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged to file");
            }
        }
        class EmployeeManager
        {

            private ILogger _logger;

            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()
            {
                _logger.log();
                Console.WriteLine("Added");
            }
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0} message", _entity);
            }
        }
        class PersonManager : BaseClass
        {
            public PersonManager(string entity) : base(entity)
            {

            }
            public void Add()
            {
                Console.WriteLine("Added");
                Message();
            }
        }

        static class Teacher
        {
            public static int Number { get; set; }
        }

        static class Utilities
        {
            public static void Validate()
            {
                Console.WriteLine("Validation is done");
            }
        }

        class Manager
        {
            public static void DoSomething()
            {
                Console.WriteLine(" done");
            }
            public void DosSomething2()
            {
                Console.WriteLine("Done 2");
            }

        }
    }
}
