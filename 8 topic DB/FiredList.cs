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
    public partial class FiredList : Form
    {
        public string userStatus = "";

        public FiredList(string stat)
        {
            userStatus = stat;
            InitializeComponent();
        }

        private void FiredList_Load(object sender, EventArgs e)
        {
            status.Text = userStatus;

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"exec FiredList";

            adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
            adapter.Fill(table);


            BindingSource SBind = new BindingSource();
            SBind.DataSource = table;
            tableForFilling.DataSource = SBind;
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new(userStatus);
            mf.Show();
        }
    }
}
