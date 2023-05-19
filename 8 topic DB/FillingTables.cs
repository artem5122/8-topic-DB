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
    public partial class FillingTables : Form
    {
        public string selectedState = "";
        
        public FillingTables()
        {
            InitializeComponent();
        }

        private void FillingTables_Load(object sender, EventArgs e)
        {

        }

        private void tableChoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = tableChoosing.SelectedItem.ToString();
            
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT *    FROM {selectedState}";

            adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
            adapter.Fill(table);
            

            BindingSource SBind = new BindingSource();
            SBind.DataSource = table;
            tableForFilling.DataSource = SBind;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int ID = (int)tableForFilling.Rows[tableForFilling.CurrentCell.RowIndex].Cells[0].Value;
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"delete from {selectedState} where id = {ID}";

            adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
            adapter.Fill(table);
            
            tableChoosing_SelectedIndexChanged(sender, e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedState == "Staff")
            {
                DataBase db = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string Name = tableForFilling.Rows[tableForFilling.CurrentCell.RowIndex].Cells[1].Value.ToString();
                int Salary = (int)tableForFilling.Rows[tableForFilling.CurrentCell.RowIndex].Cells[2].Value;

                string query = $"insert into {selectedState} (Name, Salary) values ('{Name}', {Salary})";

                adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
                adapter.Fill(table);

                tableChoosing_SelectedIndexChanged(sender, e);
            }
            else if (selectedState == "Employee")
            {
                DataBase db = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string Surname_Name = tableForFilling.Rows[tableForFilling.CurrentCell.RowIndex].Cells[1].Value.ToString();
                int Staff_ID = (int)tableForFilling.Rows[tableForFilling.CurrentCell.RowIndex].Cells[2].Value;
                short Age = (short)tableForFilling.Rows[tableForFilling.CurrentCell.RowIndex].Cells[3].Value;

                string query = $"insert into {selectedState} (Surname_Name, Staff_ID, Age) values ('{Surname_Name}', {Staff_ID}, {Age})";

                adapter.SelectCommand = new SqlCommand(query, db.GetConnection());
                adapter.Fill(table);

                tableChoosing_SelectedIndexChanged(sender, e);

            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new("admin");
            mf.Show();
        }
    }
}
