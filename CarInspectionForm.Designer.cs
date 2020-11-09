namespace TurboStyle
{
    partial class CarInspectionForm
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
            this.InspectionResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.titileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criticalDefectsCheckBox = new System.Windows.Forms.CheckBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InspectionResultRichTextBox
            // 
            this.InspectionResultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InspectionResultRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InspectionResultRichTextBox.Location = new System.Drawing.Point(12, 53);
            this.InspectionResultRichTextBox.Name = "InspectionResultRichTextBox";
            this.InspectionResultRichTextBox.Size = new System.Drawing.Size(419, 152);
            this.InspectionResultRichTextBox.TabIndex = 1;
            this.InspectionResultRichTextBox.Text = "";
            // 
            // titileLabel
            // 
            this.titileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titileLabel.AutoSize = true;
            this.titileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titileLabel.Location = new System.Drawing.Point(163, 9);
            this.titileLabel.Name = "titileLabel";
            this.titileLabel.Size = new System.Drawing.Size(121, 20);
            this.titileLabel.TabIndex = 2;
            this.titileLabel.Text = "Осмотр кузова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат осмотра";
            // 
            // criticalDefectsCheckBox
            // 
            this.criticalDefectsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.criticalDefectsCheckBox.AutoSize = true;
            this.criticalDefectsCheckBox.Location = new System.Drawing.Point(12, 219);
            this.criticalDefectsCheckBox.Name = "criticalDefectsCheckBox";
            this.criticalDefectsCheckBox.Size = new System.Drawing.Size(187, 17);
            this.criticalDefectsCheckBox.TabIndex = 5;
            this.criticalDefectsCheckBox.Text = "Наличие критических дефектов";
            this.criticalDefectsCheckBox.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(346, 211);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 31);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(255, 211);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 31);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CarInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 264);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.criticalDefectsCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titileLabel);
            this.Controls.Add(this.InspectionResultRichTextBox);
            this.Name = "CarInspectionForm";
            this.Text = "Осмотр машины";
            this.Load += new System.EventHandler(this.CarInspectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InspectionResultRichTextBox;
        private System.Windows.Forms.Label titileLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox criticalDefectsCheckBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
    }
}