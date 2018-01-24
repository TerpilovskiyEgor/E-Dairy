namespace eDairy
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.TableClasses = new System.Windows.Forms.DataGridView();
            this.ColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableTeachers = new System.Windows.Forms.DataGridView();
            this.ColumnTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelClassesList = new System.Windows.Forms.Label();
            this.LabelTeachersList = new System.Windows.Forms.Label();
            this.TableSubjects = new System.Windows.Forms.DataGridView();
            this.ColumnSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelStudentsList = new System.Windows.Forms.Label();
            this.LabelSubjectsList = new System.Windows.Forms.Label();
            this.TableStudents = new System.Windows.Forms.DataGridView();
            this.ColumnStudentsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripManager = new System.Windows.Forms.MenuStrip();
            this.UserButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassesButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditClass = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddClassSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteClassSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectsButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddSubjectTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteSubjectTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.TeachersButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSchoolName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStudents)).BeginInit();
            this.MenuStripManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableClasses
            // 
            this.TableClasses.AllowUserToAddRows = false;
            this.TableClasses.AllowUserToDeleteRows = false;
            this.TableClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableClasses.BackgroundColor = System.Drawing.Color.White;
            this.TableClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClassId,
            this.ColumnClassName,
            this.ColumnClassCount});
            this.TableClasses.Location = new System.Drawing.Point(11, 87);
            this.TableClasses.Margin = new System.Windows.Forms.Padding(2);
            this.TableClasses.MultiSelect = false;
            this.TableClasses.Name = "TableClasses";
            this.TableClasses.ReadOnly = true;
            this.TableClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableClasses.Size = new System.Drawing.Size(298, 161);
            this.TableClasses.TabIndex = 37;
            this.TableClasses.SelectionChanged += new System.EventHandler(this.TableClasses_SelectionChanged);
            // 
            // ColumnClassId
            // 
            this.ColumnClassId.HeaderText = "Id";
            this.ColumnClassId.Name = "ColumnClassId";
            this.ColumnClassId.ReadOnly = true;
            this.ColumnClassId.Visible = false;
            this.ColumnClassId.Width = 44;
            // 
            // ColumnClassName
            // 
            this.ColumnClassName.HeaderText = "Название";
            this.ColumnClassName.Name = "ColumnClassName";
            this.ColumnClassName.ReadOnly = true;
            this.ColumnClassName.Width = 91;
            // 
            // ColumnClassCount
            // 
            this.ColumnClassCount.HeaderText = "Количество учеников";
            this.ColumnClassCount.Name = "ColumnClassCount";
            this.ColumnClassCount.ReadOnly = true;
            this.ColumnClassCount.Width = 161;
            // 
            // TableTeachers
            // 
            this.TableTeachers.AllowUserToAddRows = false;
            this.TableTeachers.AllowUserToDeleteRows = false;
            this.TableTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableTeachers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableTeachers.BackgroundColor = System.Drawing.Color.White;
            this.TableTeachers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeacherId,
            this.ColumnTeacherName,
            this.ColumnTeacherLogin,
            this.ColumnTeacherPass});
            this.TableTeachers.Location = new System.Drawing.Point(11, 271);
            this.TableTeachers.Margin = new System.Windows.Forms.Padding(2);
            this.TableTeachers.MultiSelect = false;
            this.TableTeachers.Name = "TableTeachers";
            this.TableTeachers.ReadOnly = true;
            this.TableTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableTeachers.Size = new System.Drawing.Size(549, 179);
            this.TableTeachers.TabIndex = 36;
            // 
            // ColumnTeacherId
            // 
            this.ColumnTeacherId.HeaderText = "Id";
            this.ColumnTeacherId.Name = "ColumnTeacherId";
            this.ColumnTeacherId.ReadOnly = true;
            this.ColumnTeacherId.Visible = false;
            this.ColumnTeacherId.Width = 44;
            // 
            // ColumnTeacherName
            // 
            this.ColumnTeacherName.HeaderText = "Ф.И.О.";
            this.ColumnTeacherName.Name = "ColumnTeacherName";
            this.ColumnTeacherName.ReadOnly = true;
            this.ColumnTeacherName.Width = 72;
            // 
            // ColumnTeacherLogin
            // 
            this.ColumnTeacherLogin.HeaderText = "Логин";
            this.ColumnTeacherLogin.Name = "ColumnTeacherLogin";
            this.ColumnTeacherLogin.ReadOnly = true;
            this.ColumnTeacherLogin.Width = 69;
            // 
            // ColumnTeacherPass
            // 
            this.ColumnTeacherPass.HeaderText = "Пароль";
            this.ColumnTeacherPass.Name = "ColumnTeacherPass";
            this.ColumnTeacherPass.ReadOnly = true;
            this.ColumnTeacherPass.Width = 77;
            // 
            // LabelClassesList
            // 
            this.LabelClassesList.AutoSize = true;
            this.LabelClassesList.Location = new System.Drawing.Point(11, 66);
            this.LabelClassesList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelClassesList.Name = "LabelClassesList";
            this.LabelClassesList.Size = new System.Drawing.Size(51, 17);
            this.LabelClassesList.TabIndex = 35;
            this.LabelClassesList.Text = "Классы";
            // 
            // LabelTeachersList
            // 
            this.LabelTeachersList.AutoSize = true;
            this.LabelTeachersList.Location = new System.Drawing.Point(8, 250);
            this.LabelTeachersList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTeachersList.Name = "LabelTeachersList";
            this.LabelTeachersList.Size = new System.Drawing.Size(56, 17);
            this.LabelTeachersList.TabIndex = 34;
            this.LabelTeachersList.Text = "Учителя";
            // 
            // TableSubjects
            // 
            this.TableSubjects.AllowUserToAddRows = false;
            this.TableSubjects.AllowUserToDeleteRows = false;
            this.TableSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableSubjects.BackgroundColor = System.Drawing.Color.White;
            this.TableSubjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubjectId,
            this.ColumnSubjectName});
            this.TableSubjects.Location = new System.Drawing.Point(313, 85);
            this.TableSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.TableSubjects.MultiSelect = false;
            this.TableSubjects.Name = "TableSubjects";
            this.TableSubjects.ReadOnly = true;
            this.TableSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSubjects.Size = new System.Drawing.Size(247, 182);
            this.TableSubjects.TabIndex = 46;
            this.TableSubjects.SelectionChanged += new System.EventHandler(this.TableSubjects_SelectionChanged);
            // 
            // ColumnSubjectId
            // 
            this.ColumnSubjectId.HeaderText = "Id";
            this.ColumnSubjectId.Name = "ColumnSubjectId";
            this.ColumnSubjectId.ReadOnly = true;
            this.ColumnSubjectId.Visible = false;
            this.ColumnSubjectId.Width = 51;
            // 
            // ColumnSubjectName
            // 
            this.ColumnSubjectName.HeaderText = "Название";
            this.ColumnSubjectName.Name = "ColumnSubjectName";
            this.ColumnSubjectName.ReadOnly = true;
            this.ColumnSubjectName.Width = 91;
            // 
            // LabelStudentsList
            // 
            this.LabelStudentsList.AutoSize = true;
            this.LabelStudentsList.Location = new System.Drawing.Point(561, 66);
            this.LabelStudentsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelStudentsList.Name = "LabelStudentsList";
            this.LabelStudentsList.Size = new System.Drawing.Size(59, 17);
            this.LabelStudentsList.TabIndex = 45;
            this.LabelStudentsList.Text = "Ученики";
            // 
            // LabelSubjectsList
            // 
            this.LabelSubjectsList.AutoSize = true;
            this.LabelSubjectsList.Location = new System.Drawing.Point(310, 66);
            this.LabelSubjectsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSubjectsList.Name = "LabelSubjectsList";
            this.LabelSubjectsList.Size = new System.Drawing.Size(69, 17);
            this.LabelSubjectsList.TabIndex = 44;
            this.LabelSubjectsList.Text = "Предметы";
            // 
            // TableStudents
            // 
            this.TableStudents.AllowUserToAddRows = false;
            this.TableStudents.AllowUserToDeleteRows = false;
            this.TableStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableStudents.BackgroundColor = System.Drawing.Color.White;
            this.TableStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentsId,
            this.ColumnStudentsName,
            this.ColumnStudentLogin,
            this.ColumnStudentPass});
            this.TableStudents.Location = new System.Drawing.Point(564, 85);
            this.TableStudents.Margin = new System.Windows.Forms.Padding(2);
            this.TableStudents.MultiSelect = false;
            this.TableStudents.Name = "TableStudents";
            this.TableStudents.ReadOnly = true;
            this.TableStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableStudents.Size = new System.Drawing.Size(309, 365);
            this.TableStudents.TabIndex = 48;
            // 
            // ColumnStudentsId
            // 
            this.ColumnStudentsId.HeaderText = "Id";
            this.ColumnStudentsId.Name = "ColumnStudentsId";
            this.ColumnStudentsId.ReadOnly = true;
            this.ColumnStudentsId.Visible = false;
            this.ColumnStudentsId.Width = 44;
            // 
            // ColumnStudentsName
            // 
            this.ColumnStudentsName.HeaderText = "Ф.И.О.";
            this.ColumnStudentsName.Name = "ColumnStudentsName";
            this.ColumnStudentsName.ReadOnly = true;
            this.ColumnStudentsName.Width = 72;
            // 
            // ColumnStudentLogin
            // 
            this.ColumnStudentLogin.HeaderText = "Логин";
            this.ColumnStudentLogin.Name = "ColumnStudentLogin";
            this.ColumnStudentLogin.ReadOnly = true;
            this.ColumnStudentLogin.Width = 69;
            // 
            // ColumnStudentPass
            // 
            this.ColumnStudentPass.HeaderText = "Пароль";
            this.ColumnStudentPass.Name = "ColumnStudentPass";
            this.ColumnStudentPass.ReadOnly = true;
            this.ColumnStudentPass.Width = 77;
            // 
            // MenuStripManager
            // 
            this.MenuStripManager.Font = new System.Drawing.Font("Calibri", 10F);
            this.MenuStripManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserButtons,
            this.ClassesButtons,
            this.SubjectsButtons,
            this.TeachersButtons});
            this.MenuStripManager.Location = new System.Drawing.Point(0, 0);
            this.MenuStripManager.Name = "MenuStripManager";
            this.MenuStripManager.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuStripManager.Size = new System.Drawing.Size(884, 24);
            this.MenuStripManager.TabIndex = 49;
            this.MenuStripManager.Text = "menuStrip1";
            // 
            // UserButtons
            // 
            this.UserButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSettings});
            this.UserButtons.Name = "UserButtons";
            this.UserButtons.Size = new System.Drawing.Size(103, 22);
            this.UserButtons.Text = "Пользователь";
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(140, 22);
            this.ButtonSettings.Text = "Настройки";
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ClassesButtons
            // 
            this.ClassesButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddClass,
            this.ButtonEditClass,
            this.ButtonDeleteClass,
            this.toolStripSeparator1,
            this.ButtonAddStudent,
            this.ButtonEditStudent,
            this.ButtonDeleteStudent,
            this.toolStripSeparator2,
            this.ButtonAddClassSubject,
            this.ButtonDeleteClassSubject});
            this.ClassesButtons.Name = "ClassesButtons";
            this.ClassesButtons.Size = new System.Drawing.Size(63, 22);
            this.ClassesButtons.Text = "Классы";
            // 
            // ButtonAddClass
            // 
            this.ButtonAddClass.Name = "ButtonAddClass";
            this.ButtonAddClass.Size = new System.Drawing.Size(229, 22);
            this.ButtonAddClass.Text = "Добавить";
            this.ButtonAddClass.Click += new System.EventHandler(this.ButtonAddClass_Click);
            // 
            // ButtonEditClass
            // 
            this.ButtonEditClass.Name = "ButtonEditClass";
            this.ButtonEditClass.Size = new System.Drawing.Size(229, 22);
            this.ButtonEditClass.Text = "Изменить";
            this.ButtonEditClass.Click += new System.EventHandler(this.ButtonEditClass_Click);
            // 
            // ButtonDeleteClass
            // 
            this.ButtonDeleteClass.Name = "ButtonDeleteClass";
            this.ButtonDeleteClass.Size = new System.Drawing.Size(229, 22);
            this.ButtonDeleteClass.Text = "Удалить";
            this.ButtonDeleteClass.Click += new System.EventHandler(this.ButtonDeleteClass_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(229, 22);
            this.ButtonAddStudent.Text = "Добавить ученика";
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // ButtonEditStudent
            // 
            this.ButtonEditStudent.Name = "ButtonEditStudent";
            this.ButtonEditStudent.Size = new System.Drawing.Size(229, 22);
            this.ButtonEditStudent.Text = "Изменить ученика";
            this.ButtonEditStudent.Click += new System.EventHandler(this.ButtonEditStudent_Click);
            // 
            // ButtonDeleteStudent
            // 
            this.ButtonDeleteStudent.Name = "ButtonDeleteStudent";
            this.ButtonDeleteStudent.Size = new System.Drawing.Size(229, 22);
            this.ButtonDeleteStudent.Text = "Удалить ученика";
            this.ButtonDeleteStudent.Click += new System.EventHandler(this.ButtonDeleteStudent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // ButtonAddClassSubject
            // 
            this.ButtonAddClassSubject.Name = "ButtonAddClassSubject";
            this.ButtonAddClassSubject.Size = new System.Drawing.Size(229, 22);
            this.ButtonAddClassSubject.Text = "Добавить классу предмет";
            this.ButtonAddClassSubject.Click += new System.EventHandler(this.ButtonAddClassSubject_Click);
            // 
            // ButtonDeleteClassSubject
            // 
            this.ButtonDeleteClassSubject.Name = "ButtonDeleteClassSubject";
            this.ButtonDeleteClassSubject.Size = new System.Drawing.Size(229, 22);
            this.ButtonDeleteClassSubject.Text = "Удалить у класса предмет";
            this.ButtonDeleteClassSubject.Click += new System.EventHandler(this.ButtonDeleteClassSubject_Click);
            // 
            // SubjectsButtons
            // 
            this.SubjectsButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddSubject,
            this.toolStripSeparator3,
            this.ButtonAddSubjectTeacher,
            this.ButtonDeleteSubjectTeacher});
            this.SubjectsButtons.Name = "SubjectsButtons";
            this.SubjectsButtons.Size = new System.Drawing.Size(81, 22);
            this.SubjectsButtons.Text = "Предметы";
            // 
            // ButtonAddSubject
            // 
            this.ButtonAddSubject.Name = "ButtonAddSubject";
            this.ButtonAddSubject.Size = new System.Drawing.Size(286, 22);
            this.ButtonAddSubject.Text = "Добавить";
            this.ButtonAddSubject.Click += new System.EventHandler(this.ButtonAddSubject_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(283, 6);
            // 
            // ButtonAddSubjectTeacher
            // 
            this.ButtonAddSubjectTeacher.Name = "ButtonAddSubjectTeacher";
            this.ButtonAddSubjectTeacher.Size = new System.Drawing.Size(286, 22);
            this.ButtonAddSubjectTeacher.Text = "Добавить классу учителя предмета";
            this.ButtonAddSubjectTeacher.Click += new System.EventHandler(this.ButtonAddSubjectTeacher_Click);
            // 
            // ButtonDeleteSubjectTeacher
            // 
            this.ButtonDeleteSubjectTeacher.Name = "ButtonDeleteSubjectTeacher";
            this.ButtonDeleteSubjectTeacher.Size = new System.Drawing.Size(286, 22);
            this.ButtonDeleteSubjectTeacher.Text = "Удалить у класса учителя предмета";
            this.ButtonDeleteSubjectTeacher.Click += new System.EventHandler(this.ButtonDeleteSubjectTeacher_Click);
            // 
            // TeachersButtons
            // 
            this.TeachersButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddTeacher,
            this.ButtonEditTeacher,
            this.ButtonDeleteTeacher});
            this.TeachersButtons.Name = "TeachersButtons";
            this.TeachersButtons.Size = new System.Drawing.Size(68, 22);
            this.TeachersButtons.Text = "Учителя";
            // 
            // ButtonAddTeacher
            // 
            this.ButtonAddTeacher.Name = "ButtonAddTeacher";
            this.ButtonAddTeacher.Size = new System.Drawing.Size(134, 22);
            this.ButtonAddTeacher.Text = "Добавить";
            this.ButtonAddTeacher.Click += new System.EventHandler(this.ButtonAddTeacher_Click);
            // 
            // ButtonEditTeacher
            // 
            this.ButtonEditTeacher.Name = "ButtonEditTeacher";
            this.ButtonEditTeacher.Size = new System.Drawing.Size(134, 22);
            this.ButtonEditTeacher.Text = "Изменить";
            this.ButtonEditTeacher.Click += new System.EventHandler(this.ButtonEditTeacher_Click);
            // 
            // ButtonDeleteTeacher
            // 
            this.ButtonDeleteTeacher.Name = "ButtonDeleteTeacher";
            this.ButtonDeleteTeacher.Size = new System.Drawing.Size(134, 22);
            this.ButtonDeleteTeacher.Text = "Удалить";
            this.ButtonDeleteTeacher.Click += new System.EventHandler(this.ButtonDeleteTeacher_Click);
            // 
            // LabelSchoolName
            // 
            this.LabelSchoolName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSchoolName.AutoSize = true;
            this.LabelSchoolName.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelSchoolName.Location = new System.Drawing.Point(442, 34);
            this.LabelSchoolName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSchoolName.Name = "LabelSchoolName";
            this.LabelSchoolName.Size = new System.Drawing.Size(0, 23);
            this.LabelSchoolName.TabIndex = 50;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.LabelSchoolName);
            this.Controls.Add(this.TableStudents);
            this.Controls.Add(this.TableSubjects);
            this.Controls.Add(this.LabelStudentsList);
            this.Controls.Add(this.LabelSubjectsList);
            this.Controls.Add(this.TableClasses);
            this.Controls.Add(this.TableTeachers);
            this.Controls.Add(this.LabelClassesList);
            this.Controls.Add(this.LabelTeachersList);
            this.Controls.Add(this.MenuStripManager);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripManager;
            this.Name = "FormManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Form_Manager_Load);
            this.Shown += new System.EventHandler(this.FormManager_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormManager_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.TableClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStudents)).EndInit();
            this.MenuStripManager.ResumeLayout(false);
            this.MenuStripManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableClasses;
        private System.Windows.Forms.DataGridView TableTeachers;
        private System.Windows.Forms.Label LabelClassesList;
        private System.Windows.Forms.Label LabelTeachersList;
        private System.Windows.Forms.DataGridView TableSubjects;
        private System.Windows.Forms.Label LabelStudentsList;
        private System.Windows.Forms.Label LabelSubjectsList;
        private System.Windows.Forms.DataGridView TableStudents;
        private System.Windows.Forms.MenuStrip MenuStripManager;
        private System.Windows.Forms.ToolStripMenuItem UserButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonSettings;
        private System.Windows.Forms.Label LabelSchoolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectName;
        private System.Windows.Forms.ToolStripMenuItem TeachersButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddTeacher;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditTeacher;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteTeacher;
        private System.Windows.Forms.ToolStripMenuItem SubjectsButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddSubject;
        private System.Windows.Forms.ToolStripMenuItem ClassesButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddClass;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditClass;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddStudent;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditStudent;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteStudent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddClassSubject;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteClassSubject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddSubjectTeacher;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteSubjectTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentPass;
    }
}