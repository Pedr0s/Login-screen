using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;




namespace WindowsFormsApp1
{
    public partial class formLoginScreen : Form
    {
        public formLoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Logincorrecct = true;
            if (Logincorrecct)
            {
                formMain form2 = new formMain();
                form2.Visible = true;

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login_functions f = new Login_functions();
            f.Adduser(txtUsername.Text, txtPassword.Text);
        }
    }
}
