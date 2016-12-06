using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GameOfPhones
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectString = "Server=10.14.52.126;Database=cellphone;Uid=tom;Pwd=;";
            conn = new MySqlConnection(connectString);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //execute query
            bool switchh = true; ;
            if (switchh)
            {
                conn = new MySqlConnection("Server=10.14.52.125;Database=cellphone;Uid=root;");
            }
            else
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=cellphone;Uid=root;");
            }
            
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = richTextBox1.Text;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            try
            {
                this.Controls.Remove(dataGridView1);
                dataSet1 = new DataSet();
                adap.Fill(dataSet1);
                dataGridView1 = new DataGridView();
                dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView1.Location = new System.Drawing.Point(12, 114);
                dataGridView1.Name = "dataGridView1";
                dataGridView1.Size = new System.Drawing.Size(701, 320);
                dataGridView1.TabIndex = 0;
                dataGridView1.DataSource = dataSet1.Tables[0];
                this.Controls.Add(dataGridView1);
               
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            MP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = dataSet1.Tables[0];
            DataRowCollection drc = dt.Rows;
            DataRow dr = drc[0];
            object[] rowArray = dr.ItemArray;
            int numCols = rowArray.Count();
            
            Phone tempPhone = new Phone();
            foreach (DataColumn dc in dt.Columns)
            {
                switch (dc.ColumnName)
                {
                    case "phoneID":
                        //row index 0
                        tempPhone.phoneID = (int)dr.ItemArray[0];
                        break;
                    case "pictureURL":
                        //row index 21
                        tempPhone.pictureURL = (string)dr.ItemArray[21];
                        break;
                }
            }
            pictureBox1.ImageLocation = tempPhone.pictureURL;
        }
    }
}
