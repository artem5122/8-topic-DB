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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select status from Users where login = '{ loginBox.Text}' and password = '{ passwordBox.Text}'";
           

            SqlCommand command = new SqlCommand(query, db.GetConnection());
          
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count==0)
            {
                MessageBox.Show("Нет такого пользователя");
            }
            else
            {
                if (table.Rows[0][0].ToString() == "admin")
                {
                    MainForm mf = new("admin");
                    Hide();
                    mf.Show();
                }
                else if (table.Rows[0][0].ToString() == "user ")
                {
                    MainForm mf = new("user");
                    Hide();
                    mf.Show();
                }
            }
            
            
        }
    }
}
