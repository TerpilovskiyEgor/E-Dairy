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
    partial class FormList : Form
    {
        Class_Subject Class_subject;
        Class _Class;
        Point position = new Point();
        int x, y;
        Pen p = new Pen(Color.Black, 1);
        Graphics gr;
        Rectangle rect;

        public FormList(Class _class)
        {
            InitializeComponent();
            rect = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            gr = CreateGraphics();
            _Class = _class;
            foreach (var sbjct in Subject.Subjects.Values)
                Table.Rows.Add(sbjct.Id, sbjct.Name);
            List<DataGridViewRow> extraRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in Table.Rows)
                foreach (var sbjct in _class.Subjects)
                    if ((Guid)row.Cells[0].Value == sbjct.Id)
                        extraRows.Add(row);
            foreach (var rw in extraRows)
                Table.Rows.Remove(rw);
            LabelChoose.Text += "предметы класса " + _class.Name;
        }

        public FormList(Class_Subject class_subject)
        {
            InitializeComponent();
            rect = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            gr = CreateGraphics();
            Class_subject = class_subject;
            foreach (var tchr in Teacher.Teachers.Values)
                Table.Rows.Add(tchr.Id, tchr.Name);
            List<DataGridViewRow> extraRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in Table.Rows)
                foreach (var tchr in Class_subject.Teachers)
                    if ((Guid)row.Cells[0].Value == tchr.Id)
                        extraRows.Add(row);
            foreach (var rw in extraRows)
                Table.Rows.Remove(rw);
            ColumnName.HeaderText = "Ф.И.О.";
            LabelChoose.Text += string.Format("учителя предмета \"{0}\" в классе {1}", Class_subject.Subject.Name, Class_subject.Class.Name);
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            Table.ClearSelection();
        }

        private void FormList_Shown(object sender, EventArgs e)
        {
            gr.DrawRectangle(p, rect);
        }

        #region Form Motion Methods

        private void TimerMotion_Tick(object sender, EventArgs e)
        {
            position.X = MousePosition.X - x;
            position.Y = MousePosition.Y - y;
            Location = position;
            gr.DrawRectangle(p, rect);
        }

        private void FormList_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X - Location.X;
            y = MousePosition.Y - Location.Y;
            TimerMotion.Enabled = true;
        }

        private void LabelChoose_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X - Location.X;
            y = MousePosition.Y - Location.Y;
            TimerMotion.Enabled = true;
        }

        private void LabelChoose_MouseUp(object sender, MouseEventArgs e)
        {
            TimerMotion.Enabled = false;
        }

        private void FormList_MouseUp(object sender, MouseEventArgs e)
        {
            TimerMotion.Enabled = false;
        }

        #endregion
    }
}
