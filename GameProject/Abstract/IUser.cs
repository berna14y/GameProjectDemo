using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int BirthYear { get; set; }
        int NationalityId { get; set; }
        
    }
}
