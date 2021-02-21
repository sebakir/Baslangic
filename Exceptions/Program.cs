using System;
using System.Collections.Generic;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //try
            //{
            //    Find();

            //}                                                                    
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);

            //}
            //Method
            //HandleException(() =>
            //{
            //    Find();
            //});


            //Console.WriteLine(Topla(2, 3));
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(5000);
            Console.WriteLine(getRandomNumber());


        }
        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[] { "Engin", "Derin ", "Cemre" };
                students[3] = "Seckin";
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
