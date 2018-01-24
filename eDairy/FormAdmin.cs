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
    public partial class FormAdmin : Form
    {
        Admin admin;

        public FormAdmin(string name, string login, string pass, Guid id)
        {
            InitializeComponent();
            admin = new Admin(name, login, pass, id);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Text += admin.Name;
            foreach (var mngr in Manager.Managers.Values)
                School.Schools[mngr.School.Id].Manager = mngr;
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formlogin = Application.OpenForms[0];
            formlogin.Show();
        }

        private void ButtonAddCity_Click(object sender, EventArgs e)
        {
            City NewCity = new City(null);
            DBControl.Add(NewCity);
            if (NewCity.Name != null)
            {
                TableCities.Rows.Add(NewCity.Id, NewCity.Name);
                TableCities.ClearSelection();
            }

        }

        private void ButtonEditCity_Click(object sender, EventArgs e)
        {
            if (TableCities.SelectedRows.Count != 0)
            {
                DBControl.Edit(City.Cities[(Guid)TableCities.SelectedCells[0].Value]);
                TableCities.SelectedCells[1].Value = City.Cities[(Guid)TableCities.SelectedCells[0].Value].Name;
                TableCities.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения города, выбирете его из таблицы", "Не выбран город для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteCity_Click(object sender, EventArgs e)
        {
            if (TableCities.SelectedRows.Count != 0)
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный город?", "Удаление выбраного города", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(City.Cities[(Guid)TableCities.SelectedCells[0].Value]);
                    TableCities.Rows.Remove(TableCities.SelectedRows[0]);
                    TableCities.ClearSelection();
                }
            else
                MessageBox.Show("Для удаления города, выбирете его из таблицы", "Не выбран город для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            foreach (var ct in City.Cities.Values)
                TableCities.Rows.Add(ct.Id, ct.Name);
            TableCities.ClearSelection();
            foreach (var sbjct in Subject.Subjects.Values)
                TableSubjects.Rows.Add(sbjct.Id, sbjct.Name);
            TableSubjects.ClearSelection();
        }

        private void TableCities_SelectionChanged(object sender, EventArgs e)
        {
            TableSchools.Rows.Clear();
            if (TableCities.SelectedRows.Count != 0)
            {
                foreach (var i in City.Cities[(Guid)TableCities.SelectedCells[0].Value].Schools)
                    TableSchools.Rows.Add(i.Id, i.Name, i.Manager.Id, i.Manager.Name, i.Manager.Login, i.Manager.GetPassword(i.Manager.Id.ToString()));
                TableSchools.ClearSelection();
            }
        }

        private void ButtonAddSchool_Click(object sender, EventArgs e)
        {
            if (TableCities.SelectedRows.Count != 0)
            {
                School NewSchool = new School(null);
                DBControl.Add(City.Cities[(Guid)TableCities.SelectedCells[0].Value], NewSchool);
                if (NewSchool.Name != null)
                {
                    TableSchools.Rows.Add(NewSchool.Id, NewSchool.Name, NewSchool.Manager.Id, NewSchool.Manager.Name, NewSchool.Manager.Login, NewSchool.Manager.GetPassword(NewSchool.Manager.Id.ToString()));
                    TableSchools.ClearSelection();
                }
            }
            else
                MessageBox.Show("Для добавления школы, выбирете город из таблицы", "Не выбран город для добавления школы", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonEditSchool_Click(object sender, EventArgs e)
        {
            if (TableSchools.SelectedRows.Count != 0)
            {
                DBControl.Edit(School.Schools[(Guid)TableSchools.SelectedCells[0].Value]);
                TableSchools.SelectedCells[1].Value = School.Schools[(Guid)TableSchools.SelectedCells[0].Value].Name;
                TableSchools.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения школы, выбирете ее из таблицы", "Не выбрана школа для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteSchool_Click(object sender, EventArgs e)
        {
            if (TableSchools.SelectedRows.Count != 0)
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранную школу?", "Удаление выбраной школы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(School.Schools[(Guid)TableSchools.SelectedCells[0].Value]);
                    TableSchools.Rows.Remove(TableSchools.SelectedRows[0]);
                    TableSchools.ClearSelection();
                }
            else
                MessageBox.Show("Для удаления школы, выбирете ее из таблицы", "Не выбрана школа для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            TableCities.ClearSelection();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            DBControl.Edit(admin);
            Text = "Администратор " + admin.Name;
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

        private void ButtonEditSubject_Click(object sender, EventArgs e)
        {
            if (TableSubjects.SelectedRows.Count != 0)
            {
                DBControl.Edit(Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]);
                TableSubjects.SelectedCells[1].Value = Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value].Name;
                TableSubjects.ClearSelection();
            }
            else
                MessageBox.Show("Для изменения предмета, выбирете его из таблицы", "Не выбран предмет для изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeleteSubject_Click(object sender, EventArgs e)
        {
            if (TableSubjects.SelectedRows.Count != 0)
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный предмет?", "Удаление выбраного предмета", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                { }
                else
                {
                    DBControl.Delete(Subject.Subjects[(Guid)TableSubjects.SelectedCells[0].Value]);
                    TableSubjects.Rows.Remove(TableSubjects.SelectedRows[0]);
                    TableSubjects.ClearSelection();
                }
            else
                MessageBox.Show("Для удаления предмета, выбирете его из таблицы", "Не выбран предмет для удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}