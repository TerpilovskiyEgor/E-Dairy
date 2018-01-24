namespace eDairy
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.MenuStripStudent = new System.Windows.Forms.MenuStrip();
            this.UserButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSchoolName = new System.Windows.Forms.Label();
            this.TableSubjects = new System.Windows.Forms.DataGridView();
            this.ColumnSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelSubjectsList = new System.Windows.Forms.Label();
            this.TableMarks = new System.Windows.Forms.DataGridView();
            this.ColumnTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelMarksList = new System.Windows.Forms.Label();
            this.MenuStripStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripStudent
            // 
            this.MenuStripStudent.Font = new System.Drawing.Font("Calibri", 10F);
            this.MenuStripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserButtons});
            this.MenuStripStudent.Location = new System.Drawing.Point(0, 0);
            this.MenuStripStudent.Name = "MenuStripStudent";
            this.MenuStripStudent.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.MenuStripStudent.Size = new System.Drawing.Size(884, 24);
            this.MenuStripStudent.TabIndex = 60;
            this.MenuStripStudent.Text = "menuStrip1";
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
            this.LabelSchoolName.TabIndex = 61;
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
            this.TableSubjects.Location = new System.Drawing.Point(30, 76);
            this.TableSubjects.Margin = new System.Windows.Forms.Padding(1);
            this.TableSubjects.MultiSelect = false;
            this.TableSubjects.Name = "TableSubjects";
            this.TableSubjects.ReadOnly = true;
            this.TableSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSubjects.Size = new System.Drawing.Size(373, 364);
            this.TableSubjects.TabIndex = 63;
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
            // LabelSubjectsList
            // 
            this.LabelSubjectsList.AutoSize = true;
            this.LabelSubjectsList.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelSubjectsList.Location = new System.Drawing.Point(26, 52);
            this.LabelSubjectsList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelSubjectsList.Name = "LabelSubjectsList";
            this.LabelSubjectsList.Size = new System.Drawing.Size(94, 23);
            this.LabelSubjectsList.TabIndex = 62;
            this.LabelSubjectsList.Text = "Предметы";
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
            this.TableMarks.Location = new System.Drawing.Point(534, 76);
            this.TableMarks.Margin = new System.Windows.Forms.Padding(1);
            this.TableMarks.MultiSelect = false;
            this.TableMarks.Name = "TableMarks";
            this.TableMarks.ReadOnly = true;
            this.TableMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableMarks.Size = new System.Drawing.Size(309, 364);
            this.TableMarks.TabIndex = 65;
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
            // LabelMarksList
            // 
            this.LabelMarksList.AutoSize = true;
            this.LabelMarksList.Font = new System.Drawing.Font("Calibri", 14F);
            this.LabelMarksList.Location = new System.Drawing.Point(530, 52);
            this.LabelMarksList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelMarksList.Name = "LabelMarksList";
            this.LabelMarksList.Size = new System.Drawing.Size(71, 23);
            this.LabelMarksList.TabIndex = 64;
            this.LabelMarksList.Text = "Оценки";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.TableMarks);
            this.Controls.Add(this.LabelMarksList);
            this.Controls.Add(this.TableSubjects);
            this.Controls.Add(this.LabelSubjectsList);
            this.Controls.Add(this.LabelSchoolName);
            this.Controls.Add(this.MenuStripStudent);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Student_FormClosing);
            this.Load += new System.EventHandler(this.Form_Student_Load);
            this.Shown += new System.EventHandler(this.FormStudent_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormStudent_MouseClick);
            this.MenuStripStudent.ResumeLayout(false);
            this.MenuStripStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripStudent;
        private System.Windows.Forms.ToolStripMenuItem UserButtons;
        private System.Windows.Forms.ToolStripMenuItem ButtonSettings;
        private System.Windows.Forms.Label LabelSchoolName;
        private System.Windows.Forms.DataGridView TableSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectName;
        private System.Windows.Forms.Label LabelSubjectsList;
        private System.Windows.Forms.DataGridView TableMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.Label LabelMarksList;
    }
}