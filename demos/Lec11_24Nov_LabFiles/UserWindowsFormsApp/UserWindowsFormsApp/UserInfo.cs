using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserWindowsFormsApp
{
    class UserInfo
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public UserInfo(string id, string name, int age)
        {
            UserId = id;
            UserName = name;
            UserAge = age;
        }
        public override string ToString()
        {
            //returns the properties separated by a tab as a single line of string
            return UserId + "\t" + UserName + "\t" + UserAge;
        }
    }
}
