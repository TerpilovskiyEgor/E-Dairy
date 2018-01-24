namespace eDairy
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.LabelCitiesList = new System.Windows.Forms.Label();
            this.LabelSchoolsList = new System.Windows.Forms.Label();
            this.TableCities = new System.Windows.Forms.DataGridView();
            this.ColumnCityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSchools = new System.Windows.Forms.DataGridView();
            this.ColumnSchoolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSchoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManagerLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManagerPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.UserButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.CitiesButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddCity = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditCity = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteCity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectsButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.TableSubjects = new System.Windows.Forms.DataGridView();
            this.ColumnSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelSubjectsList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSchools)).BeginInit();
            this.MenuStripAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCitiesList
            // 
            this.LabelCitiesList.AutoSize = true;
            this.LabelCitiesList.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelCitiesList.Location = new System.Drawing.Point(11, 71);
            this.LabelCitiesList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCitiesList.Name = "LabelCitiesList";
            this.LabelCitiesList.Size = new System.Drawing.Size(65, 23);
            this.LabelCitiesList.TabIndex = 24;
            this.LabelCitiesList.Text = "Города";
            // 
            // LabelSchoolsList
            // 
            this.LabelSchoolsList.AutoSize = true;
            this.LabelSchoolsList.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelSchoolsList.Location = new System.Drawing.Point(154, 71);
            this.LabelSchoolsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSchoolsList.Name = "LabelSchoolsList";
            this.LabelSchoolsList.Size = new System.Drawing.Size(69, 23);
            this.LabelSchoolsList.TabIndex = 25;
            this.LabelSchoolsList.Text = "Школы";
            // 
            // TableCities
            // 
            this.TableCities.AllowUserToAddRows = false;
            this.TableCities.AllowUserToDeleteRows = false;
            this.TableCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableCities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableCities.BackgroundColor = System.Drawing.Color.White;
            this.TableCities.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCityId,
            this.ColumnCityName});
            this.TableCities.Location = new System.Drawing.Point(11, 96);
            this.TableCities.Margin = new System.Windows.Forms.Padding(2);
            this.TableCities.MultiSelect = false;
            this.TableCities.Name = "TableCities";
            this.TableCities.ReadOnly = true;
            this.TableCities.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TableCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableCities.Size = new System.Drawing.Size(139, 354);
            this.TableCities.TabIndex = 26;
            this.TableCities.SelectionChanged += new System.EventHandler(this.TableCities_SelectionChanged);
            // 
            // ColumnCityId
            // 
            this.ColumnCityId.HeaderText = "Id";
            this.ColumnCityId.Name = "ColumnCityId";
            this.ColumnCityId.ReadOnly = true;
            this.ColumnCityId.Visible = false;
            this.ColumnCityId.Width = 51;
            // 
            // ColumnCityName
            // 
            this.ColumnCityName.HeaderText = "Название";
            this.ColumnCityName.Name = "ColumnCityName";
            this.ColumnCityName.ReadOnly = true;
            this.ColumnCityName.Width = 91;
            // 
            // TableSchools
            // 
            this.TableSchools.AllowUserToAddRows = false;
            this.TableSchools.AllowUserToDeleteRows = false;
            this.TableSchools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableSchools.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableSchools.BackgroundColor = System.Drawing.Color.White;
            this.TableSchools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableSchools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSchoolId,
            this.ColumnSchoolName,
            this.ColumnManagerId,
            this.ColumnManagerName,
            this.ColumnManagerLogin,
            this.ColumnManagerPass});
            this.TableSchools.Location = new System.Drawing.Point(154, 96);
            this.TableSchools.Margin = new System.Windows.Forms.Padding(2);
            this.TableSchools.MultiSelect = false;
            this.TableSchools.Name = "TableSchools";
            this.TableSchools.ReadOnly = true;
            this.TableSchools.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TableSchools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSchools.Size = new System.Drawing.Size(719, 354);
            this.TableSchools.TabIndex = 27;
            // 
            // ColumnSchoolId
            // 
            this.ColumnSchoolId.HeaderText = "Id школы";
            this.ColumnSchoolId.Name = "ColumnSchoolId";
            this.ColumnSchoolId.ReadOnly = true;
            this.ColumnSchoolId.Visible = false;
            this.ColumnSchoolId.Width = 87;
            // 
            // ColumnSchoolName
            // 
            this.ColumnSchoolName.HeaderText = "Название школы";
            this.ColumnSchoolName.Name = "ColumnSchoolName";
            this.ColumnSchoolName.ReadOnly = true;
            this.ColumnSchoolName.Width = 134;
            // 
            // ColumnManagerId
            // 
            this.ColumnManagerId.HeaderText = "Id управляющего";
            this.ColumnManagerId.Name = "ColumnManagerId";
            this.ColumnManagerId.ReadOnly = true;
            this.ColumnManagerId.Visible = false;
            this.ColumnManagerId.Width = 134;
            // 
            // ColumnManagerName
            // 
            this.ColumnManagerName.HeaderText = "Имя управляющего";
            this.ColumnManagerName.Name = "ColumnManagerName";
            this.ColumnManagerName.ReadOnly = true;
            this.ColumnManagerName.Width = 148;
            // 
            // ColumnManagerLogin
            // 
            this.ColumnManagerLogin.HeaderText = "Логин управляющего";
            this.ColumnManagerLogin.Name = "ColumnManagerLogin";
            this.ColumnManagerLogin.ReadOnly = true;
            this.ColumnManagerLogin.Width = 159;
            // 
            // ColumnManagerPass
            // 
            this.ColumnManagerPass.HeaderText = "Пароль управляющего";
            this.ColumnManagerPass.Name = "ColumnManagerPass";
            this.ColumnManagerPass.ReadOnly = true;
            this.ColumnManagerPass.Width = 167;
            // 
            // MenuStripAdmin
            // 
            this.MenuStripAdmin.Font = new System.Drawing.Font("Calibri", 10F);
            this.MenuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserButtons,
            this.CitiesButtons,
            this.SubjectsButtons});
            this.MenuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAdmin.Name = "MenuStripAdmin";
            this.MenuStripAdmin.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuStripAdmin.Size = new System.Drawing.Size(1136, 24);
            this.MenuStripAdmin.TabIndex = 50;
            this.MenuStripAdmin.Text = "menuStrip1";
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
            this.ButtonSettings.Size = new System.Drawing.Size(152, 22);
            this.ButtonSettings.Text = "Настройки";
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // CitiesButtons
            // 
            this.CitiesButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddCity,
            this.ButtonEditCity,
            this.ButtonDeleteCity,
            this.toolStripSeparator1,
            this.ButtonAddSchool,
            this.ButtonEditSchool,
            this.ButtonDeleteSchool});
            this.CitiesButtons.Name = "CitiesButtons";
            this.CitiesButtons.Size = new System.Drawing.Size(60, 22);
            this.CitiesButtons.Text = "Города";
            // 
            // ButtonAddCity
            // 
            this.ButtonAddCity.Name = "ButtonAddCity";
            this.ButtonAddCity.Size = new System.Drawing.Size(174, 22);
            this.ButtonAddCity.Text = "Добавить";
            this.ButtonAddCity.Click += new System.EventHandler(this.ButtonAddCity_Click);
            // 
            // ButtonEditCity
            // 
            this.ButtonEditCity.Name = "ButtonEditCity";
            this.ButtonEditCity.Size = new System.Drawing.Size(174, 22);
            this.ButtonEditCity.Text = "Изменить";
            this.ButtonEditCity.Click += new System.EventHandler(this.ButtonEditCity_Click);
            // 
            // ButtonDeleteCity
            // 
            this.ButtonDeleteCity.Name = "ButtonDeleteCity";
            this.ButtonDeleteCity.Size = new System.Drawing.Size(174, 22);
            this.ButtonDeleteCity.Text = "Удалить";
            this.ButtonDeleteCity.Click += new System.EventHandler(this.ButtonDeleteCity_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // ButtonAddSchool
            // 
            this.ButtonAddSchool.Name = "ButtonAddSchool";
            this.ButtonAddSchool.Size = new System.Drawing.Size(174, 22);
            this.ButtonAddSchool.Text = "Добавить школу";
            this.ButtonAddSchool.Click += new System.EventHandler(this.ButtonAddSchool_Click);
            // 
            // ButtonEditSchool
            // 
            this.ButtonEditSchool.Name = "ButtonEditSchool";
            this.ButtonEditSchool.Size = new System.Drawing.Size(174, 22);
            this.ButtonEditSchool.Text = "Изменить школу";
            this.ButtonEditSchool.Click += new System.EventHandler(this.ButtonEditSchool_Click);
            // 
            // ButtonDeleteSchool
            // 
            this.ButtonDeleteSchool.Name = "ButtonDeleteSchool";
            this.ButtonDeleteSchool.Size = new System.Drawing.Size(174, 22);
            this.ButtonDeleteSchool.Text = "Удалить школу";
            this.ButtonDeleteSchool.Click += new System.EventHandler(this.ButtonDeleteSchool_Click);
            // 
            // SubjectsButtons
            // 
            this.SubjectsButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddSubject,
            this.ButtonEditSubject,
            this.ButtonDeleteSubject});
            this.SubjectsButtons.Name = "SubjectsButtons";
            this.SubjectsButtons.Size = new System.Drawing.Size(81, 22);
            this.SubjectsButtons.Text = "Предметы";
            // 
            // ButtonAddSubject
            // 
            this.ButtonAddSubject.Name = "ButtonAddSubject";
            this.ButtonAddSubject.Size = new System.Drawing.Size(134, 22);
            this.ButtonAddSubject.Text = "Добавить";
            this.ButtonAddSubject.Click += new System.EventHandler(this.ButtonAddSubject_Click);
            // 
            // ButtonEditSubject
            // 
            this.ButtonEditSubject.Name = "ButtonEditSubject";
            this.ButtonEditSubject.Size = new System.Drawing.Size(134, 22);
            this.ButtonEditSubject.Text = "Изменить";
            this.ButtonEditSubject.Click += new System.EventHandler(this.ButtonEditSubject_Click);
            // 
            // ButtonDeleteSubject
            // 
            this.ButtonDeleteSubject.Name = "ButtonDeleteSubject";
            this.ButtonDeleteSubject.Size = new System.Drawing.Size(134, 22);
            this.ButtonDeleteSubject.Text = "Удалить";
            this.ButtonDeleteSubject.Click += new System.EventHandler(this.ButtonDeleteSubject_Click);
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
            this.TableSubjects.Location = new System.Drawing.Point(877, 96);
            this.TableSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.TableSubjects.MultiSelect = false;
            this.TableSubjects.Name = "TableSubjects";
            this.TableSubjects.ReadOnly = true;
            this.TableSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSubjects.Size = new System.Drawing.Size(248, 354);
            this.TableSubjects.TabIndex = 52;
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
            // LabelSubjectsList
            // 
            this.LabelSubjectsList.AutoSize = true;
            this.LabelSubjectsList.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelSubjectsList.Location = new System.Drawing.Point(873, 71);
            this.LabelSubjectsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSubjectsList.Name = "LabelSubjectsList";
            this.LabelSubjectsList.Size = new System.Drawing.Size(94, 23);
            this.LabelSubjectsList.TabIndex = 51;
            this.LabelSubjectsList.Text = "Предметы";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 461);
            this.Controls.Add(this.TableSubjects);
            this.Controls.Add(this.LabelSubjectsList);
            this.Controls.Add(this.MenuStripAdmin);
            this.Controls.Add(this.TableSchools);
            this.Controls.Add(this.TableCities);
            this.Controls.Add(this.LabelSchoolsList);
            this.Controls.Add(this.LabelCitiesList);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Администратор ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.Shown += new System.EventHandler(this.FormAdmin_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormAdmin_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.TableCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSchools)).EndInit();
            this.MenuStripAdmin.ResumeLayout(false);
            this.MenuStripAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelCitiesList;
        private System.Windows.Forms.Label LabelSchoolsList;
        private System.Windows.Forms.DataGridView TableCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCityName;
        private System.Windows.Forms.DataGridView TableSchools;
        private System.Windows.Forms.MenuStrip MenuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem UserButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem CitiesButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddCity;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditCity;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSchoolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSchoolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManagerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManagerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManagerPass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddSchool;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditSchool;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteSchool;
        private System.Windows.Forms.DataGridView TableSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectName;
        private System.Windows.Forms.Label LabelSubjectsList;
        private System.Windows.Forms.ToolStripMenuItem SubjectsButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddSubject;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditSubject;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteSubject;
    }
}