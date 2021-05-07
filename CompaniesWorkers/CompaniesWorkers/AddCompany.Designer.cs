
namespace CompaniesWorkers
{
    partial class AddCompany
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
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditStruct = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(12, 33);
            this.EditName.Name = "EditName";
            this.EditName.PlaceholderText = "Наименование";
            this.EditName.Size = new System.Drawing.Size(237, 23);
            this.EditName.TabIndex = 0;
            // 
            // EditStruct
            // 
            this.EditStruct.Location = new System.Drawing.Point(12, 76);
            this.EditStruct.Name = "EditStruct";
            this.EditStruct.PlaceholderText = "Организационно-правовая форма";
            this.EditStruct.Size = new System.Drawing.Size(237, 23);
            this.EditStruct.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(56, 126);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(124, 26);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Добавить";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(56, 172);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(124, 27);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 236);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.EditStruct);
            this.Controls.Add(this.EditName);
            this.Name = "AddCompany";
            this.Text = "Добавить компанию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditName;
        private System.Windows.Forms.TextBox EditStruct;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}