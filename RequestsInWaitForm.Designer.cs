namespace TurboStyle
{
    partial class RequestsInWaitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carVINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turbostyleDataSet = new TurboStyle.turbostyleDataSet();
            this.requestsTableAdapter = new TurboStyle.turbostyleDataSetTableAdapters.requestsTableAdapter();
            this.openCarInspectionFormButton = new System.Windows.Forms.Button();
            this.openEditorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbostyleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.carMarkDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.carVINDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(945, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "requestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "statusID";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "statusID";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carMarkDataGridViewTextBoxColumn
            // 
            this.carMarkDataGridViewTextBoxColumn.DataPropertyName = "CarMark";
            this.carMarkDataGridViewTextBoxColumn.HeaderText = "CarMark";
            this.carMarkDataGridViewTextBoxColumn.Name = "carMarkDataGridViewTextBoxColumn";
            this.carMarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "CarModel";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            this.carModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carVINDataGridViewTextBoxColumn
            // 
            this.carVINDataGridViewTextBoxColumn.DataPropertyName = "CarVIN";
            this.carVINDataGridViewTextBoxColumn.HeaderText = "CarVIN";
            this.carVINDataGridViewTextBoxColumn.Name = "carVINDataGridViewTextBoxColumn";
            this.carVINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "requests";
            this.requestsBindingSource.DataSource = this.turbostyleDataSet;
            // 
            // turbostyleDataSet
            // 
            this.turbostyleDataSet.DataSetName = "turbostyleDataSet";
            this.turbostyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // openCarInspectionFormButton
            // 
            this.openCarInspectionFormButton.Location = new System.Drawing.Point(865, 181);
            this.openCarInspectionFormButton.Name = "openCarInspectionFormButton";
            this.openCarInspectionFormButton.Size = new System.Drawing.Size(92, 23);
            this.openCarInspectionFormButton.TabIndex = 1;
            this.openCarInspectionFormButton.Text = "Далее";
            this.openCarInspectionFormButton.UseVisualStyleBackColor = true;
            this.openCarInspectionFormButton.Click += new System.EventHandler(this.OpenCarInspectionFormButton_Click);
            // 
            // openEditorButton
            // 
            this.openEditorButton.Location = new System.Drawing.Point(711, 181);
            this.openEditorButton.Name = "openEditorButton";
            this.openEditorButton.Size = new System.Drawing.Size(148, 23);
            this.openEditorButton.TabIndex = 5;
            this.openEditorButton.Text = "Редактировать заявку";
            this.openEditorButton.UseVisualStyleBackColor = true;
            this.openEditorButton.Click += new System.EventHandler(this.openEditorButton_Click);
            // 
            // RequestsInWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 222);
            this.Controls.Add(this.openEditorButton);
            this.Controls.Add(this.openCarInspectionFormButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RequestsInWaitForm";
            this.Text = "Заявки в ожидании";
            this.Load += new System.EventHandler(this.RequestsInWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbostyleDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private turbostyleDataSet turbostyleDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private turbostyleDataSetTableAdapters.requestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carVINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button openCarInspectionFormButton;
        private System.Windows.Forms.Button openEditorButton;
    }
}