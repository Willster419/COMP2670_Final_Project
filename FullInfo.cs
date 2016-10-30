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
    public partial class FullInfo : Form
    {
        HelpInfo HI;
        public FullInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HI = new HelpInfo();
            HI.ShowDialog();
        }
    }
}
