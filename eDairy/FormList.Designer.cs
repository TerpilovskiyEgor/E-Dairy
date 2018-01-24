namespace eDairy
{
    partial class FormList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelChoose = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerMotion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(83, 262);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(79, 27);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.AutoSize = true;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(168, 262);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(79, 27);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "ОК";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // LabelChoose
            // 
            this.LabelChoose.AutoSize = true;
            this.LabelChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelChoose.Location = new System.Drawing.Point(0, 0);
            this.LabelChoose.Name = "LabelChoose";
            this.LabelChoose.Size = new System.Drawing.Size(68, 17);
            this.LabelChoose.TabIndex = 4;
            this.LabelChoose.Text = "Выберете ";
            this.LabelChoose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelChoose_MouseDown);
            this.LabelChoose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelChoose_MouseUp);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName});
            this.Table.Location = new System.Drawing.Point(11, 42);
            this.Table.Margin = new System.Windows.Forms.Padding(2);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(309, 215);
            this.Table.TabIndex = 47;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 44;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 91;
            // 
            // TimerMotion
            // 
            this.TimerMotion.Interval = 1;
            this.TimerMotion.Tick += new System.EventHandler(this.TimerMotion_Tick);
            // 
            // FormList
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.LabelChoose);
            this.Controls.Add(this.ButtonCancel);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.Shown += new System.EventHandler(this.FormList_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormList_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormList_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelChoose;
        private System.Windows.Forms.Timer TimerMotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        public System.Windows.Forms.DataGridView Table;
    }
}