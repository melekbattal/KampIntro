using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="MELEK" && gamer.LastName=="Battal" && gamer.DateOfBirth==1991 && gamer.NationalityId==12345)
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
