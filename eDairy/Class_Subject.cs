using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Class_Subject
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Class_Subject> Classes_Subjects = new Dictionary<Guid, Class_Subject>();
        public static Class_Subject GetObj(Class clss, Subject sbjct)
        {
            Class_Subject obj = null;
            foreach (var clss_sbjct in Classes_Subjects.Values)
                if (clss_sbjct.Class.Id == clss.Id && clss_sbjct.Subject.Id == sbjct.Id)
                    obj = clss_sbjct;
            return obj;
        }

        //----------------------------------------------------------- Class fields
        private Guid Class_id;
        private Guid Subject_id;

        //----------------------------------------------------------- Class properties
        public Guid Id { get; private set; }
        public Class Class { get { return Class.Classes[Class_id]; } set { Class_id = value.Id; } }
        public Subject Subject { get { return Subject.Subjects[Subject_id]; } set { Subject_id = value.Id; } }
        public List<Teacher> Teachers
        {
            get
            {
                List<Teacher> teachers = new List<Teacher>();
                foreach (var obj in Class_Subject_Teacher.Classes_Subjects_Teachers.Values)
                    if (obj.Class_Subject.Id == Id)
                        teachers.Add(obj.Teacher);
                return teachers;
            }
        }

        //----------------------------------------------------------- Class constructor
        public Class_Subject(Guid? id = null)
        {
            if (id == null)
                Id = Guid.NewGuid();
            else
                Id = (Guid)id;
        }
    }
}