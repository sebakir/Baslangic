using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardisk = new Product(50);
            hardisk.ProductName = "Hard Disk";
            Product gsm = new Product(50);
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                hardisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish!!!");
        }
    }
}
