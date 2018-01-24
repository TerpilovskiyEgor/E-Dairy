using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDairy
{
    public partial class FormStudent : Form
    {
        Student student;

        public FormStudent(string name, string login, string pass, Guid id, Guid class_id)
        {
            InitializeComponent();
            student = new Student(name, login, pass, id) { Class = Class.Classes[class_id] };
        }

        private void Form_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formlogin = Application.OpenForms[0];
            formlogin.Show();
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            Text = student.Name;
            LabelSchoolName.Text = student.Class.School.Name;
        }

        private void FormStudent_Shown(object sender, EventArgs e)
        {
            foreach (var sbjct in student.Class.Subjects)
                TableSubjects.Rows.Add(sbjct.Id, sbjct.Name);
            TableSubjects.ClearSelection();
        }

        private void FormStudent_MouseClick(object sender, MouseEventArgs e)
        {
            TableSubjects.ClearSelection();
        }

        private void TableSubjects_SelectionChanged(object sender, EventArgs e)
        {
            TableMarks.Rows.Clear();
            if (TableSubjects.SelectedRows.Count != 0)
            {
                foreach (var mrk in student.Marks)
                    if (mrk.Subject == Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value])
                        TableMarks.Rows.Add(mrk.Id, mrk.Value, mrk.Name);
                TableMarks.ClearSelection();
            }
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            DBControl.Edit(student, "");
            Text = student.Name;
        }
    }
}
