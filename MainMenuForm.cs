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
    public partial class MainMenuForm : Form
    {
        RequestFormationForm requestForm;//форма создания заявки
        ///CarInspectionForm inspectionForm;//форма осмтотра машины
        RequestsInWorkForm inWorkForm;//форма заявок в работе
        RequestsInWaitForm inWaitForm;//форма заявок в ожидании
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void createRequestButton_Click(object sender, EventArgs e)
        {
            requestForm = new RequestFormationForm();
            requestForm.Show();
        }

        private void carInspectionButton_Click(object sender, EventArgs e)
        {
            inWaitForm = new RequestsInWaitForm();
            inWaitForm.Show();
        }

        private void requestsInWorkButton_Click(object sender, EventArgs e)
        {
            inWorkForm = new RequestsInWorkForm();
            inWorkForm.Show();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
