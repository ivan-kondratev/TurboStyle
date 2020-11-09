namespace TurboStyle
{
    partial class MainMenuForm
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
            this.createRequestButton = new System.Windows.Forms.Button();
            this.carInspectionButton = new System.Windows.Forms.Button();
            this.requestsInWorkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createRequestButton
            // 
            this.createRequestButton.Location = new System.Drawing.Point(79, 53);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(139, 40);
            this.createRequestButton.TabIndex = 0;
            this.createRequestButton.Text = "Создать заявку";
            this.createRequestButton.UseVisualStyleBackColor = true;
            this.createRequestButton.Click += new System.EventHandler(this.createRequestButton_Click);
            // 
            // carInspectionButton
            // 
            this.carInspectionButton.Location = new System.Drawing.Point(79, 141);
            this.carInspectionButton.Name = "carInspectionButton";
            this.carInspectionButton.Size = new System.Drawing.Size(139, 40);
            this.carInspectionButton.TabIndex = 1;
            this.carInspectionButton.Text = "Осмотр машины";
            this.carInspectionButton.UseVisualStyleBackColor = true;
            this.carInspectionButton.Click += new System.EventHandler(this.carInspectionButton_Click);
            // 
            // requestsInWorkButton
            // 
            this.requestsInWorkButton.Location = new System.Drawing.Point(79, 234);
            this.requestsInWorkButton.Name = "requestsInWorkButton";
            this.requestsInWorkButton.Size = new System.Drawing.Size(139, 40);
            this.requestsInWorkButton.TabIndex = 2;
            this.requestsInWorkButton.Text = "Заявки в работе";
            this.requestsInWorkButton.UseVisualStyleBackColor = true;
            this.requestsInWorkButton.Click += new System.EventHandler(this.requestsInWorkButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 352);
            this.Controls.Add(this.requestsInWorkButton);
            this.Controls.Add(this.carInspectionButton);
            this.Controls.Add(this.createRequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createRequestButton;
        private System.Windows.Forms.Button carInspectionButton;
        private System.Windows.Forms.Button requestsInWorkButton;
    }
}