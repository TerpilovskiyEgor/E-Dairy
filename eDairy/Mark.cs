using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy
{
    class Mark : Primary
    {
        //----------------------------------------------------------- Class static elements
        public static Dictionary<Guid, Mark> Marks = new Dictionary<Guid, Mark>();

        //----------------------------------------------------------- Class fields
        private Guid Student_id;
        private Guid Subject_id;

        //----------------------------------------------------------- Class properties
        public int Value { get; private set; }
        public Student Student { get { return Student.Students[Student_id]; } set { Student_id = value.Id; } }
        public Subject Subject { get { return Subject.Subjects[Subject_id]; } set { Subject_id = value.Id; } }

        //----------------------------------------------------------- Class constructor
        public Mark(int value, string name, Guid? id = null) : base(name, id)
        {
            if (value > 12)
                Value = 12;
            else
                if (value < 1)
                Value = 1;
            else
                Value = value;
        }

        //----------------------------------------------------------- Class Methods
        internal void ChangeValue(int newvalue)
        {
            if (newvalue > 12)
                Value = 12;
            else
                if (newvalue < 1)
                Value = 1;
            else
                Value = newvalue;
        }

    }
}