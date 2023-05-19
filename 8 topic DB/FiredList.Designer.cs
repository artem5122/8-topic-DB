
namespace _8_topic_DB
{
    partial class FiredList
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
            this.tableForFilling = new System.Windows.Forms.DataGridView();
            this.previousPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableForFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(13, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 15);
            this.status.TabIndex = 0;
            this.status.Text = "label1";
            // 
            // tableForFilling
            // 
            this.tableForFilling.AllowDrop = true;
            this.tableForFilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForFilling.Location = new System.Drawing.Point(6, 49);
            this.tableForFilling.Name = "tableForFilling";
            this.tableForFilling.RowTemplate.Height = 25;
            this.tableForFilling.Size = new System.Drawing.Size(788, 352);
            this.tableForFilling.TabIndex = 4;
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(697, 9);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 23);
            this.previousPage.TabIndex = 5;
            this.previousPage.Text = "Назад";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // FiredList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.tableForFilling);
            this.Controls.Add(this.status);
            this.Name = "FiredList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiredList";
            this.Load += new System.EventHandler(this.FiredList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableForFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridView tableForFilling;
        private System.Windows.Forms.Button previousPage;
    }
}