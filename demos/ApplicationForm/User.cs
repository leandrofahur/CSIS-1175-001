using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForm
{
    class User
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public User(string firstName, string lastName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + "\tPassword: " + Password;
        }
    }
}
