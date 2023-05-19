
namespace _8_topic_DB
{
    partial class RelatedTables
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
            this.tableForFillingParent = new System.Windows.Forms.DataGridView();
            this.tableForFillingChild = new System.Windows.Forms.DataGridView();
            this.previousPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableForFillingParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableForFillingChild)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 15);
            this.status.TabIndex = 2;
            this.status.Text = "admin or not";
            // 
            // tableForFillingParent
            // 
            this.tableForFillingParent.AllowDrop = true;
            this.tableForFillingParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForFillingParent.Location = new System.Drawing.Point(12, 49);
            this.tableForFillingParent.Name = "tableForFillingParent";
            this.tableForFillingParent.RowTemplate.Height = 25;
            this.tableForFillingParent.Size = new System.Drawing.Size(481, 342);
            this.tableForFillingParent.TabIndex = 4;
            this.tableForFillingParent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableForFillingParent_CellMouseClick);
            // 
            // tableForFillingChild
            // 
            this.tableForFillingChild.AllowDrop = true;
            this.tableForFillingChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForFillingChild.Location = new System.Drawing.Point(513, 49);
            this.tableForFillingChild.Name = "tableForFillingChild";
            this.tableForFillingChild.RowTemplate.Height = 25;
            this.tableForFillingChild.Size = new System.Drawing.Size(275, 342);
            this.tableForFillingChild.TabIndex = 4;
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(693, 9);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 23);
            this.previousPage.TabIndex = 5;
            this.previousPage.Text = "Назад";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // RelatedTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.tableForFillingChild);
            this.Controls.Add(this.tableForFillingParent);
            this.Controls.Add(this.status);
            this.Name = "RelatedTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatedTables";
            this.Load += new System.EventHandler(this.RelatedTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableForFillingParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableForFillingChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridView tableForFillingParent;
        private System.Windows.Forms.DataGridView tableForFillingChild;
        private System.Windows.Forms.Button previousPage;
    }
}