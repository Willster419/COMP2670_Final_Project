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
    public partial class AdvancedSearch : Form
    {
        private string cpuQuery1;
        private string cpuQuery2;
        private string osQuery;
        private string manufactureQuery;
        private string cameraQuery1;
        private string cameraQuery2;
        private string cameraQuery3;
        private string displayQuery1;
        private string displayQuery2;
        private string displayQuery3;
        private string displayQuery4;
        private string phoneQuery1;
        private string phoneQuery2;
        private string phoneQuery3;
        private string phoneQuery4;
        private string phoneQuery5;
        private string phoneQuery6;
        private string phoneQuery7;
        private string networkQuery;
        private string carrierQuery;
        public string query;
        MySqlConnection conn;
        DataSet phoneDataSet;

        public AdvancedSearch()
        {
            
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            orderByComboBox.SelectedIndex = 1;
            //load each table
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
