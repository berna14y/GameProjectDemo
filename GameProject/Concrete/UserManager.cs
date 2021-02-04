using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserManager
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(IUser user)
        {
            if (_userValidationService.Validate(user) == true )
            {
                Console.WriteLine("Registered to the system.");
            }
            else
            {
                Console.WriteLine("Validation is unsuccessful.Not Registered.");
            }
        }

        public void Delete(IUser user)
        {
            Console.WriteLine("Registration deleted.");
        }
        
        public void Update(IUser user)
        {
            Console.WriteLine("Registration updated.");
        }
    }
}
