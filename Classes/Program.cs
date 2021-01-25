using System;

namespace Classes
{
    class Program
    {
        public static int Id { get; private set; }
        public static string City { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }

        //class CustomerManager
        //{
        //    public void Add()
        //    {
        //        Console.WriteLine("Customer Added!!");
        //    }
        //    public void Update()
        //    {
        //        Console.WriteLine("Customer Updated!!");
        //    }
        //}
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.City = "Antalya";
            customer.Id = 1;
            customer.FirstName = "Seçkin";
            customer.LastName = "Bakır";


            //Customer customer1 = new Customer();
            //{

            //    Id = 2 , City = "Antalya" , FirstName = "Yagmur" , LastName = "Ulağ"
            //};
            //string name = customer1.FirstName;
            //Console.WriteLine(name);
        }
    }
}
