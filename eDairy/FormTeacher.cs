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
    public partial class FormTeacher : Form
    {
        Teacher teacher;

        public FormTeacher(string name, string login, string pass, Guid id, Guid school_id)
        {
            InitializeComponent();
            teacher = new Teacher(name, login, pass, id) { School = School.Schools[school_id] };
        }

        private void Form_Teacher_Load(object sender, EventArgs e)
        {
            Text = teacher.Name;
            LabelSchoolName.Text = teacher.School.Name;
        }

        private void Form_Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formlogin = Application.OpenForms[0];
            formlogin.Show();
        }

        private void FormTeacher_Shown(object sender, EventArgs e)
        {
            foreach (var sbjct in teacher.Subjects)
                TableSubjects.Rows.Add(sbjct.Id, sbjct.Name);
            TableSubjects.ClearSelection();

            foreach (var clss in teacher.Classes)
                TableClasses.Rows.Add(clss.Id, clss.Name, clss.StudentCount);
            TableClasses.ClearSelection();
        }

        private void FormTeacher_MouseClick(object sender, MouseEventArgs e)
        {
            TableSubjects.ClearSelection();

            TableClasses.Rows.Clear();
            foreach (var clss in teacher.Classes)
                TableClasses.Rows.Add(clss.Id, clss.Name, clss.StudentCount);
            TableClasses.ClearSelection();
        }

        private void TableSubjects_SelectionChanged(object sender, EventArgs e)
        {
            TableClasses.Rows.Clear();
            if (TableSubjects.SelectedRows.Count != 0)
            {
                foreach (var clss in teacher.Classes)
                    if (clss.Subjects.Contains(Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]))
                        TableClasses.Rows.Add(clss.Id, clss.Name, clss.StudentCount);
                TableClasses.ClearSelection();
            }
        }

        private void TableClasses_SelectionChanged(object sender, EventArgs e)
        {
            TableStudents.Rows.Clear();
            if (TableClasses.SelectedRows.Count != 0)
            {
                foreach (var stdnt in Class.Classes[(Guid)TableClasses.SelectedCells[0].Value].Students)
                    TableStudents.Rows.Add(stdnt.Id, stdnt.Name);
                TableStudents.ClearSelection();
            }
        }

        private void TableStudents_SelectionChanged(object sender, EventArgs e)
        {
            TableMarks.Rows.Clear();
            if (TableStudents.SelectedRows.Count != 0 && TableSubjects.SelectedRows.Count != 0)
            {
                foreach (var mrk in Student.Students[(Guid)TableStudents.SelectedCells[0].Value].Marks)
                    if (mrk.Subject.Id == Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value].Id)
                        TableMarks.Rows.Add(mrk.Id, mrk.Value, mrk.Name);
                TableMarks.ClearSelection();
            }
        }

        private void ButtonAddMark_Click(object sender, EventArgs e)
        {
            if (TableSubjects.SelectedRows.Count != 0)
            {
                if (TableStudents.SelectedRows.Count != 0)
                {
                    DBControl.Add(Student.Students[(Guid)TableStudents.SelectedCells[0].Value], Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]);
                        TableStudents_SelectionChanged(sender, e);
                }
                else
                    MessageBox.Show("Для добавления оценки, выбирете ученика из таблицы", "Не выбран ученик для добавления оценки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Для добавления оценки, выбирете предмет из таблицы", "Не выбран предмет для добавления оценки", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonEditMark_Click(object sender, EventArgs e)
        {
            if (TableMarks.SelectedRows.Count != 0)
            {
                DBControl.Edit(Mark.Marks[(Guid)TableMarks.SelectedCells[0].Value]);
                TableMarks.SelectedCells[1].Value = Mark.Marks[(Guid)TableMarks.SelectedCells[0].Value].Value;
                TableMarks.SelectedCells[2].Value = Mark.Marks[(Guid)TableMarks.SelectedCells[0].Value].Name;
                TableMarks.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения оценки, выбирете ее из таблицы", "Не выбрана оценка для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ButtonDeleteMark_Click(object sender, EventArgs e)
        {
            if (TableMarks.SelectedRows.Count != 0)
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранную оценку?", "Удаление выбраной оценки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(Mark.Marks[(Guid)TableMarks.SelectedCells[0].Value]);
                    TableMarks.Rows.Remove(TableMarks.SelectedRows[0]);
                    TableMarks.ClearSelection();
                }
            else
                MessageBox.Show("Для удаления оценки, выбирете ее из таблицы", "Не выбрана оценка для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            DBControl.Edit(teacher, "");
            Text = teacher.Name;
        }
    }
}