using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_topic_DB
{
    public partial class SalaryQuantity : Form
    {
        public string userStatus = "";
        public SalaryQuantity(string stat)
        {
            userStatus = stat;
            InitializeComponent();
        }

        private void SalaryQuantity_Load(object sender, EventArgs e)
        {
            status.Text = userStatus;

            
        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Salary_Leave(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"exec SalaryQuantity {int.Parse(Salary.Text)}";

            adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
            adapter.Fill(table);

            Quantity.Text = table.Rows[0][0].ToString();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            MainForm mf = new(userStatus);
            Close();
            mf.Show();
        }
    }
}
