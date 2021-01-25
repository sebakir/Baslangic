using System;
using System.Collections.Generic;

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
            HandleException(() =>
            {
                Find();
            });
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
