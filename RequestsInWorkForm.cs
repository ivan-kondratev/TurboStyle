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
    public partial class RequestsInWorkForm : Form
    {
        public static int requestID;
        RequestFormationForm formationForm;//форма формирования/редактирования заявки
        public RequestsInWorkForm() {
            InitializeComponent();
        }

        private void RequestsInWorkForm_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turbostyleDataSet.requests". При необходимости она может быть перемещена или удалена.
            requestsTableAdapter.FillByWork(turbostyleDataSet.requests);

        }

        private void RequestsInWorkForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (AuthorizationForm.resultUserType == "a") {
                Application.Exit();
            }
        }

        private void inWaitButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.IsEmpty)
            {
                requestID = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
                Program.cn.Open();
                Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
                Program.cmd.Connection = Program.cn;
                Program.cmd.CommandText = string.Format("UPDATE `turbostyle`.`requests` SET `statusID` = '0' WHERE (`requestID` = '{0}')", RequestsInWorkForm.requestID);
                Program.cmd.Prepare();
                Program.cmd.ExecuteNonQuery();
                Program.cn.Close();
                requestsTableAdapter.FillByWork(turbostyleDataSet.requests);
                MessageBox.Show("Статус заявки переведён в 'ожидание'");
            }
            else
            {
                MessageBox.Show("Заявка не выбрана!");
                return;
            }
        }

        private void inCompleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.IsEmpty)
            {
                requestID = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
                Program.cn.Open();
                Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
                Program.cmd.Connection = Program.cn;
                Program.cmd.CommandText = string.Format("UPDATE `turbostyle`.`requests` SET `statusID` = '3' WHERE (`requestID` = '{0}')", RequestsInWorkForm.requestID);
                Program.cmd.Prepare();
                Program.cmd.ExecuteNonQuery();
                Program.cn.Close();
                requestsTableAdapter.FillByWork(turbostyleDataSet.requests);
                MessageBox.Show("Статус заявки переведён в 'завершённые'");
            }
            else
            {
                MessageBox.Show("Заявка не выбрана!");
                return;
            }

        }

        private void inRefusalButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.IsEmpty)
            {
                requestID = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
                Program.cn.Open();
                Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
                Program.cmd.Connection = Program.cn;
                Program.cmd.CommandText = string.Format("UPDATE `turbostyle`.`requests` SET `statusID` = '2' WHERE (`requestID` = '{0}')", RequestsInWorkForm.requestID);
                Program.cmd.Prepare();
                Program.cmd.ExecuteNonQuery();
                Program.cn.Close();
                requestsTableAdapter.FillByWork(turbostyleDataSet.requests);
                MessageBox.Show("Статус заявки переведён в 'отказ'");
            }
            else
            {
                MessageBox.Show("Заявка не выбрана!");
                return;
            }

        }

        private void openEditorButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.IsEmpty)
            {
                requestID = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
                formationForm = new RequestFormationForm();
                formationForm.Show();
                formationForm.Text = "Редактирование заявки";

                formationForm.carBrandTextBox.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.carModelTextBox.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.VINTextBox.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.surnameTextBox.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.nameTextBox.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.patronymicTextBox.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.phoneNumberTextBox.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                formationForm.whichForm = "work";
            }
            else
            {
                MessageBox.Show("Заявка не выбрана!");
                return;
            }
        }
    }
}
