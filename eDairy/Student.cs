using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Student : Account
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Student> Students = new Dictionary<Guid, Student>();

        //----------------------------------------------------------- Class fields
        private Guid Class_id;

        //----------------------------------------------------------- Class properties
        public Class Class { get { return Class.Classes[Class_id]; } set { Class_id = value.Id; } }
        public List<Mark> Marks
        {
            get
            {
                List<Mark> marks = new List<Mark>();
                foreach (var mrk in Mark.Marks.Values)
                    if (mrk.Student.Id == Id)
                        marks.Add(mrk);
                return marks;
            }
        }

        //----------------------------------------------------------- Class constructor
        public Student(string name, string login, string pass, Guid? id = null) : base(name, login, pass, id)
        {
            if (login == null)
                ChangeLogin("Student_" + Id.ToString());
            if (pass == null)
                ChangePassword(pass, Id.ToString());
        }
    }
}