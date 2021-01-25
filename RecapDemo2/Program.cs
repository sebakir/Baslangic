using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.Logger = new DatabaseLogger();
            customer.Add();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();

            //Logger logger = new Logger();
            //logger.Log();
            Console.WriteLine("Customer Added..");
        }
    }
    interface ILogger
    {
        void Log();
    }
    class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database logger");
        }
    }
}
