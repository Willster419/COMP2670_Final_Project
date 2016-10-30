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
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RF = new ResultsForm();
            RF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AS = new AdvancedSearch();
            AS.ShowDialog();
            RF = new ResultsForm();
            RF.ShowDialog();
        }
    }
}
