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
    public partial class FormSettings : Form
    {
        Point position = new Point();
        int x, y;
        Pen p = new Pen(Color.Black, 1);
        Graphics gr;
        Rectangle rect;
        private string Password;

        public FormSettings(string name, string login, string pass)
        {
            InitializeComponent();
            rect = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            gr = CreateGraphics();
            TextBoxName.Text = name;
            TextBoxLogin.Text = login;
            Password = pass;
        }

        private void TextBoxOldPass_MouseHover(object sender, EventArgs e)
        {
            TextBoxOldPass.UseSystemPasswordChar = false;
        }

        private void TextBoxOldPass_MouseLeave(object sender, EventArgs e)
        {
            TextBoxOldPass.UseSystemPasswordChar = true;
        }

        private void TextBoxNewPass_MouseHover(object sender, EventArgs e)
        {
            TextBoxNewPass.UseSystemPasswordChar = false;
        }

        private void TextBoxNewPass_MouseLeave(object sender, EventArgs e)
        {
            TextBoxNewPass.UseSystemPasswordChar = true;
        }

        private void TextBoxConfirmPass_MouseHover(object sender, EventArgs e)
        {
            TextBoxConfirmPass.UseSystemPasswordChar = false;
        }

        private void TextBoxConfirmPass_MouseLeave(object sender, EventArgs e)
        {
            TextBoxConfirmPass.UseSystemPasswordChar = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxOldPass.Text != "" || TextBoxNewPass.Text != "" || TextBoxConfirmPass.Text != "")
            {
                if (TextBoxOldPass.Text == "" || TextBoxNewPass.Text == "" || TextBoxConfirmPass.Text == "")
                    MessageBox.Show("Для изменения пароля, заполните все поля", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (TextBoxNewPass.Text != TextBoxConfirmPass.Text)
                        MessageBox.Show("Новый пароль не верно повторен", "Пароль не повторен", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (TextBoxOldPass.Text != Password)
                            MessageBox.Show("Не верный прежний пароль. Введите верный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            DialogResult = DialogResult.OK;
                    }
                }
            }
            else
                DialogResult = DialogResult.OK;
        }

        private void TextBoxOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }

        private void TextBoxNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }

        private void TextBoxConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39)
                e.Handled = true;
        }
        
        private void FormSettings_Shown(object sender, EventArgs e)
        {
            gr.DrawRectangle(p, rect);
        }

        #region Form Motion Methods

        private void FormSettings_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X - Location.X;
            y = MousePosition.Y - Location.Y;
            TimerMotion.Enabled = true;
        }

        private void FormSettings_MouseUp(object sender, MouseEventArgs e)
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