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
    public partial class FormLogin : Form
    {
        Point position = new Point();
        int x, y;
        Pen p = new Pen(Color.Black, 1);
        Graphics gr;
        Rectangle rect;

        public FormLogin()
        {
            InitializeComponent();
            rect = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            gr = CreateGraphics();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            DBControl.Authorization(TextBoxLogin.Text, TextBoxPass.Text, this);
            TextBoxPass.Clear();
            TextBoxLogin.Clear();
            TextBoxLogin.Focus();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DBControl.OpenConnection();
            DBControl.Load();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }

        private void TextBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }

        private void TextBoxPass_MouseHover(object sender, EventArgs e)
        {
            TextBoxPass.UseSystemPasswordChar = false;
        }

        private void TextBoxPass_MouseLeave(object sender, EventArgs e)
        {
            TextBoxPass.UseSystemPasswordChar = true;
        }
        
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            gr.DrawRectangle(p, rect);
        }

        #region Form Motion Methods

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X - Location.X;
            y = MousePosition.Y - Location.Y;
            TimerMotion.Enabled = true;
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            TimerMotion.Enabled = false;
        }

        private void TimerMotion_Tick(object sender, EventArgs e)
        {
            position.X = MousePosition.X - x;
            position.Y = MousePosition.Y - y;
            Location = position;
            gr.DrawRectangle(p, rect);
        }

        #endregion
    }
}