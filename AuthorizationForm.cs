using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboStyle
{
    public partial class AuthorizationForm : Form
    {
        MainMenuForm menuForm;//форма главного меню
        RequestsInWorkForm inWorkForm;//форма заявок в работе
        public static string resultUserType;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(loginTextBox.Text)) {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text)) {
                MessageBox.Show("Введите пароль!");
                return;
            }
            Program.cn.Open();
            Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = string.Format("SELECT userLogin FROM turbostyle.users" +
                " WHERE userLogin = '{0}' AND userPassword = '{1}'",loginTextBox.Text,passwordTextBox.Text);
            Program.cmd.Prepare();
            Program.cmd.ExecuteNonQuery();
            string resultLogin = (string)Program.cmd.ExecuteScalar();
            if (resultLogin == loginTextBox.Text) {
                Hide();
                Program.cmd.CommandText = string.Format("SELECT userType FROM turbostyle.users" +
                    " WHERE userLogin = '{0}'",resultLogin);
                Program.cmd.Prepare();
                Program.cmd.ExecuteNonQuery();
                resultUserType = (string)Program.cmd.ExecuteScalar();
                if (resultUserType == "s") {
                    menuForm = new MainMenuForm();
                    menuForm.Show();
                }
                else if (resultUserType == "a") {
                    inWorkForm = new RequestsInWorkForm();
                    inWorkForm.Show();
                }
                Program.cn.Close();
            }
            else {
                MessageBox.Show("Неправильный логин или пароль!");
                Program.cn.Close();
                return;
            }
        }
    }
}
