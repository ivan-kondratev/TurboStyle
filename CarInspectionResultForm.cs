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
    public partial class CarInspectionResultForm : Form
    {
        int decision = 1;//1 - ok, 2 - not ok
        public CarInspectionResultForm() {
            InitializeComponent();
            Text += " " + RequestsInWaitForm.carMark + " " + RequestsInWaitForm.carModel + ", номер заявки: " +
               RequestsInWaitForm.requestID;

            for (int i = 0; i < CarInspectionForm.inspections.Length; i++)
            {
                inspectionResultRichTextBox.Text += CarInspectionForm.titleLabels[i] + ":\n";
                inspectionResultRichTextBox.Text += CarInspectionForm.inspections[i] + "\n";
                inspectionResultRichTextBox.Text += "Наличие критических дефектов: ";
                if (CarInspectionForm.criticalDefects[i] == true)
                {
                    inspectionResultRichTextBox.Text += "да\n\n";
                    refusalButton.Visible = true;
                    inWorkButton.Visible = false;
                    decision = 0;
                }
                else
                {
                    inspectionResultRichTextBox.Text += "нет\n\n";
                }
            }
        }

        private void inWorkButton_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = string.Format("UPDATE `turbostyle`.`requests` SET `statusID` = '1' WHERE (`requestID` = '{0}')", RequestsInWaitForm.requestID);
            Program.cmd.Prepare();
            Program.cmd.ExecuteNonQuery();
            Program.cmd.CommandText = string.Format("INSERT INTO `turbostyle`.`inspections` (`result`, `requestID`, `decision`) VALUES ('{0}', '{1}', '{2}')",
                inspectionResultRichTextBox.Text,RequestsInWaitForm.requestID,decision);
            Program.cmd.Prepare();
            Program.cmd.ExecuteNonQuery();
            Program.cn.Close();
            MessageBox.Show("Заявка переведена в работу!");
            Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = string.Format("INSERT INTO `turbostyle`.`inspections` (`result`, `requestID`, `decision`) VALUES ('{0}', '{1}', '{2}')",
                inspectionResultRichTextBox.Text, RequestsInWaitForm.requestID, decision);
            Program.cmd.Prepare();
            Program.cmd.ExecuteNonQuery();
            Program.cn.Close();
            MessageBox.Show("Заявка осталась в режиме ожидания.");
            Close();
        }

        private void refusalButton_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new MySql.Data.MySqlClient.MySqlCommand();
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = string.Format("UPDATE `turbostyle`.`requests` SET `statusID` = '2' WHERE (`requestID` = '{0}')", RequestsInWaitForm.requestID);
            Program.cmd.Prepare();
            Program.cmd.ExecuteNonQuery();
            Program.cmd.CommandText = string.Format("INSERT INTO `turbostyle`.`inspections` (`result`, `requestID`, `decision`) VALUES ('{0}', '{1}', '{2}')",
                inspectionResultRichTextBox.Text, RequestsInWaitForm.requestID, decision);
            Program.cmd.Prepare();
            Program.cmd.ExecuteNonQuery();
            Program.cn.Close();
            MessageBox.Show("Переведение заявки в отказ успешно произведено.");
            Close();
        }
    }
}
