using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class School : Primary
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, School> Schools = new Dictionary<Guid, School>();

        //----------------------------------------------------------- Class fields
        private Guid City_id;
        private Guid Manager_id;

        //----------------------------------------------------------- Class properties
        public City City { get { return City.Cities[City_id]; } set { City_id = value.Id; } }
        public Manager Manager { get { return Manager.Managers[Manager_id]; } set { Manager_id = value.Id; } }
        public List<Class> Classes
        {
            get
            {
                List<Class> classes = new List<Class>();
                foreach (var clss in Class.Classes.Values)
                    if (clss.School.Id == Id)
                        classes.Add(clss);
                return classes;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                List<Teacher> teachers = new List<Teacher>();
                foreach (var tchr in Teacher.Teachers.Values)
                    if (tchr.School.Id == Id)
                        teachers.Add(tchr);
                return teachers;
            }
        }

        //----------------------------------------------------------- Class constructor
        public School(string name, Guid? id = null) : base(name, id) { }
    }
}