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
    public partial class FullInfo : Form
    {
        public string query;
        MySqlConnection conn;
        DataSet phoneDataSet;

        public FullInfo()
        {
            InitializeComponent();
        }

    }
}
