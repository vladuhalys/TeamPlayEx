using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlayEx
{
    public class Maneger : User
    {
        public Maneger(string name, string password, string team, string role, string email, string phone) : base(name, password, team, role, email, phone)
        {

        }
    }
}
