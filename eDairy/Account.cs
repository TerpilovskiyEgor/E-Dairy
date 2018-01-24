using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDairy
{
    class Account : Primary
    {
        //----------------------------------------------------------- Class properties
        public string Login { get; private set; }
        private string Password { get; set; }

        //----------------------------------------------------------- Class constructor
        public Account(string name, string login, string pass, Guid? id) : base(name, id)
        {
            Login = login;
            Password = pass;
        }

        //----------------------------------------------------------- Class Methods
        internal void ChangeLogin(string newlogin)
        {
            if (newlogin.Contains("'"))
                newlogin = newlogin.Replace("'", "\"");
            if (DBControl.Edit(newlogin))
                Login = newlogin;
            else
                MessageBox.Show("Логин не был изменен, введите другой логин","Данный логин уже занят", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void ChangePassword(string oldpass, string newpass)
        {
            if (Password == oldpass)
                Password = newpass;
        }

        internal string GetPassword(string pass)
        {
            if (pass == Password)
                return Password;
            else return "****Confidential****";
        }
    }
}