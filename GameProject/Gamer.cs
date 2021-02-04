using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }


        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added");
        }
    }
}
