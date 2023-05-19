
namespace _8_topic_DB
{
    partial class SalaryQuantity
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
            this.status = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.previousPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(13, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 15);
            this.status.TabIndex = 0;
            this.status.Text = "admin or not";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(337, 41);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(100, 23);
            this.Salary.TabIndex = 1;
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            this.Salary.Leave += new System.EventHandler(this.Salary_Leave);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quantity.Location = new System.Drawing.Point(350, 151);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(375, 106);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество сотрудников с этой зарплатой";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(600, 128);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(694, 27);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 23);
            this.previousPage.TabIndex = 5;
            this.previousPage.Text = "Назад";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // SalaryQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.status);
            this.Name = "SalaryQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryQuantity";
            this.Load += new System.EventHandler(this.SalaryQuantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button previousPage;
    }
}