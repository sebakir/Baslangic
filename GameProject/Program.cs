using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GameManager gameManager = new GameManager(new UserValidationManager());

            gameManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Seçkin",
                LastName = "Bakır",
                IdentityNumber = 123123123
            });



        }
    }
}
