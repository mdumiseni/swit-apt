using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test1.BusinessLogic;
using Test1.Models;

namespace Test1.View
{
    public class RegisterView
    {
        private readonly UserBusinessLogic _userBusinessLogic = new UserBusinessLogic();

        private User _user;


        public User Register()
        {
            Console.WriteLine("------------------Register-----------------------------");
            var user = new User();
            Console.WriteLine("Please input username : ");
            user.Username = Console.ReadLine();

            Console.WriteLine("Please input password : ");
            user.Password = Console.ReadLine();

            Console.WriteLine("------------------Register-----------------------------");

            _user = _userBusinessLogic.RegisterUser(user);
            return _user ; 

        }

        public User Login()
        {
            var user = new User();
            Console.WriteLine("Please input username to login : ");
            user.Username = Console.ReadLine();

            Console.WriteLine("Please input password : ");
            user.Password = Console.ReadLine();

            return user;

        }
    }
}
