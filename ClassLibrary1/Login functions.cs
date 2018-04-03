using System;
using System.Collections.Generic;
using System.Text;
using Login;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;


namespace Login
{
    public class Login_functions
    {
        public bool Login(string Username, string Password)
        {

            return true;
        }
        public bool Adduser (string Username, string Password)
        {
            using (LoginContext Context = new LoginContext())
            {
                bool UniqueUsername = true;
                if (UniqueUsername)
                {
                Context.LoginDetails.Add(new LoginDetail() { Username = Username, Password = Password });
                return true;
                }
                else { MessageBox.Show("The username you provided is not unique."); return false; }


            }
        }
    }
}
