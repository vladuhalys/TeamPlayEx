using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlayEx
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Team { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User(string name, string password, string team, string role, string email, string phone)
        {
            Name = name;
            Password = password;
            Team = team;
            Role = role;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return Name + " " + Password + " " + Team + " " + Role + " " + Email + " " + Phone;
        }
    }
}
