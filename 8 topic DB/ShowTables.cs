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
    public partial class ShowTables : Form
    {
        public string userStatus = "";
        public string selectedState = "";

        public ShowTables(string stat)
        {
            userStatus = stat;
            InitializeComponent();
        }

        private void ShowTables_Load(object sender, EventArgs e)
        {
            status.Text = userStatus;
        }

        private void tableChoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = tableChoosing.SelectedItem.ToString();

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from {userStatus}View{selectedState}";

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

        private void button1_Click(object sender, EventArgs e)
        {
            selectedState = tableChoosing.SelectedItem.ToString();

            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from {userStatus}View{selectedState} where Surname_Name like '{NameSearch.Text}%' and Age = {int.Parse(AgeSearch.Text)}";

            adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
            adapter.Fill(table);


            BindingSource SBind = new BindingSource();
            SBind.DataSource = table;
            tableForFilling.DataSource = SBind;
        }
    }
}
