using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace GameOfPhones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectString = "Server=localhost;Database=chinook;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();

            phoneDatabaseDataSet.GetChanges();
            SqlConnection con = new SqlConnection("user id=tom;" +
                                       "password=;server=localhost:3306;" +
                                       "Trusted_Connection=yes;" +
                                       "database=chinook; " +
                                       "connection timeout=5");
            con.Open();

            // TODO: This line of code loads data into the 'phoneDatabaseDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.phoneDatabaseDataSet.Phone);
        
            // TODO: This line of code loads data into the 'phoneDatabaseDataSet.Phone' table. You can move, or remove it, as needed.

        }

        private void phoneBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void phoneBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneDatabaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.phoneDatabaseDataSet);
        }
    }
}
