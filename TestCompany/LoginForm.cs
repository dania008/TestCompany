using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCompany
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, EventArgs e)
        {
            WorkPlace workPlace = new WorkPlace();
            Form loginForm = Application.OpenForms[0];
            DbSqlServerCompanyEntities1 dbSql = new DbSqlServerCompanyEntities1();
            foreach (var item in dbSql.Accesses)
            {
                if (LoginTxtBox.Text.Equals(item.login.Trim()) && PasswordTxtBox.Text.Equals(item.password.Trim()))
                {
                    loginForm.Hide();
                    workPlace.Show();
                }
            }
        }
    }
}
