using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Subject : Primary
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Subject> Subjects = new Dictionary<Guid, Subject>();

        //----------------------------------------------------------- Class properties
        public List<Class> Classes
        {
            get
            {
                List<Class> classes = new List<Class>();
                foreach (var obj in Class_Subject.Classes_Subjects.Values)
                    if (obj.Subject.Id == Id)
                        classes.Add(obj.Class);
                return classes;
            }
        }

        //----------------------------------------------------------- Class constructor
        public Subject(string name, Guid? id = null) : base(name, id) { }
    }
}