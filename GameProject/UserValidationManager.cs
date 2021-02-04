using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Seçkin" && gamer.LastName == "Bakır" && gamer.IdentityNumber == 123123123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
