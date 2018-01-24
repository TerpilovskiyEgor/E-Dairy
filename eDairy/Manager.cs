using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Manager : Account
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Manager> Managers = new Dictionary<Guid, Manager>();

        //----------------------------------------------------------- Class fields
        private Guid School_id;

        //----------------------------------------------------------- Class properties
        public School School { get { return School.Schools[School_id]; } set { School_id = value.Id; } }

        //----------------------------------------------------------- Class constructor
        public Manager(string name, string login, string pass, Guid? id = null) : base(name, login, pass, id)
        {
            if(login==null)
                ChangeLogin("Manager_" + Id.ToString());
            if(pass==null)
                ChangePassword( pass , Id.ToString());
        }
    }
}