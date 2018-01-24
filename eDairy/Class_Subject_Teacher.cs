using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Class_Subject_Teacher
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Class_Subject_Teacher> Classes_Subjects_Teachers = new Dictionary<Guid, Class_Subject_Teacher>();
        public static Class_Subject_Teacher GetObj(Class_Subject clss_sbjct, Teacher tchr)
        {
            Class_Subject_Teacher obj = null;
            foreach (var clss_sbjct_tchr in Classes_Subjects_Teachers.Values)
                if (clss_sbjct_tchr.Class_Subject.Id == clss_sbjct.Id && clss_sbjct_tchr.Teacher.Id == tchr.Id)
                    obj = clss_sbjct_tchr;
            return obj;
        }

        //----------------------------------------------------------- Class fields
        private Guid Class_Subject_id;
        private Guid Teacher_id;

        //----------------------------------------------------------- Class properties
        public Guid Id { get; private set; }
        public Class_Subject Class_Subject { get { return Class_Subject.Classes_Subjects[Class_Subject_id]; } set { Class_Subject_id = value.Id; } }
        public Teacher Teacher { get { return Teacher.Teachers[Teacher_id]; } set { Teacher_id = value.Id; } }

        //----------------------------------------------------------- Class constructor
        public Class_Subject_Teacher(Guid? id = null)
        {
            if (id == null)
                Id = Guid.NewGuid();
            else
                Id = (Guid)id;
        }
    }
}