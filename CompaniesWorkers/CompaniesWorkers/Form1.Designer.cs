
namespace CompaniesWorkers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Companies = new System.Windows.Forms.Button();
            this.Workers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Companies
            // 
            this.Companies.Location = new System.Drawing.Point(68, 44);
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(198, 46);
            this.Companies.TabIndex = 0;
            this.Companies.Text = "Список компаний";
            this.Companies.UseVisualStyleBackColor = true;
            this.Companies.Click += new System.EventHandler(this.Companies_Click);
            // 
            // Workers
            // 
            this.Workers.Location = new System.Drawing.Point(68, 148);
            this.Workers.Name = "Workers";
            this.Workers.Size = new System.Drawing.Size(198, 45);
            this.Workers.TabIndex = 1;
            this.Workers.Text = "Список работников";
            this.Workers.UseVisualStyleBackColor = true;
            this.Workers.Click += new System.EventHandler(this.Workers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 260);
            this.Controls.Add(this.Workers);
            this.Controls.Add(this.Companies);
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Companies;
        private System.Windows.Forms.Button Workers;
    }
}

