using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class NewRStateUserValidationManager : IUserValidationService
    {
      
        public bool Validate(IUser user)
        {
            return true;
        }
    }
}
