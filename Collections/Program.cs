using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // List();

            // tamamen sozluk mantigi ile calisir , key and value iliskisi kurulur
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("Table", "Tablo");

            Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));

        }

        private static void List()
        {
            ArrayList cities = new ArrayList();
            List<string> cities1 = new List<string>();
            cities1.Add("Ankara");

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, FirstName = "Seçkin" });
            var count = customers.Count;
            Console.WriteLine(count);
            customers.AddRange(new Customer[2]); // Ayni anda eleman ekleme islemini yapiyor {} icerisinde obje olusturulabilir
            //customers.IndexOf(); kacinci indexte old. gosterir
            //customers.Insert(index, parametre); nereye eklenecegini belirtiyor

            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + " " + item.FirstName);
            }
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}
