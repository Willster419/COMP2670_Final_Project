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
    public partial class ResultsForm : Form
    {
        FullInfo FI;
        Compare comp = new Compare();
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FI = new FullInfo();
            FI.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp.Show();
        }
    }
}
