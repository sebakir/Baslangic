using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Add();
            //Add2(20,12);
            //Add3(out 10, 20);
            Console.WriteLine(Add4(1, 2, 3, 4, 5));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static void Add2(int number1 , int number2)
        {
            var result = number1 + number2;
            Console.WriteLine(result);
        }
        //static void Add3(out int number1, int number2)
        //{
        //    var result = number1 + number2;
        //    Console.WriteLine(result);
        //}
        static int Add4(params int[] numbers) // toplu işlem yapımını saglar
        {
            return numbers.Sum();
        }
    }
}
