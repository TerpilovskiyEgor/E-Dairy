using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eDairy
{
    class Admin : Account
    {
        //----------------------------------------------------------- Class constructor
        public Admin(string name, string login, string pass, Guid id) : base(name, login, pass, id) { }
    }
}