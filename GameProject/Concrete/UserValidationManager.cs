using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(IUser user)
        {
            if(user.BirthYear == 1996 && user.FirstName == "Aslı" && user.LastName == "Yılmaz" && user.NationalityId == 12345)
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
