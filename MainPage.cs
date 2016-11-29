using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameOfPhones
{
    public partial class MainPage : Form
    {
        ResultsForm RF;
        AdvancedSearch AS;
        Test t;
        public MainPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //parse search form into array of queries
            string[] parseArray = QuickSearchBox.Text.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string s in parseArray)
            {
                //run the query for manufacturer with union
                sb.Append("select phone.phoneID from phone inner join manufacturer on manufacturer.manufacturerID=phone.manufacturerID WHERE manufacturer.name LIKE '%" + s + "%' union ");
                //run the query for phone with union
                sb.Append("select phone.phoneID from phone where phone.name like '%" + s + "%' union ");
            }
            //send the query to the results form page
            //RF = new ResultsForm();
            //RF.ShowDialog();
            string query = sb.ToString().Substring(0,sb.ToString().Length-6);
            t = new Test(query);
            t.ShowDialog();
        }

        private void advancedSearchButton_Click(object sender, EventArgs e)
        {
            AS = new AdvancedSearch();
            AS.ShowDialog();
            //RF = new ResultsForm();
            //RF.ShowDialog();
            t = new Test();
            t.ShowDialog();
        }

        private void QuickSearchBox_Leave(object sender, EventArgs e)
        {
            if (QuickSearchBox.Text.Length == 0)
            {
                QuickSearchBox.Text = "Enter manufacter, phone name, seperate by spaces";
                QuickSearchBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void QuickSearchBox_Enter(object sender, EventArgs e)
        {
            if (QuickSearchBox.Text == "Enter manufacter, phone name, seperate by spaces")
            {
                QuickSearchBox.Text = "";
                QuickSearchBox.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
