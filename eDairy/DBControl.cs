using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace eDairy
{
    static internal class DBControl
    {
        static string DBpath = System.IO.Path.GetFullPath("MainDB.mdf");
        private static string constr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True;Connect Timeout=30",DBpath);
        private static SqlConnection connection = new SqlConnection(constr);
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader reader;
        static TextInfo t = CultureInfo.CurrentCulture.TextInfo;

        public static void OpenConnection()
        {
            connection.Open();
            command.Connection = connection;
        }

        public static async void Authorization(string login, string password, Form formlogin)
        {
            try
            {
                if (login == "" || password == "")
                    MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    command.CommandText = String.Format("SELECT * FROM Admins WHERE Login = '{0}'", login);
                    reader = await command.ExecuteReaderAsync();
                    await reader.ReadAsync();

                    if (reader.HasRows && Convert.ToString(reader["Password"]) == password)
                    {
                        FormAdmin form_admin = new FormAdmin(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"]);
                        reader.Close();
                        formlogin.Hide();
                        form_admin.Show();
                    }
                    else
                    {
                        reader.Close();
                        command.CommandText = String.Format("SELECT * FROM Managers WHERE Login = '{0}'", login);
                        reader = await command.ExecuteReaderAsync();
                        await reader.ReadAsync();

                        if (reader.HasRows && Convert.ToString(reader["Password"]) == password)
                        {
                            FormManager form_manager = new FormManager(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"], (Guid)reader["School_id"]);
                            reader.Close();
                            form_manager.Show();
                            formlogin.Hide();
                        }
                        else
                        {
                            reader.Close();
                            command.CommandText = String.Format("SELECT * FROM Teachers WHERE Login = '{0}'", login);
                            reader = await command.ExecuteReaderAsync();
                            await reader.ReadAsync();

                            if (reader.HasRows && Convert.ToString(reader["Password"]) == password)
                            {
                                FormTeacher form_teacher = new FormTeacher(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"], (Guid)reader["School_id"]);
                                reader.Close();
                                form_teacher.Show();
                                formlogin.Hide();
                            }
                            else
                            {
                                reader.Close();
                                command.CommandText = String.Format("SELECT * FROM Students WHERE Login = '{0}'", login);
                                reader = await command.ExecuteReaderAsync();
                                await reader.ReadAsync();

                                if (reader.HasRows && Convert.ToString(reader["Password"]) == password)
                                {
                                    FormStudent form_student = new FormStudent(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"], (Guid)reader["Class_id"]);
                                    reader.Close();
                                    form_student.Show();
                                    formlogin.Hide();
                                }
                                else
                                {
                                    reader.Close();
                                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        #region Add Method Overloading

        public static async void Add(City NewCity)      //Add City
        {
            string NewCityName = t.ToTitleCase(Interaction.InputBox("Введите название города", "Добавление города", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (NewCityName == "")
                MessageBox.Show("Для добавления города, введите его название", "Вы не ввели название города", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewCity.ChangeName(NewCityName);
                City.Cities.Add(NewCity.Id, NewCity);
                command.CommandText = string.Format("INSERT INTO Cities VALUES ('{0}', N'{1}')", NewCity.Id, NewCity.Name);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static void Add(City city, School NewSchool)        //Add School
        {
            string NewSchoolName = t.ToTitleCase(Interaction.InputBox("Введите название школы", "Добавление школы", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (NewSchoolName == "")
                MessageBox.Show("Для добавления школы, введите ее название", "Вы не ввели название школы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewSchool.ChangeName(NewSchoolName);
                NewSchool.City = city;
                School.Schools.Add(NewSchool.Id, NewSchool);
                Add(NewSchool);
                command.CommandText = string.Format("INSERT INTO Schools VALUES ('{0}', N'{1}', '{2}')", NewSchool.Id, NewSchool.Name, NewSchool.City.Id);
                command.ExecuteNonQuery();
            }
        }

        public static void Add(School school)       //Add Manager
        {
            Manager NewManager = new Manager("Управляющий школы \"" + school.Name + "\"", null, null) { School = school };
            Manager.Managers.Add(NewManager.Id, NewManager);
            school.Manager = NewManager;
            command.CommandText = string.Format("INSERT INTO Managers VALUES ('{0}', N'{1}', N'{2}', N'{3}', '{4}')", NewManager.Id, NewManager.Name, NewManager.Login, NewManager.GetPassword(NewManager.Id.ToString()), NewManager.School.Id);
            command.ExecuteNonQuery();
        }

        public static async void Add(School school, Class NewClass)      //Add Class
        {
            string NewClassName = t.ToTitleCase(Interaction.InputBox("Введите название класса", "Добавление класса", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (NewClassName == "")
                MessageBox.Show("Для добавления класса, введите его название", "Вы не ввели название класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewClass.ChangeName(NewClassName);
                NewClass.School = school;
                Class.Classes.Add(NewClass.Id, NewClass);
                command.CommandText = string.Format("INSERT INTO Classes VALUES ('{0}', N'{1}', '{2}')", NewClass.Id, NewClass.Name, NewClass.School.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Add(Subject NewSubject)      //Add Subject
        {
            string NewSubjectsName = t.ToTitleCase(Interaction.InputBox("Введите название предмета", "Добавление предмета", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (NewSubjectsName == "")
                MessageBox.Show("Для добавления предмета, введите его название", "Вы не ввели название предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewSubject.ChangeName(NewSubjectsName);
                Subject.Subjects.Add(NewSubject.Id, NewSubject);
                command.CommandText = string.Format("INSERT INTO Subjects VALUES ('{0}', N'{1}')", NewSubject.Id, NewSubject.Name);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Add(School school, Teacher NewTeacher)      //Add Teacher
        {
            string NewTeacherName = t.ToTitleCase(Interaction.InputBox("Введите имя учителя", "Добавление учителя", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (NewTeacherName == "")
                MessageBox.Show("Для добавления учителя, введите его имя", "Вы не ввели имя учителя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewTeacher.ChangeName(NewTeacherName);
                NewTeacher.School = school;
                Teacher.Teachers.Add(NewTeacher.Id, NewTeacher);
                command.CommandText = string.Format("INSERT INTO Teachers VALUES ('{0}', N'{1}', N'{2}', N'{3}', '{4}')", NewTeacher.Id, NewTeacher.Name, NewTeacher.Login, NewTeacher.GetPassword(NewTeacher.Id.ToString()), NewTeacher.School.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Add(Class _class, Student NewStudent)      //Add Student
        {
            string NewStudentName = t.ToTitleCase(Interaction.InputBox("Введите имя ученика", "Добавление ученика", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (NewStudentName == "")
                MessageBox.Show("Для добавления ученика, введите его имя", "Вы не ввели имя ученика", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewStudent.ChangeName(NewStudentName);
                NewStudent.Class = _class;
                Student.Students.Add(NewStudent.Id, NewStudent);
                command.CommandText = string.Format("INSERT INTO Students VALUES ('{0}', N'{1}', N'{2}', N'{3}', '{4}')", NewStudent.Id, NewStudent.Name, NewStudent.Login, NewStudent.GetPassword(NewStudent.Id.ToString()), NewStudent.Class.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static void Add(Class _class, Subject subject)      //Add Class_Subject
        {
            Class_Subject NewClass_Subject = new Class_Subject() { Class = _class, Subject = subject };
            Class_Subject.Classes_Subjects.Add(NewClass_Subject.Id, NewClass_Subject);
            command.CommandText = string.Format("INSERT INTO Classes_Subjects VALUES ('{0}', '{1}', '{2}')", NewClass_Subject.Id, NewClass_Subject.Class.Id, NewClass_Subject.Subject.Id);
            command.ExecuteNonQuery();
        }

        public static void Add(Class_Subject class_subject, Teacher teacher)      //Add Class_Subject_Teacher
        {
            Class_Subject_Teacher NewClass_Subject_Teacher = new Class_Subject_Teacher() { Class_Subject = class_subject, Teacher = teacher };
            Class_Subject_Teacher.Classes_Subjects_Teachers.Add(NewClass_Subject_Teacher.Id, NewClass_Subject_Teacher);
            command.CommandText = string.Format("INSERT INTO Classes_Subjects_Teachers VALUES ('{0}', '{1}', '{2}')", NewClass_Subject_Teacher.Id, NewClass_Subject_Teacher.Class_Subject.Id, NewClass_Subject_Teacher.Teacher.Id);
            command.ExecuteNonQuery();
        }

        public static void Add(Student student, Subject subject)      //Add Mark
        {
            Regex reg = new Regex("[^0-9]");
            string Value = Interaction.InputBox("Введите оценку", "Добавление оценки", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3);
            string Description = Interaction.InputBox("Введите описание оценки", "Добавление оценки", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3);
            if (reg.Match(Value).Success || Value == "")
                MessageBox.Show("Вводите только число (1-12)", "Введены не корректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Mark NewMark = new Mark(Convert.ToInt32(Value), Description) { Student = student, Subject = subject };
                Mark.Marks.Add(NewMark.Id, NewMark);
                command.CommandText = string.Format("INSERT INTO Marks VALUES ('{0}', '{1}', '{2}', '{3}', N'{4}')", NewMark.Id, NewMark.Student.Id, NewMark.Subject.Id, NewMark.Value, NewMark.Name);
                command.ExecuteNonQuery();
            }
        }


        #endregion

        #region Edit Method Overloading

        public static async void Edit(Admin EditedAdmin)        //SelfEdit Admin
        {
            string pass = EditedAdmin.GetPassword(Interaction.InputBox("Введите свой пароль", "Подтверждение личности", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (pass != "****Confidential****")
            {
                FormSettings formset = new FormSettings(EditedAdmin.Name, EditedAdmin.Login, pass);
                if (formset.ShowDialog() == DialogResult.OK)
                {
                    EditedAdmin.ChangeName(formset.TextBoxName.Text);
                    EditedAdmin.ChangeLogin(formset.TextBoxLogin.Text);
                    if (formset.TextBoxNewPass.Text != "")
                    {
                        EditedAdmin.ChangePassword(pass, formset.TextBoxNewPass.Text);
                        pass = formset.TextBoxNewPass.Text;
                    }
                    command.CommandText = string.Format("UPDATE Admins SET FullName = N'{0}', Login = N'{1}', Password = N'{2}'  WHERE Id = '{3}';", EditedAdmin.Name, EditedAdmin.Login, pass, EditedAdmin.Id);
                    await command.ExecuteNonQueryAsync();
                }
                formset.Close();
            }
            else
                MessageBox.Show("Для изменения данных пользователя, введите верный пароль", "Вы ввели неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void Edit(City EditedCity)        //Edit City
        {
            string EditedCityName = t.ToTitleCase(Interaction.InputBox("Введите название города", "Изменение города", EditedCity.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (EditedCityName == "")
                MessageBox.Show("Для изменения города, введите его название", "Вы не ввели название города", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedCity.ChangeName(EditedCityName);
                command.CommandText = string.Format("UPDATE Cities SET Name = N'{0}' WHERE Id = '{1}';", EditedCity.Name, EditedCity.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Edit(School EditedSchool)       //Edit School
        {
            string EditedSchoolName = t.ToTitleCase(Interaction.InputBox("Введите название школы", "Изменение школы", EditedSchool.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (EditedSchoolName == "")
                MessageBox.Show("Для изменения школы, введите ее название", "Вы не ввели название школы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedSchool.ChangeName(EditedSchoolName);
                command.CommandText = string.Format("UPDATE Schools SET Name = N'{0}' WHERE Id = '{1}';", EditedSchool.Name, EditedSchool.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Edit(Manager EditedManager)        //SelfEdit Manager
        {
            string pass = EditedManager.GetPassword(Interaction.InputBox("Введите свой пароль", "Подтверждение личности", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (pass != "****Confidential****")
            {
                FormSettings formset = new FormSettings(EditedManager.Name, EditedManager.Login, pass);
                if (formset.ShowDialog() == DialogResult.OK)
                {
                    EditedManager.ChangeName(formset.TextBoxName.Text);
                    EditedManager.ChangeLogin(formset.TextBoxLogin.Text);
                    if (formset.TextBoxNewPass.Text != "")
                    {
                        EditedManager.ChangePassword(pass, formset.TextBoxNewPass.Text);
                        pass = formset.TextBoxNewPass.Text;
                    }
                    command.CommandText = string.Format("UPDATE Managers SET FullName = N'{0}', Login = N'{1}', Password = N'{2}'  WHERE Id = '{3}';", EditedManager.Name, EditedManager.Login, pass, EditedManager.Id);
                    await command.ExecuteNonQueryAsync();
                }
                formset.Close();
            }
            else
                MessageBox.Show("Для изменения данных пользователя, введите верный пароль", "Вы ввели неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void Edit(Class EditedClass)       //Edit Class
        {
            string EditedClassName = t.ToTitleCase(Interaction.InputBox("Введите название класса", "Изменение класса", EditedClass.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (EditedClassName == "")
                MessageBox.Show("Для изменения класса, введите его название", "Вы не ввели название класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedClass.ChangeName(EditedClassName);
                command.CommandText = string.Format("UPDATE Classes SET Name = N'{0}' WHERE Id = '{1}';", EditedClass.Name, EditedClass.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Edit(Subject EditedSubject)       //Edit Subject
        {
            string EditedSubjectName = t.ToTitleCase(Interaction.InputBox("Введите название предмета", "Изменение предммета", EditedSubject.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (EditedSubjectName == "")
                MessageBox.Show("Для изменения предмета, введите его название", "Вы не ввели название предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedSubject.ChangeName(EditedSubjectName);
                command.CommandText = string.Format("UPDATE Subjects SET Name = N'{0}' WHERE Id = '{1}';", EditedSubject.Name, EditedSubject.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Edit(Teacher EditedTeacher)       //Edit Teacher
        {
            string EditedTeacherName = t.ToTitleCase(Interaction.InputBox("Введите имя учителя", "Изменение учителя", EditedTeacher.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (EditedTeacherName == "")
                MessageBox.Show("Для изменения учителя, введите его имя", "Вы не ввели имя учителя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedTeacher.ChangeName(EditedTeacherName);
                command.CommandText = string.Format("UPDATE Teachers SET FullName = N'{0}' WHERE Id = '{1}';", EditedTeacher.Name, EditedTeacher.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Edit(Teacher EditedTeacher, string s)        //SelfEdit Teacher
        {
            string pass = EditedTeacher.GetPassword(Interaction.InputBox("Введите свой пароль", "Подтверждение личности", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (pass != "****Confidential****")
            {
                FormSettings formset = new FormSettings(EditedTeacher.Name, EditedTeacher.Login, pass);
                formset.TextBoxName.ReadOnly = true;
                if (formset.ShowDialog() == DialogResult.OK)
                {
                    EditedTeacher.ChangeLogin(formset.TextBoxLogin.Text);
                    if (formset.TextBoxNewPass.Text != "")
                    {
                        EditedTeacher.ChangePassword(pass, formset.TextBoxNewPass.Text);
                        pass = formset.TextBoxNewPass.Text;
                    }
                    command.CommandText = string.Format("UPDATE Teachers SET FullName = N'{0}', Login = N'{1}', Password = N'{2}'  WHERE Id = '{3}';", EditedTeacher.Name, EditedTeacher.Login, pass, EditedTeacher.Id);
                    await command.ExecuteNonQueryAsync();
                }
                formset.Close();
            }
            else
                MessageBox.Show("Для изменения данных пользователя, введите верный пароль", "Вы ввели неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void Edit(Student EditedStudent)       //Edit Student
        {
            string EditedStudentName = t.ToTitleCase(Interaction.InputBox("Введите имя ученика", "Изменение ученика", EditedStudent.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (EditedStudentName == "")
                MessageBox.Show("Для изменения ученика, введите его имя", "Вы не ввели имя ученика", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedStudent.ChangeName(EditedStudentName);
                command.CommandText = string.Format("UPDATE Students SET FullName = N'{0}' WHERE Id = '{1}';", EditedStudent.Name, EditedStudent.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static async void Edit(Student EditedStudent, string s)        //SelfEdit Student
        {
            string pass = EditedStudent.GetPassword(Interaction.InputBox("Введите свой пароль", "Подтверждение личности", "", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3));
            if (pass != "****Confidential****")
            {
                FormSettings formset = new FormSettings(EditedStudent.Name, EditedStudent.Login, pass);
                formset.TextBoxName.ReadOnly = true;
                if (formset.ShowDialog() == DialogResult.OK)
                {
                    EditedStudent.ChangeLogin(formset.TextBoxLogin.Text);
                    if (formset.TextBoxNewPass.Text != "")
                    {
                        EditedStudent.ChangePassword(pass, formset.TextBoxNewPass.Text);
                        pass = formset.TextBoxNewPass.Text;
                    }
                    command.CommandText = string.Format("UPDATE Students SET FullName = N'{0}', Login = N'{1}', Password = N'{2}'  WHERE Id = '{3}';", EditedStudent.Name, EditedStudent.Login, pass, EditedStudent.Id);
                    await command.ExecuteNonQueryAsync();
                }
                formset.Close();
            }
            else
                MessageBox.Show("Для изменения данных пользователя, введите верный пароль", "Вы ввели неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void Edit(Mark EditedMark)       //Edit Mark
        {
            Regex reg = new Regex("[^0-9]");
            string NewValue = Interaction.InputBox("Введите оценку", "Изменение оценки", EditedMark.Value.ToString(), Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3);
            string NewDescription = Interaction.InputBox("Введите описание оценки", "Добавление оценки", EditedMark.Name, Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3);
            if (reg.Match(NewValue).Success && NewValue == "")
                MessageBox.Show("Вводите только число (1-12)", "Введены не корректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditedMark.ChangeValue(Convert.ToInt32(NewValue));
                EditedMark.ChangeName(NewDescription);
                command.CommandText = string.Format("UPDATE Marks SET Value ='{0}', Name = N'{1}' WHERE Id = '{2}';", EditedMark.Value, EditedMark.Name, EditedMark.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public static bool Edit(string Login)       //Edit Login
        {
            command.CommandText = string.Format("SELECT * FROM Admins WHERE Login = '{0}'", Login);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                command.CommandText = string.Format("SELECT * FROM Managers WHERE Login = '{0}'", Login);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    command.CommandText = string.Format("SELECT * FROM Teachers WHERE Login = '{0}'", Login);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        return false;
                    }
                    else
                    {
                        reader.Close();
                        command.CommandText = string.Format("SELECT * FROM Students WHERE Login = '{0}'", Login);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Close();
                            return false;
                        }
                        else
                        {
                            reader.Close();
                            return true;
                        }
                    }
                }
            }

        }

        #endregion

        #region Delete Method Overloading

        public static async void Delete(City DeletedCity)     //Delete City
        {
            command.CommandText = string.Format("DELETE FROM Cities WHERE Id = '{0}'", DeletedCity.Id);
            await command.ExecuteNonQueryAsync();
            foreach (var schl in DeletedCity.Schools)
                Delete(schl);
            City.Cities.Remove(DeletedCity.Id);
        }

        public static void Delete(School DeletedSchool)        //Delete School
        {
            command.CommandText = string.Format("DELETE FROM Schools WHERE Id = '{0}'", DeletedSchool.Id);
            command.ExecuteNonQuery();
            foreach (var clss in DeletedSchool.Classes)
                Delete(clss);
            foreach (var tchr in DeletedSchool.Teachers)
                Delete(tchr);
            command.CommandText = string.Format("DELETE FROM Managers WHERE Id = '{0}'", DeletedSchool.Manager.Id);
            command.ExecuteNonQuery();
            Manager.Managers.Remove(DeletedSchool.Manager.Id);
            School.Schools.Remove(DeletedSchool.Id);
        }

        public static void Delete(Class DeletedClass)        //Delete Class
        {
            command.CommandText = string.Format("DELETE FROM Classes WHERE Id = '{0}'", DeletedClass.Id);
            command.ExecuteNonQuery();
            foreach (var stdnt in DeletedClass.Students)
                Delete(stdnt);
            foreach (var clss_sbjct in Class_Subject.Classes_Subjects.Values)
                if (clss_sbjct.Class.Id == DeletedClass.Id)
                    Delete(clss_sbjct);
            Class.Classes.Remove(DeletedClass.Id);
        }

        public static void Delete(Subject DeletedSubject)        //Delete Subject
        {
            command.CommandText = string.Format("DELETE FROM Subjects WHERE Id = '{0}'", DeletedSubject.Id);
            command.ExecuteNonQuery();
            foreach (var clss_sbjct in Class_Subject.Classes_Subjects.Values)
                if (clss_sbjct.Subject.Id == DeletedSubject.Id)
                    Delete(clss_sbjct);
            foreach (var mrk in Mark.Marks.Values)
                if (mrk.Subject.Id == DeletedSubject.Id)
                    Delete(mrk);
            Subject.Subjects.Remove(DeletedSubject.Id);
        }

        public static void Delete(Teacher DeletedTeacher)        //Delete Teacher
        {
            command.CommandText = string.Format("DELETE FROM Teachers WHERE Id = '{0}'", DeletedTeacher.Id);
            command.ExecuteNonQuery();
            foreach (var clss_sbjct_tchr in Class_Subject_Teacher.Classes_Subjects_Teachers.Values)
                if (clss_sbjct_tchr.Teacher.Id == DeletedTeacher.Id)
                    Delete(clss_sbjct_tchr);
            Teacher.Teachers.Remove(DeletedTeacher.Id);
        }

        public static void Delete(Student DeletedStudent)        //Delete Student
        {
            command.CommandText = string.Format("DELETE FROM Students WHERE Id = '{0}'", DeletedStudent.Id);
            command.ExecuteNonQuery();
            foreach (var mrk in DeletedStudent.Marks)
                Delete(mrk);
            Student.Students.Remove(DeletedStudent.Id);
        }

        public static void Delete(Class_Subject DeletedClass_Subject)        //Delete Class_Subject
        {
            command.CommandText = string.Format("DELETE FROM Classes_Subjects WHERE Id = '{0}'", DeletedClass_Subject.Id);
            command.ExecuteNonQuery();
            foreach (var clss_sbjct_tchr in Class_Subject_Teacher.Classes_Subjects_Teachers.Values)
                if (clss_sbjct_tchr.Class_Subject.Id == DeletedClass_Subject.Id)
                    Delete(clss_sbjct_tchr);
            Class_Subject.Classes_Subjects.Remove(DeletedClass_Subject.Id);
        }

        public static void Delete(Class_Subject_Teacher DeletedClass_Subject_Teacher)        //Delete Class_Subject_Teacher
        {
            command.CommandText = string.Format("DELETE FROM Classes_Subjects_Teachers WHERE Id = '{0}'", DeletedClass_Subject_Teacher.Id);
            command.ExecuteNonQuery();
            Class_Subject_Teacher.Classes_Subjects_Teachers.Remove(DeletedClass_Subject_Teacher.Id);
        }

        public static void Delete(Mark DeletedMark)        //Delete Mark
        {
            command.CommandText = string.Format("DELETE FROM Marks WHERE Id = '{0}'", DeletedMark.Id);
            command.ExecuteNonQuery();
            Mark.Marks.Remove(DeletedMark.Id);
        }

        #endregion

        #region Load Method Overloading

        public static void Load()
        {

            //Load Cities

            command.CommandText = "SELECT * FROM Cities";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    City obj = new City(reader["Name"].ToString(), (Guid)reader["Id"]);
                    City.Cities.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Schools

            command.CommandText = "SELECT * FROM Schools";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    School obj = new School(reader["Name"].ToString(), (Guid)reader["Id"]) { City = City.Cities[(Guid)reader["City_id"]] };
                    School.Schools.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Managers

            command.CommandText = "SELECT * FROM Managers";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Manager obj = new Manager(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"]) { School = School.Schools[(Guid)reader["School_id"]] };
                    Manager.Managers.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Classes

            command.CommandText = "SELECT * FROM Classes";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Class obj = new Class(reader["Name"].ToString(), (Guid)reader["Id"]) { School = School.Schools[(Guid)reader["School_id"]] };
                    Class.Classes.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Students

            command.CommandText = "SELECT * FROM Students";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Student obj = new Student(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"]) { Class = Class.Classes[(Guid)reader["Class_id"]] };
                    Student.Students.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Subjects

            command.CommandText = "SELECT * FROM Subjects";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Subject obj = new Subject(reader["Name"].ToString(), (Guid)reader["Id"]);
                    Subject.Subjects.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Marks

            command.CommandText = "SELECT * FROM Marks";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Mark obj = new Mark(Convert.ToInt32(reader["Value"]), reader["Name"].ToString(), (Guid)reader["Id"]) { Student = Student.Students[(Guid)reader["Student_id"]], Subject = Subject.Subjects[(Guid)reader["Subject_id"]] };
                    Mark.Marks.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Classes_Subjects

            command.CommandText = "SELECT * FROM Classes_Subjects";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Class_Subject obj = new Class_Subject((Guid)reader["Id"]) { Class = Class.Classes[(Guid)reader["Class_id"]], Subject = Subject.Subjects[(Guid)reader["Subject_id"]] };
                    Class_Subject.Classes_Subjects.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Teachers

            command.CommandText = "SELECT * FROM Teachers";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Teacher obj = new Teacher(reader["FullName"].ToString(), reader["Login"].ToString(), reader["Password"].ToString(), (Guid)reader["Id"]) { School = School.Schools[(Guid)reader["School_id"]] };
                    Teacher.Teachers.Add(obj.Id, obj);
                }
            }
            reader.Close();


            //Load Classes_Subjects_Teachers

            command.CommandText = "SELECT * FROM Classes_Subjects_Teachers";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Class_Subject_Teacher obj = new Class_Subject_Teacher((Guid)reader["Id"]) { Class_Subject = Class_Subject.Classes_Subjects[(Guid)reader["Class_Subject_id"]], Teacher = Teacher.Teachers[(Guid)reader["Teacher_id"]] };
                    Class_Subject_Teacher.Classes_Subjects_Teachers.Add(obj.Id, obj);
                }
            }
            reader.Close();
        }

        #endregion
    }
}