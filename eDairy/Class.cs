using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Class : Primary
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Class> Classes = new Dictionary<Guid, Class>();

        //----------------------------------------------------------- Class fields
        private Guid School_id;

        //----------------------------------------------------------- Class properties
        public int StudentCount
        {
            get
            {
                int count = 0;
                foreach (var stdnt in Students)
                    count++;
                return count;
            }
        }
        public School School { get { return School.Schools[School_id]; } set { School_id = value.Id; } }
        public List<Student> Students
        {
            get
            {
                List<Student> students = new List<Student>();
                foreach (var stdnt in Student.Students.Values)
                    if (stdnt.Class.Id == Id)
                        students.Add(stdnt);
                return students;
            }
        }
        public List<Subject> Subjects
        {
            get
            {
                List<Subject> subjects = new List<Subject>();
                foreach (var obj in Class_Subject.Classes_Subjects.Values)
                    if (obj.Class.Id == Id)
                        subjects.Add(obj.Subject);
                return subjects;
            }
        }

        //----------------------------------------------------------- Class constructor
        public Class(string name, Guid? id = null) : base(name, id) { }
    }
}