using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test1.Models;

namespace Test1.BusinessLogic
{
    public class UserBusinessLogic : IValidate
    {
        private readonly User _user;

        public bool isValid()
        {
            throw new NotImplementedException();
        }

        public bool isValid(string password)
        {
            if (password.Length < 6 || password.Length> 8)
            {
                return false;
            }

            return true;
        }

        public User RegisterUser(User user)
        {
            if (isValid(user.Password))
            {
                return user;
            }
            return null;
        }
    }
}
