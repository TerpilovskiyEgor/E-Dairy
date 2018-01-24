using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eDairy
{
    public class Primary
    {
        //----------------------------------------------------------- Class properties
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        //----------------------------------------------------------- Class constructor
        public Primary(string name, Guid? id)
        {
            if (id == null)
                Id = Guid.NewGuid();
            else
                Id = (Guid)id;
            Name = name;
        }

        //----------------------------------------------------------- Class Methods
        internal void ChangeName(string newname)
        {
            if (newname.Contains("'"))
                newname = newname.Replace("'", "\"");
            Name = newname;
        }
    }
}