using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Teacher : Account
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Teacher> Teachers = new Dictionary<Guid, Teacher>();

        //----------------------------------------------------------- Class fields
        private Guid School_id;

        //----------------------------------------------------------- Class properties
        public School School { get { return School.Schools[School_id]; } set { School_id = value.Id; } }
        private List<Class_Subject> Classes_Subjects
        {
            get
            {
                List<Class_Subject> classes_subjects = new List<Class_Subject>();
                foreach (var obj in Class_Subject_Teacher.Classes_Subjects_Teachers.Values)
                    if (obj.Teacher.Id == Id)
                        classes_subjects.Add(obj.Class_Subject);
                return classes_subjects;
            }
        }
        public List<Class> Classes
        {
            get
            {
                List<Class> classes = new List<Class>();
                foreach (var obj in Classes_Subjects)
                    if (classes.Contains(obj.Class) == false)
                        classes.Add(obj.Class);
                return classes;
            }
        }
        public List<Subject> Subjects
        {
            get
            {
                List<Subject> subjects = new List<Subject>();
                foreach (var obj in Classes_Subjects)
                    if (subjects.Contains(obj.Subject) == false)
                        subjects.Add(obj.Subject);
                return subjects;
            }
        }

        //----------------------------------------------------------- Class constructor
        public Teacher(string name, string login, string pass, Guid? id = null) : base(name, login, pass, id)
        {
            if (login == null)
                ChangeLogin("Teacher_" + Id.ToString());
            if (pass == null)
                ChangePassword(pass, Id.ToString());
        }
    }
}