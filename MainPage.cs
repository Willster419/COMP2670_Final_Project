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
        AdvancedSearch AS;
        TheResultsPage t;
        public MainPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //check for values
            if (QuickSearchBox.Text.Equals("Enter manufacter, phone name, seperated by spaces") || QuickSearchBox.Text.Length == 0 || QuickSearchBox.Text == null)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            //parse search form into array of queries
            string[] parseArray = QuickSearchBox.Text.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string s in parseArray)
            {
                s.Trim();
                //run the query for manufacturer with union
                sb.Append("select Phone.phoneID from Phone inner join Manufacturer on Manufacturer.manufacturerID=Phone.manufacturerID WHERE Manufacturer.name LIKE '%" + s + "%' union ");
                //run the query for phone with union
                sb.Append("select Phone.phoneID from Phone where Phone.name like '%" + s + "%' union ");
            }
            string query = sb.ToString().Substring(0, sb.ToString().Length - 6);
            query.Trim();
            //order by section
            string orderPart;
            orderPart = "";
            switch (orderByComboBox.SelectedIndex)
            {
                case 0://none
                    
                    break;

                case 2://price high-low
                    orderPart = " order by Phone.price desc";
                    break;

                case 1://price low-high
                    orderPart = " order by Phone.price asc";
                    break;

                case 3://name
                    orderPart = " order by Phone.name asc";
                    break;

                case 5://internal capacity
                    orderPart = " order by Phone.internalCapacity asc";
                    break;

                case 4://RAM
                    orderPart = " order by Phone.RAMcapacity asc";
                    break;

                case 6://Manufacturer
                    orderPart = " order by Manufacturer.name asc";
                    break;
            }
            //send the query to the results form page
            //RF = new ResultsForm();
            //RF.ShowDialog();

            t = new TheResultsPage(query, orderPart);
            t.ShowDialog();
        }

        private void advancedSearchButton_Click(object sender, EventArgs e)
        {
            AS = new AdvancedSearch();
            AS.ShowDialog();
            if (!AS.cont)
            {
                return;
            }
            //grab the query from the advanced table and put it into the results form
            t = new TheResultsPage(AS.query,AS.orderPart);
            t.ShowDialog();
        }

        private void QuickSearchBox_Leave(object sender, EventArgs e)
        {
            if (QuickSearchBox.Text.Length == 0)
            {
                QuickSearchBox.Text = "Enter manufacter, phone name, seperated by spaces";
                QuickSearchBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void QuickSearchBox_Enter(object sender, EventArgs e)
        {
            if (QuickSearchBox.Text == "Enter manufacter, phone name, seperated by spaces")
            {
                QuickSearchBox.Text = "";
                QuickSearchBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            orderByComboBox.SelectedIndex = 0;
            QuickSearchBox_Leave(null, null);
            this.ActiveControl = orderByComboBox;
        }
    }
}
