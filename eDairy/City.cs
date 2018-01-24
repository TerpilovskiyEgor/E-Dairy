using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class City : Primary
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, City> Cities = new Dictionary<Guid, City>();

        //----------------------------------------------------------- Class properties
        public List<School> Schools
        {
            get
            {
                List<School> schools = new List<School>();
                foreach (var schl in School.Schools.Values)
                    if (schl.City.Id == Id)
                        schools.Add(schl);
                return schools;
            }
        }

        //----------------------------------------------------------- Class constructor
        public City(string name, Guid? id = null) : base(name, id) { }
    }
}