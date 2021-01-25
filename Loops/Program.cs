using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("this i a prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i = 2; i<number -1; i++)
            {
                if(number %i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void NewMethod()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
