using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GameManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " added");
            }
            else
            {
                Console.WriteLine("Basarisiz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }
    }
}
