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
    public partial class RelatedTables : Form
    {
        public string userStatus = "";
        public RelatedTables(string stat)
        {
            userStatus = stat;
            InitializeComponent();
        }

        private void RelatedTables_Load(object sender, EventArgs e)
        {
            status.Text = userStatus;


            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT Id, Name, Salary, Quantity FROM Staff";

            adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
            adapter.Fill(table);

            BindingSource SBind = new BindingSource();
            SBind.DataSource = table;
            tableForFillingParent.DataSource = SBind;
        }

        

        private void tableForFillingParent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ID = (int)tableForFillingParent.Rows[e.RowIndex].Cells[0].Value;

                DataBase db = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string query = $"SELECT Surname_name, Age FROM Employee where Staff_ID = {ID}";

                adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
                adapter.Fill(table);

                BindingSource SBind = new BindingSource();
                SBind.DataSource = table;
                tableForFillingChild.DataSource = SBind;
            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mf = new(userStatus);
            mf.Show();
        }
    }
}
