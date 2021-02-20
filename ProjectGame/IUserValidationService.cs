using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGame
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
