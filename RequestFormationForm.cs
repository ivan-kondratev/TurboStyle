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
    public partial class RequestFormationForm : Form
    {
        public string whichForm;
        public RequestFormationForm()
        {
            InitializeComponent();
        }

        private void carBrandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!((c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') || (c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я')))
            {
                if (c != 8 && c != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я'))
            {
                if (c != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void formationButton_Click(object sender, EventArgs e)
        {
            ///проверка полей ввода на пустоту
            if (string.IsNullOrEmpty(carBrandTextBox.Text))
            {
                MessageBox.Show("Поле марки автомобиля не должно быть пустым!");
                return;
            }
            if (string.IsNullOrEmpty(carModelTextBox.Text))
            {
                MessageBox.Show("Поле модели автомобиля не должно быть пустым!");
                return;
            }
            if (string.IsNullOrEmpty(VINTextBox.Text))
            {
                MessageBox.Show("Поле VIN автомобиля не должно быть пустым!");
                return;
            }
            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                MessageBox.Show("Поле фамилии не должно быть пустым!");
                return;
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Поле имени не должно быть пустым!");
                return;
            }
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Поле номер телефона не должно быть пустым!");
                return;
            }
            ///вставка в таблицу заявок
            string query;
            if (whichForm == "work" || whichForm == "wait")
            {
                if (string.IsNullOrEmpty(patronymicTextBox.Text))
                {
                    query = "UPDATE `turbostyle`.`requests` SET `CarMark` = @CarMark, `CarModel` = @CarModel, `CarVIN` = @CarVIN," +
                        " `LastName` = @LastName, `FirstName` = @FirstName, `PhoneNumber` = @PhoneNumber WHERE (`requestID` = @requestID);";
                }
                else
                {
                    query = "UPDATE `turbostyle`.`requests` SET `CarMark` = @CarMark, `CarModel` = @CarModel, `CarVIN` = @CarVIN," +
                        " `LastName` = @LastName, `FirstName` = @FirstName, `Patronymic` = @Patronymic, `PhoneNumber` = @PhoneNumber WHERE (`requestID` = @requestID);";
                }
                Program.cn.Open();
                Program.cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Program.cn);
                Program.cmd.Parameters.AddWithValue("@StatusID", "0");
                Program.cmd.Parameters.AddWithValue("@CarMark", carBrandTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@CarModel", carModelTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@CarVIN", VINTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@LastName", surnameTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@FirstName", nameTextBox.Text);
                if (!string.IsNullOrEmpty(patronymicTextBox.Text))
                {
                    Program.cmd.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                }
                Program.cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                if (whichForm == "work")
                {
                    Program.cmd.Parameters.AddWithValue("@requestID", RequestsInWorkForm.requestID);
                }
                else if (whichForm == "wait")
                {
                    Program.cmd.Parameters.AddWithValue("@requestID", RequestsInWaitForm.requestID);
                }
                Program.cmd.ExecuteNonQuery();
                Program.cn.Close();
                MessageBox.Show("Заявка успешно отредактированна!");
            }
            else
            {
                if (string.IsNullOrEmpty(patronymicTextBox.Text))
                {
                    query = "INSERT INTO requests (statusID, CarMark, CarModel, CarVIN, LastName, FirstName, PhoneNumber)" +
                    "VALUES (@StatusID, @CarMark, @CarModel, @CarVIN, @LastName, @FirstName, @PhoneNumber);";
                }
                else
                {
                    query = "INSERT INTO requests (statusID, CarMark, CarModel, CarVIN, LastName, FirstName, Patronymic, PhoneNumber)" +
                    "VALUES (@StatusID, @CarMark, @CarModel, @CarVIN, @LastName, @FirstName, @Patronymic, @PhoneNumber);";
                }
                Program.cn.Open();
                Program.cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Program.cn);
                Program.cmd.Parameters.AddWithValue("@StatusID", "0");
                Program.cmd.Parameters.AddWithValue("@CarMark", carBrandTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@CarModel", carModelTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@CarVIN", VINTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@LastName", surnameTextBox.Text);
                Program.cmd.Parameters.AddWithValue("@FirstName", nameTextBox.Text);
                if (!string.IsNullOrEmpty(patronymicTextBox.Text))
                {
                    Program.cmd.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                }
                Program.cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                Program.cmd.ExecuteNonQuery();
                Program.cn.Close();

                MessageBox.Show("Заявка создана успешно!");
            }
            Close();
        }


        private void VINTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c >= 'A' && c <= 'Z' || char.IsDigit(c)))
            {
                if (c != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
