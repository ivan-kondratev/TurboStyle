namespace TurboStyle
{
    partial class RequestFormationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formationButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(143, 12);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(112, 20);
            this.carBrandTextBox.TabIndex = 0;
            this.carBrandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carBrandTextBox_KeyPress);
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(143, 38);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(112, 20);
            this.carModelTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(143, 90);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(112, 20);
            this.surnameTextBox.TabIndex = 3;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(143, 116);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(112, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Марка ТС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Модель ТС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VIN номер ТС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(143, 142);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(112, 20);
            this.patronymicTextBox.TabIndex = 5;
            this.patronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер телефона";
            // 
            // formationButton
            // 
            this.formationButton.Location = new System.Drawing.Point(96, 208);
            this.formationButton.Name = "formationButton";
            this.formationButton.Size = new System.Drawing.Size(138, 38);
            this.formationButton.TabIndex = 14;
            this.formationButton.Text = "Сформировать";
            this.formationButton.UseVisualStyleBackColor = true;
            this.formationButton.Click += new System.EventHandler(this.formationButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(143, 171);
            this.phoneNumberTextBox.Mask = "(999) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(112, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // VINTextBox
            // 
            this.VINTextBox.Location = new System.Drawing.Point(143, 64);
            this.VINTextBox.MaxLength = 17;
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(112, 20);
            this.VINTextBox.TabIndex = 2;
            this.VINTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VINTextBox_KeyPress);
            // 
            // RequestFormationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 269);
            this.Controls.Add(this.VINTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.formationButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.carBrandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestFormationForm";
            this.Text = "Формирование заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button formationButton;
        public System.Windows.Forms.TextBox carBrandTextBox;
        public System.Windows.Forms.TextBox carModelTextBox;
        public System.Windows.Forms.TextBox surnameTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox patronymicTextBox;
        public System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        public System.Windows.Forms.TextBox VINTextBox;
    }
}