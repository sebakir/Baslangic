using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            SqlServer sql = new SqlServer();
            Mysql mysql = new Mysql();

            sql.Add();
            mysql.Add();

        }

        private static void NewMethod()
        {
            Person[] person = new Person[]
                        {
                new Customer{FirsName = "Seçkin"},
                new Student{FirsName = "Yagmur"},
                new Person{FirsName = "Emre"}
                        };

            foreach (var p in person)
            {
                Console.WriteLine(p.FirsName);
            }
        }

        class Person
        {
            public int Id { get; set; }
            public string FirsName { get; set; }
            public string LastName { get; set; }
        }
        class Person2
        {

        }

        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }


        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added");
            }
            public virtual void Delete()
            {
                Console.WriteLine("Deleted");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Sql Eklendi");
            }
        }
        class Mysql : Database
        {

        }
    }
}
