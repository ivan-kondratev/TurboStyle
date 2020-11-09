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
    public partial class CarInspectionForm : Form
    {
        public static string[] inspections;
        public static string[] titleLabels;
        public static bool[] criticalDefects;
        int i;
        CarInspectionResultForm resultForm;//форма результата осмотра
        private void NextButton_Click(object sender, EventArgs e)
        {
            inspections[i] = InspectionResultRichTextBox.Text;
            criticalDefects[i] = criticalDefectsCheckBox.Checked;
            i++;
            if (i > 0)
            {
                backButton.Enabled = true;
            }
            if (i == 3)
            {
                resultForm = new CarInspectionResultForm();
                Close();
                resultForm.Show();
            }
            else
            {
                InspectionResultRichTextBox.Text = inspections[i];
                criticalDefectsCheckBox.Checked = criticalDefects[i];
                titileLabel.Text = titleLabels[i];
            }
        }

        public CarInspectionForm()
        {
            InitializeComponent();
            Text += " " + RequestsInWaitForm.carMark + " " + RequestsInWaitForm.carModel + ", номер заявки: " +
               RequestsInWaitForm.requestID;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            inspections[i] = InspectionResultRichTextBox.Text;
            criticalDefects[i] = criticalDefectsCheckBox.Checked;
            i--;
            if (i == 0)
            {
                backButton.Enabled = false;
            }
            InspectionResultRichTextBox.Text = inspections[i];
            criticalDefectsCheckBox.Checked = criticalDefects[i];
            titileLabel.Text = titleLabels[i];

        }

        private void CarInspectionForm_Load(object sender, EventArgs e)
        {
            inspections = new string[3];//текстовые поля осмотра частей авто
            titleLabels = new string[] { "Осмотр кузова", "Осмтор двигателя и ходовой", "Осмотр электрики и диагностика" };
            criticalDefects = new bool[3];//критические поломки частей авто
            i = 0;
        }
    }
}
