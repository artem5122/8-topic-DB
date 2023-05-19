
namespace _8_topic_DB
{
    partial class ShowTables
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
            this.tableChoosing = new System.Windows.Forms.ComboBox();
            this.tableForFilling = new System.Windows.Forms.DataGridView();
            this.previousPage = new System.Windows.Forms.Button();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.AgeSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableForFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 15);
            this.status.TabIndex = 1;
            this.status.Text = "admin or not";
            // 
            // tableChoosing
            // 
            this.tableChoosing.FormattingEnabled = true;
            this.tableChoosing.Items.AddRange(new object[] {
            "Staff",
            "Employee"});
            this.tableChoosing.Location = new System.Drawing.Point(94, 6);
            this.tableChoosing.Name = "tableChoosing";
            this.tableChoosing.Size = new System.Drawing.Size(242, 23);
            this.tableChoosing.TabIndex = 2;
            this.tableChoosing.Text = "Выберите таблицу для редактирования";
            this.tableChoosing.SelectedIndexChanged += new System.EventHandler(this.tableChoosing_SelectedIndexChanged);
            // 
            // tableForFilling
            // 
            this.tableForFilling.AllowDrop = true;
            this.tableForFilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForFilling.Location = new System.Drawing.Point(6, 49);
            this.tableForFilling.Name = "tableForFilling";
            this.tableForFilling.RowTemplate.Height = 25;
            this.tableForFilling.Size = new System.Drawing.Size(788, 352);
            this.tableForFilling.TabIndex = 3;
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(713, 5);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 23);
            this.previousPage.TabIndex = 4;
            this.previousPage.Text = "Назад";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(360, 9);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(100, 23);
            this.NameSearch.TabIndex = 5;
            // 
            // AgeSearch
            // 
            this.AgeSearch.Location = new System.Drawing.Point(466, 9);
            this.AgeSearch.Name = "AgeSearch";
            this.AgeSearch.Size = new System.Drawing.Size(100, 23);
            this.AgeSearch.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgeSearch);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.tableForFilling);
            this.Controls.Add(this.tableChoosing);
            this.Controls.Add(this.status);
            this.Name = "ShowTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowTables";
            this.Load += new System.EventHandler(this.ShowTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableForFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox tableChoosing;
        private System.Windows.Forms.DataGridView tableForFilling;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.TextBox AgeSearch;
        private System.Windows.Forms.Button button1;
    }
}