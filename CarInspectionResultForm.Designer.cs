namespace TurboStyle
{
    partial class CarInspectionResultForm
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
            this.inspectionResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.refusalButton = new System.Windows.Forms.Button();
            this.inWorkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inspectionResultRichTextBox
            // 
            this.inspectionResultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspectionResultRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.inspectionResultRichTextBox.Name = "inspectionResultRichTextBox";
            this.inspectionResultRichTextBox.ReadOnly = true;
            this.inspectionResultRichTextBox.Size = new System.Drawing.Size(554, 280);
            this.inspectionResultRichTextBox.TabIndex = 0;
            this.inspectionResultRichTextBox.Text = "";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(484, 298);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(82, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // refusalButton
            // 
            this.refusalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refusalButton.Location = new System.Drawing.Point(396, 298);
            this.refusalButton.Name = "refusalButton";
            this.refusalButton.Size = new System.Drawing.Size(82, 23);
            this.refusalButton.TabIndex = 2;
            this.refusalButton.Text = "В отказ";
            this.refusalButton.UseVisualStyleBackColor = true;
            this.refusalButton.Visible = false;
            this.refusalButton.Click += new System.EventHandler(this.refusalButton_Click);
            // 
            // inWorkButton
            // 
            this.inWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inWorkButton.Location = new System.Drawing.Point(484, 298);
            this.inWorkButton.Name = "inWorkButton";
            this.inWorkButton.Size = new System.Drawing.Size(82, 23);
            this.inWorkButton.TabIndex = 3;
            this.inWorkButton.Text = "В работу";
            this.inWorkButton.UseVisualStyleBackColor = true;
            this.inWorkButton.Click += new System.EventHandler(this.inWorkButton_Click);
            // 
            // CarInspectionResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 333);
            this.Controls.Add(this.inWorkButton);
            this.Controls.Add(this.refusalButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.inspectionResultRichTextBox);
            this.Name = "CarInspectionResultForm";
            this.Text = "Результат осмотра";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inspectionResultRichTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button refusalButton;
        private System.Windows.Forms.Button inWorkButton;
    }
}