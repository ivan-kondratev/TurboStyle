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
    public partial class RequestsInWaitForm : Form
    {
        CarInspectionForm inspectionForm;//форма осмотра машины
        RequestFormationForm formationForm;//форма формирования/редактирования заявки

        public static int requestID;
        public static string carMark, carModel;

        public RequestsInWaitForm() {
            InitializeComponent();
        }

        private void RequestsInWait_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turbostyleDataSet.requests". При необходимости она может быть перемещена или удалена.
            requestsTableAdapter.FillByWait(turbostyleDataSet.requests);
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
                formationForm.whichForm = "wait";
            }
            else
            {
                MessageBox.Show("Заявка не выбрана!");
                return;
            }
        }

        private void OpenCarInspectionFormButton_Click(object sender, EventArgs e) {
            //MessageBox.Show(dataGridView1.CurrentCellAddress.IsEmpty.ToString());
            if (dataGridView1.CurrentCellAddress.IsEmpty)
            {
                requestID = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
                carMark = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                carModel = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            else
            {
                MessageBox.Show("Заявка не выбрана!");
                return;
            }
            Close();
            inspectionForm = new CarInspectionForm();
            inspectionForm.Show();
        }
    }
}
