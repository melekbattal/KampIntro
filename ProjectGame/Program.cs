using System;

namespace ProjectGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamermanager = new GamerManager(new UserValidationManager());
            gamermanager.Add(new Gamer
            { Id = 1,
                FirstName = "MELEK",
                LastName = "BATTAL",
                NationalityId = 12345,
                DateOfBirth = 1991 });
        }
    }
}
