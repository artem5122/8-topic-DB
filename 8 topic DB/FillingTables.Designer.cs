
namespace _8_topic_DB
{
    partial class FillingTables
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
            this.tableChoosing = new System.Windows.Forms.ComboBox();
            this.tableForFilling = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.previousPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableForFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // tableChoosing
            // 
            this.tableChoosing.FormattingEnabled = true;
            this.tableChoosing.Items.AddRange(new object[] {
            "Staff",
            "Employee"});
            this.tableChoosing.Location = new System.Drawing.Point(12, 12);
            this.tableChoosing.Name = "tableChoosing";
            this.tableChoosing.Size = new System.Drawing.Size(272, 23);
            this.tableChoosing.TabIndex = 0;
            this.tableChoosing.Text = "Выберите таблицу для редактирования";
            this.tableChoosing.SelectedIndexChanged += new System.EventHandler(this.tableChoosing_SelectedIndexChanged);
            // 
            // tableForFilling
            // 
            this.tableForFilling.AllowDrop = true;
            this.tableForFilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForFilling.Location = new System.Drawing.Point(0, 86);
            this.tableForFilling.Name = "tableForFilling";
            this.tableForFilling.RowTemplate.Height = 25;
            this.tableForFilling.Size = new System.Drawing.Size(788, 352);
            this.tableForFilling.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(568, 11);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(445, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(700, 11);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 23);
            this.previousPage.TabIndex = 3;
            this.previousPage.Text = "Назад";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // FillingTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.tableForFilling);
            this.Controls.Add(this.tableChoosing);
            this.Name = "FillingTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillingTables";
            this.Load += new System.EventHandler(this.FillingTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableForFilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tableChoosing;
        private System.Windows.Forms.DataGridView tableForFilling;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button previousPage;
    }
}