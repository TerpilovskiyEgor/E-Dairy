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
    public partial class FormManager : Form
    {
        Manager manager;
        Guid School_id;

        public FormManager(string name, string login, string pass, Guid id, Guid school_id)
        {
            InitializeComponent();
            manager = new Manager(name, login, pass, id);
            School_id = school_id;
        }

        private void Form_Manager_Load(object sender, EventArgs e)
        {
            Text = manager.Name;
            manager.School = School.Schools[School_id];
            LabelSchoolName.Text = School.Schools[School_id].Name;
        }

        private void Form_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formlogin = Application.OpenForms[0];
            formlogin.Show();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            DBControl.Edit(manager);
            Text = manager.Name;
        }

        private void FormManager_MouseClick(object sender, MouseEventArgs e)
        {
            TableClasses.ClearSelection();

            TableSubjects.Rows.Clear();
            foreach (var sbjct in Subject.Subjects.Values)
                TableSubjects.Rows.Add(sbjct.Id, sbjct.Name);
            TableSubjects.ClearSelection();

            TableTeachers.Rows.Clear();
            foreach (var tchr in Teacher.Teachers.Values)
                if (tchr.School.Id == School_id)
                    TableTeachers.Rows.Add(tchr.Id, tchr.Name, tchr.Login, tchr.GetPassword(tchr.Id.ToString()));
            TableTeachers.ClearSelection();
        }

        private void FormManager_Shown(object sender, EventArgs e)
        {
            foreach (var clss in Class.Classes.Values)
                if (clss.School.Id == School_id)
                    TableClasses.Rows.Add(clss.Id, clss.Name, clss.StudentCount);
            TableClasses.ClearSelection();

            foreach (var sbjct in Subject.Subjects.Values)
                TableSubjects.Rows.Add(sbjct.Id, sbjct.Name);
            TableSubjects.ClearSelection();

            foreach (var tchr in Teacher.Teachers.Values)
                if (tchr.School.Id == School_id)
                    TableTeachers.Rows.Add(tchr.Id, tchr.Name, tchr.Login, tchr.GetPassword(tchr.Id.ToString()));
            TableTeachers.ClearSelection();
        }

        private void ButtonAddClass_Click(object sender, EventArgs e)
        {
            Class NewClass = new Class(null);
            DBControl.Add(School.Schools[School_id], NewClass);
            if (NewClass.Name != null)
            {
                TableClasses.Rows.Add(NewClass.Id, NewClass.Name, NewClass.StudentCount);
                TableClasses.ClearSelection();
            }
        }

        private void ButtonAddSubject_Click(object sender, EventArgs e)
        {
            Subject NewSubject = new Subject(null);
            DBControl.Add(NewSubject);
            if (NewSubject.Name != null)
            {
                TableSubjects.Rows.Add(NewSubject.Id, NewSubject.Name);
                TableSubjects.ClearSelection();
            }
        }

        private void ButtonAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher NewTeacher = new Teacher(null, null, null);
            DBControl.Add(School.Schools[School_id], NewTeacher);
            if (NewTeacher.Name != null)
            {
                TableTeachers.Rows.Add(NewTeacher.Id, NewTeacher.Name, NewTeacher.Login, NewTeacher.GetPassword(NewTeacher.Id.ToString()));
                TableTeachers.ClearSelection();
            }
        }

        private void ButtonEditClass_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
            {
                DBControl.Edit(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value]);
                TableClasses.SelectedCells[1].Value = Class.Classes[(Guid)TableClasses.SelectedCells[0].Value].Name;
                TableClasses.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения класса, выбирете его из таблицы", "Не выбран класс для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonEditTeacher_Click(object sender, EventArgs e)
        {
            if (TableTeachers.SelectedRows.Count != 0)
            {
                DBControl.Edit(Teacher.Teachers[(Guid)TableTeachers.SelectedCells[0].Value]);
                TableTeachers.SelectedCells[1].Value = Teacher.Teachers[(Guid)TableTeachers.SelectedCells[0].Value].Name;
                TableTeachers.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения учителя, выбирете его из таблицы", "Не выбран учитель для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteClass_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный класс?", "Удаление выбраного класса", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value]);
                    TableClasses.Rows.Remove(TableClasses.SelectedRows[0]);
                    TableClasses.ClearSelection();
                }
            else
                MessageBox.Show("Для удаления класса, выбирете его из таблицы", "Не выбран класс для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (TableTeachers.SelectedRows.Count != 0)
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранного учителя?", "Удаление выбраного учителя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(Teacher.Teachers[(Guid)TableTeachers.SelectedCells[0].Value]);
                    TableTeachers.Rows.Remove(TableTeachers.SelectedRows[0]);
                    TableTeachers.ClearSelection();
                }
            else
                MessageBox.Show("Для удаления учителя, выбирете его из таблицы", "Не выбран учитель для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
            {
                Student NewStudent = new Student(null, null, null);
                DBControl.Add(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], NewStudent);
                if (NewStudent.Name != null)
                {
                    TableStudents.Rows.Add(NewStudent.Id, NewStudent.Name, NewStudent.Login, NewStudent.GetPassword(NewStudent.Id.ToString()));
                    TableStudents.ClearSelection();
                    TableClasses.SelectedCells[2].Value = Class.Classes[(Guid)TableClasses.SelectedCells[0].Value].StudentCount;
                }
            }
            else
                MessageBox.Show("Для доавления ученика, выбирете класс из таблицы", "Не выбран класс для добавления ученика", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            if (TableStudents.SelectedRows.Count != 0)
            {
                DBControl.Edit(Student.Students[(Guid)TableStudents.SelectedCells[0].Value]);
                TableStudents.SelectedCells[1].Value = Student.Students[(Guid)TableStudents.SelectedCells[0].Value].Name;
                TableStudents.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения ученика, выбирете его из таблицы", "Не выбран ученик для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (TableStudents.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранного ученика?", "Удаление выбраного ученика", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(Student.Students[(Guid)TableStudents.SelectedCells[0].Value]);
                    TableClasses.SelectedCells[2].Value = Class.Classes[(Guid)TableClasses.SelectedCells[0].Value].StudentCount;
                    TableStudents.Rows.Remove(TableStudents.SelectedRows[0]);
                    TableStudents.ClearSelection();
                }
            }
            else
                MessageBox.Show("Для удаления ученика, выбирете его из таблицы", "Не выбран ученик для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonAddSubjectTeacher_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
            {
                if (TableSubjects.SelectedRows.Count != 0)
                {
                    FormList formlist = new FormList(Class_Subject.GetObj(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]));
                    if (formlist.ShowDialog() == DialogResult.OK)
                    {
                        if (formlist.Table.SelectedRows.Count == 0)
                            MessageBox.Show("Для добавления предмета, выбирете его", "Вы не выбрали предмет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            foreach (DataGridViewRow row in formlist.Table.SelectedRows)
                            {
                                DBControl.Add(Class_Subject.GetObj(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]), Teacher.Teachers[(Guid)row.Cells[0].Value]);
                                TableTeachers.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, Teacher.Teachers[(Guid)row.Cells[0].Value].Login, Teacher.Teachers[(Guid)row.Cells[0].Value].GetPassword(row.Cells[0].Value.ToString()));
                            }
                            TableTeachers.ClearSelection();
                        }
                    }
                    formlist.Close();
                }
                else
                    MessageBox.Show("Для добавления учителя предмету, выбирете предмет из таблицы", "Не выбран предмет для добавления учителя предмету", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Для добавления учителя предмету, выбирете класс из таблицы", "Не выбран класс для добавления учителя предмету", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteSubjectTeacher_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
            {
                if (TableSubjects.SelectedRows.Count != 0)
                {
                    if (TableTeachers.SelectedRows.Count != 0)
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить выбранного учителя из предмета в выбранном классе?", "Удаление выбраного учителя из предмета выбранного класса", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        { }
                        else
                        {
                            DBControl.Delete(Class_Subject_Teacher.GetObj(Class_Subject.GetObj(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]), Teacher.Teachers[(Guid)TableTeachers.SelectedCells[0].Value]));
                            TableTeachers.Rows.Remove(TableTeachers.SelectedRows[0]);
                            TableTeachers.ClearSelection();
                        }
                    }
                    else
                        MessageBox.Show("Для удаления учителя из предмета, выбирете его из таблицы", "Не выбран учитель для удаления из предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Для удаления учителя у предмета, выбирете предмет из таблицы", "Не выбран предмет для удаления учителя у предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Для удаелния учителя у предмета, выбирете класс из таблицы", "Не выбран класс для удаления учителя у предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TableSubjects_SelectionChanged(object sender, EventArgs e)
        {
            TableTeachers.Rows.Clear();
            if (TableSubjects.SelectedRows.Count != 0 && TableClasses.SelectedRows.Count != 0)
            {
                foreach (var tchr in Class_Subject.GetObj(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]).Teachers)
                    TableTeachers.Rows.Add(tchr.Id, tchr.Name, tchr.Login, tchr.GetPassword(tchr.Id.ToString()));
                TableTeachers.ClearSelection();
            }

        }

        private void TableClasses_SelectionChanged(object sender, EventArgs e)
        {
            TableStudents.Rows.Clear();
            if (TableClasses.SelectedRows.Count != 0)
            {
                foreach (var stdnt in Class.Classes[(Guid)TableClasses.SelectedCells[0].Value].Students)
                    TableStudents.Rows.Add(stdnt.Id, stdnt.Name, stdnt.Login, stdnt.GetPassword(stdnt.Id.ToString()));
                TableStudents.ClearSelection();
            }

            TableSubjects.Rows.Clear();
            if (TableClasses.SelectedRows.Count != 0)
            {
                foreach (var sbjct in Class.Classes[(Guid)TableClasses.SelectedCells[0].Value].Subjects)
                    TableSubjects.Rows.Add(sbjct.Id, sbjct.Name);
                TableSubjects.ClearSelection();
            }

            TableTeachers.Rows.Clear();
        }

        private void ButtonAddClassSubject_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
            {
                FormList formlist = new FormList(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value]);
                if (formlist.ShowDialog() == DialogResult.OK)
                {
                    if (formlist.Table.SelectedRows.Count == 0)
                        MessageBox.Show("Для добавления предмета, выбирете его", "Вы не выбрали предмет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        foreach (DataGridViewRow row in formlist.Table.SelectedRows)
                        {
                            DBControl.Add(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], Subject.Subjects[(Guid)row.Cells[0].Value]);
                            TableSubjects.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
                        }
                        TableSubjects.ClearSelection();
                    }
                }
                formlist.Close();
            }
            else
                MessageBox.Show("Для добавления предмета, выбирете класс из таблицы", "Не выбран класс для добавления предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteClassSubject_Click(object sender, EventArgs e)
        {
            if (TableClasses.SelectedRows.Count != 0)
            {
                if (TableSubjects.SelectedRows.Count != 0)
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить выбранный предмет из этого класса?", "Удаление выбраного предмета из класса", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    { }
                    else
                    {
                        DBControl.Delete(Class_Subject.GetObj(Class.Classes[(Guid)TableClasses.SelectedCells[0].Value], Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]));
                        TableSubjects.Rows.Remove(TableSubjects.SelectedRows[0]);
                        TableSubjects.ClearSelection();
                    }
                }
                else
                    MessageBox.Show("Для удаления предмета, выбирете его из таблицы", "Не выбран предмет для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Для удаления предмета, выбирете класс из таблицы", "Не выбран класс для удаления предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}