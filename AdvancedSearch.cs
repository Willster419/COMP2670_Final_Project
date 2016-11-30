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
        MySqlConnection conn;
        DataSet phoneDataSet;

        public AdvancedSearch()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                    if (e.Index != ix) checkedListBox1.SetItemChecked(ix, false);
             */
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            //load each table
        }
    }
}
