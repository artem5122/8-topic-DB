
namespace _8_topic_DB
{
    partial class MainForm
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
            this.fillingButton = new System.Windows.Forms.Button();
            this.previousPage = new System.Windows.Forms.Button();
            this.showTables = new System.Windows.Forms.Button();
            this.relatedTablesButton = new System.Windows.Forms.Button();
            this.SalaryQuantityButton = new System.Windows.Forms.Button();
            this.FiredListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 15);
            this.status.TabIndex = 0;
            this.status.Text = "admin or not";
            // 
            // fillingButton
            // 
            this.fillingButton.Location = new System.Drawing.Point(102, 46);
            this.fillingButton.Name = "fillingButton";
            this.fillingButton.Size = new System.Drawing.Size(123, 62);
            this.fillingButton.TabIndex = 1;
            this.fillingButton.Text = "Вводим значения в таблицы";
            this.fillingButton.UseVisualStyleBackColor = true;
            this.fillingButton.Click += new System.EventHandler(this.fillingButton_Click);
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(681, 13);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 23);
            this.previousPage.TabIndex = 2;
            this.previousPage.Text = "Назад";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // showTables
            // 
            this.showTables.Location = new System.Drawing.Point(291, 46);
            this.showTables.Name = "showTables";
            this.showTables.Size = new System.Drawing.Size(123, 62);
            this.showTables.TabIndex = 3;
            this.showTables.Text = "Просмотр таблиц";
            this.showTables.UseVisualStyleBackColor = true;
            this.showTables.Click += new System.EventHandler(this.showTables_Click);
            // 
            // relatedTablesButton
            // 
            this.relatedTablesButton.Location = new System.Drawing.Point(475, 46);
            this.relatedTablesButton.Name = "relatedTablesButton";
            this.relatedTablesButton.Size = new System.Drawing.Size(123, 62);
            this.relatedTablesButton.TabIndex = 4;
            this.relatedTablesButton.Text = "Взаимосвязь таблиц";
            this.relatedTablesButton.UseVisualStyleBackColor = true;
            this.relatedTablesButton.Click += new System.EventHandler(this.relatedTablesButton_Click);
            // 
            // SalaryQuantityButton
            // 
            this.SalaryQuantityButton.Location = new System.Drawing.Point(193, 143);
            this.SalaryQuantityButton.Name = "SalaryQuantityButton";
            this.SalaryQuantityButton.Size = new System.Drawing.Size(123, 62);
            this.SalaryQuantityButton.TabIndex = 5;
            this.SalaryQuantityButton.Text = "Кол-во текущих сотрудников с определённой зарплатой";
            this.SalaryQuantityButton.UseVisualStyleBackColor = true;
            this.SalaryQuantityButton.Click += new System.EventHandler(this.SalaryQuantityButton_Click);
            // 
            // FiredListButton
            // 
            this.FiredListButton.Location = new System.Drawing.Point(382, 143);
            this.FiredListButton.Name = "FiredListButton";
            this.FiredListButton.Size = new System.Drawing.Size(123, 62);
            this.FiredListButton.TabIndex = 6;
            this.FiredListButton.Text = "Список уволеных";
            this.FiredListButton.UseVisualStyleBackColor = true;
            this.FiredListButton.Click += new System.EventHandler(this.FiredListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiredListButton);
            this.Controls.Add(this.SalaryQuantityButton);
            this.Controls.Add(this.relatedTablesButton);
            this.Controls.Add(this.showTables);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.fillingButton);
            this.Controls.Add(this.status);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button fillingButton;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Button showTables;
        private System.Windows.Forms.Button relatedTablesButton;
        private System.Windows.Forms.Button SalaryQuantityButton;
        private System.Windows.Forms.Button FiredListButton;
    }
}