using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_topic_DB
{
    public partial class MainForm : Form
    {
        public string userStatus = "";
        public MainForm(string stat)
        {
            userStatus = stat;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            status.Text = userStatus;
        }

        private void fillingButton_Click(object sender, EventArgs e)
        {
            if (userStatus == "admin")
            {
                FillingTables ft = new();
                Close();
                ft.Show();
            }
            else
            {
                MessageBox.Show("Вы не имеете доступа к этой странице");
            }
        }

        

        private void showTables_Click(object sender, EventArgs e)
        {
            ShowTables sh = new(userStatus);
            sh.Show();
            Close();
        }
        
        private void relatedTablesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RelatedTables rt = new(userStatus);
            rt.Show();
        }

        private void SalaryQuantityButton_Click(object sender, EventArgs e)
        {
            Close();
            SalaryQuantity sq = new(userStatus);
            sq.Show();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new();
            f.Show();
        }

        private void FiredListButton_Click(object sender, EventArgs e)
        {
            if (userStatus == "user")
            {
                MessageBox.Show("У вас нет прав доступа к этой странице");
            }
            else
            {
                Close();
                FiredList fl = new(userStatus);
                fl.Show();
            }
        }
    }
}
