﻿using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Seçkin", LastName = "Bakır", Age = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
        [ToTable("Customers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }
        class CustomerDal
        {

            [Obsolete("Don't use Add , instead use AddNew Method")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
            public void AddNem(Customer customer)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }
        //herkese kullanabilirsin                 // birden fazla kullanabilir miyim sorgusudur 
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        class RequiredPropertyAttribute : Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class)]
        class ToTableAttribute : Attribute
        {
            private string _tableName;
            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }

    }
}
