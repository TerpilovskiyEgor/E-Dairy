namespace eDairy
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.LabelSchoolName = new System.Windows.Forms.Label();
            this.TableStudents = new System.Windows.Forms.DataGridView();
            this.ColumnStudentsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSubjects = new System.Windows.Forms.DataGridView();
            this.ColumnSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelStudentsList = new System.Windows.Forms.Label();
            this.LabelSubjectsList = new System.Windows.Forms.Label();
            this.TableClasses = new System.Windows.Forms.DataGridView();
            this.ColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableMarks = new System.Windows.Forms.DataGridView();
            this.ColumnTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelClassesList = new System.Windows.Forms.Label();
            this.LabelMarksList = new System.Windows.Forms.Label();
            this.MenuStripTeacher = new System.Windows.Forms.MenuStrip();
            this.UserButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MarksButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddMark = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditMark = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeleteMark = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TableStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMarks)).BeginInit();
            this.MenuStripTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSchoolName
            // 
            this.LabelSchoolName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSchoolName.AutoSize = true;
            this.LabelSchoolName.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelSchoolName.Location = new System.Drawing.Point(442, 24);
            this.LabelSchoolName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelSchoolName.Name = "LabelSchoolName";
            this.LabelSchoolName.Size = new System.Drawing.Size(0, 23);
            this.LabelSchoolName.TabIndex = 60;
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
            this.ColumnStudentsName});
            this.TableStudents.Location = new System.Drawing.Point(309, 88);
            this.TableStudents.Margin = new System.Windows.Forms.Padding(1);
            this.TableStudents.MultiSelect = false;
            this.TableStudents.Name = "TableStudents";
            this.TableStudents.ReadOnly = true;
            this.TableStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableStudents.Size = new System.Drawing.Size(290, 363);
            this.TableStudents.TabIndex = 58;
            this.TableStudents.SelectionChanged += new System.EventHandler(this.TableStudents_SelectionChanged);
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
            this.TableSubjects.Location = new System.Drawing.Point(10, 88);
            this.TableSubjects.Margin = new System.Windows.Forms.Padding(1);
            this.TableSubjects.MultiSelect = false;
            this.TableSubjects.Name = "TableSubjects";
            this.TableSubjects.ReadOnly = true;
            this.TableSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSubjects.Size = new System.Drawing.Size(297, 138);
            this.TableSubjects.TabIndex = 57;
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
            this.LabelStudentsList.Location = new System.Drawing.Point(306, 67);
            this.LabelStudentsList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelStudentsList.Name = "LabelStudentsList";
            this.LabelStudentsList.Size = new System.Drawing.Size(59, 17);
            this.LabelStudentsList.TabIndex = 56;
            this.LabelStudentsList.Text = "Ученики";
            // 
            // LabelSubjectsList
            // 
            this.LabelSubjectsList.AutoSize = true;
            this.LabelSubjectsList.Location = new System.Drawing.Point(10, 67);
            this.LabelSubjectsList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelSubjectsList.Name = "LabelSubjectsList";
            this.LabelSubjectsList.Size = new System.Drawing.Size(69, 17);
            this.LabelSubjectsList.TabIndex = 55;
            this.LabelSubjectsList.Text = "Предметы";
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
            this.TableClasses.Location = new System.Drawing.Point(10, 245);
            this.TableClasses.Margin = new System.Windows.Forms.Padding(1);
            this.TableClasses.MultiSelect = false;
            this.TableClasses.Name = "TableClasses";
            this.TableClasses.ReadOnly = true;
            this.TableClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableClasses.Size = new System.Drawing.Size(297, 206);
            this.TableClasses.TabIndex = 54;
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
            // TableMarks
            // 
            this.TableMarks.AllowUserToAddRows = false;
            this.TableMarks.AllowUserToDeleteRows = false;
            this.TableMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableMarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableMarks.BackgroundColor = System.Drawing.Color.White;
            this.TableMarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeacherId,
            this.ColumnMark,
            this.ColumnDescription});
            this.TableMarks.Location = new System.Drawing.Point(601, 88);
            this.TableMarks.Margin = new System.Windows.Forms.Padding(1);
            this.TableMarks.MultiSelect = false;
            this.TableMarks.Name = "TableMarks";
            this.TableMarks.ReadOnly = true;
            this.TableMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableMarks.Size = new System.Drawing.Size(273, 363);
            this.TableMarks.TabIndex = 53;
            // 
            // ColumnTeacherId
            // 
            this.ColumnTeacherId.HeaderText = "Id";
            this.ColumnTeacherId.Name = "ColumnTeacherId";
            this.ColumnTeacherId.ReadOnly = true;
            this.ColumnTeacherId.Visible = false;
            this.ColumnTeacherId.Width = 44;
            // 
            // ColumnMark
            // 
            this.ColumnMark.HeaderText = "Оценка";
            this.ColumnMark.Name = "ColumnMark";
            this.ColumnMark.ReadOnly = true;
            this.ColumnMark.Width = 78;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Описание";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 92;
            // 
            // LabelClassesList
            // 
            this.LabelClassesList.AutoSize = true;
            this.LabelClassesList.Location = new System.Drawing.Point(10, 227);
            this.LabelClassesList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelClassesList.Name = "LabelClassesList";
            this.LabelClassesList.Size = new System.Drawing.Size(51, 17);
            this.LabelClassesList.TabIndex = 52;
            this.LabelClassesList.Text = "Классы";
            // 
            // LabelMarksList
            // 
            this.LabelMarksList.AutoSize = true;
            this.LabelMarksList.Location = new System.Drawing.Point(598, 67);
            this.LabelMarksList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelMarksList.Name = "LabelMarksList";
            this.LabelMarksList.Size = new System.Drawing.Size(54, 17);
            this.LabelMarksList.TabIndex = 51;
            this.LabelMarksList.Text = "Оценки";
            // 
            // MenuStripTeacher
            // 
            this.MenuStripTeacher.Font = new System.Drawing.Font("Calibri", 10F);
            this.MenuStripTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserButtons,
            this.MarksButtons});
            this.MenuStripTeacher.Location = new System.Drawing.Point(0, 0);
            this.MenuStripTeacher.Name = "MenuStripTeacher";
            this.MenuStripTeacher.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.MenuStripTeacher.Size = new System.Drawing.Size(884, 24);
            this.MenuStripTeacher.TabIndex = 59;
            this.MenuStripTeacher.Text = "menuStrip1";
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
            // MarksButtons
            // 
            this.MarksButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddMark,
            this.ButtonEditMark,
            this.ButtonDeleteMark});
            this.MarksButtons.Name = "MarksButtons";
            this.MarksButtons.Size = new System.Drawing.Size(66, 22);
            this.MarksButtons.Text = "Оценки";
            // 
            // ButtonAddMark
            // 
            this.ButtonAddMark.Name = "ButtonAddMark";
            this.ButtonAddMark.Size = new System.Drawing.Size(134, 22);
            this.ButtonAddMark.Text = "Добавить";
            this.ButtonAddMark.Click += new System.EventHandler(this.ButtonAddMark_Click);
            // 
            // ButtonEditMark
            // 
            this.ButtonEditMark.Name = "ButtonEditMark";
            this.ButtonEditMark.Size = new System.Drawing.Size(134, 22);
            this.ButtonEditMark.Text = "Изменить";
            this.ButtonEditMark.Click += new System.EventHandler(this.ButtonEditMark_Click);
            // 
            // ButtonDeleteMark
            // 
            this.ButtonDeleteMark.Name = "ButtonDeleteMark";
            this.ButtonDeleteMark.Size = new System.Drawing.Size(134, 22);
            this.ButtonDeleteMark.Text = "Удалить";
            this.ButtonDeleteMark.Click += new System.EventHandler(this.ButtonDeleteMark_Click);
            // 
            // FormTeacher
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
            this.Controls.Add(this.TableMarks);
            this.Controls.Add(this.LabelClassesList);
            this.Controls.Add(this.LabelMarksList);
            this.Controls.Add(this.MenuStripTeacher);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Teacher_FormClosing);
            this.Load += new System.EventHandler(this.Form_Teacher_Load);
            this.Shown += new System.EventHandler(this.FormTeacher_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormTeacher_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.TableStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMarks)).EndInit();
            this.MenuStripTeacher.ResumeLayout(false);
            this.MenuStripTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSchoolName;
        private System.Windows.Forms.DataGridView TableStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentsName;
        private System.Windows.Forms.DataGridView TableSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectName;
        private System.Windows.Forms.Label LabelStudentsList;
        private System.Windows.Forms.Label LabelSubjectsList;
        private System.Windows.Forms.DataGridView TableClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassCount;
        private System.Windows.Forms.DataGridView TableMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.Label LabelClassesList;
        private System.Windows.Forms.Label LabelMarksList;
        private System.Windows.Forms.MenuStrip MenuStripTeacher;
        private System.Windows.Forms.ToolStripMenuItem UserButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem MarksButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonAddMark;
        private System.Windows.Forms.ToolStripMenuItem ButtonEditMark;
        private System.Windows.Forms.ToolStripMenuItem ButtonDeleteMark;
    }
}