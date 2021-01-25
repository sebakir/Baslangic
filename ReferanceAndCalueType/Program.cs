using System;
using System.Data;

namespace ReferanceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[]
            {
                "Anakra",
                "Adana",
                "Afyon"
            };
            string[] cities2 = new string[]
            {
                "Bursa",
                "Bolu",
                "Balıkesir"
            };
            cities2 = cities1;
            cities1[0] = "Istanbul";
            Console.WriteLine(cities2[0]);
            Console.WriteLine(cities1[0]);

            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();

            dataTable1 = dataTable2;

        }
    }
}
