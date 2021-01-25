using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //String student1 = "Engin";
            //String student2 = "Derin";
            //String student3 = "Salih";

            string[] students = new string[3];
            students[0] = "Seçkin";
            students[1] = "Seçkin";
            students[2] = "Seçkin";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
              {"istanbul", "ankara", "izmir" },
              {"istanbul", "ankara", "izmir" },
              {"istanbul", "ankara", "izmir" },
              {"istanbul", "ankara", "izmir" },
              {"istanbul", "ankara", "izmir" },
            };

            for(int i = 0; i<= regions.GetUpperBound(0); i++)
            {
                for(int j= 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("\n********");
            }


            Console.ReadLine();


        }
    }
}
