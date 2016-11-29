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
    public partial class Test : Form
    {
        public string query;
        FullInfo FI;
        Compare comp = new Compare();
        public List<Phone> phoneList;
        MySqlConnection conn;
        DataSet phoneDataSet;

        public Test()
        {
            InitializeComponent();
        }

        public Test(string queryy)
        {
            query = queryy;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Panel newPhoneInfoPanel = new Panel();
            CheckBox newCompareCheckBox = new CheckBox();
            Label newOSLabel = new Label();
            Label newPriceLabel = new Label();
            Label newGSMCDMALabel = new Label();
            Label newRAMSizeLabel = new Label();
            Label newCPUInfoLabel = new Label();
            LinkLabel newPhoneFullInfoLink = new LinkLabel();
            PictureBox newPhonePictureBox = new PictureBox();
            Label newInternalStorageLabel = new Label();

            // 
            // phoneInfoPanel
            // 
            newPhoneInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newPhoneInfoPanel.Controls.Add(newInternalStorageLabel);
            newPhoneInfoPanel.Controls.Add(newCompareCheckBox);
            newPhoneInfoPanel.Controls.Add(newOSLabel);
            newPhoneInfoPanel.Controls.Add(newPriceLabel);
            newPhoneInfoPanel.Controls.Add(newGSMCDMALabel);
            newPhoneInfoPanel.Controls.Add(newRAMSizeLabel);
            newPhoneInfoPanel.Controls.Add(newCPUInfoLabel);
            newPhoneInfoPanel.Controls.Add(newPhoneFullInfoLink);
            newPhoneInfoPanel.Controls.Add(newPhonePictureBox);
            newPhoneInfoPanel.Location = new System.Drawing.Point(3, 3);
            newPhoneInfoPanel.Name = "phoneInfoPanel";
            newPhoneInfoPanel.Size = new System.Drawing.Size(294, 214);
            newPhoneInfoPanel.TabIndex = 8;
            // 
            // compareCheckBox
            // 
            newCompareCheckBox.AutoSize = true;
            newCompareCheckBox.Location = new System.Drawing.Point(136, 178);
            newCompareCheckBox.Name = "compareCheckBox";
            newCompareCheckBox.Size = new System.Drawing.Size(67, 17);
            newCompareCheckBox.TabIndex = 7;
            newCompareCheckBox.Text = "compare";
            newCompareCheckBox.UseVisualStyleBackColor = true;
            // 
            // OSLabel
            // 
            newOSLabel.AutoSize = true;
            newOSLabel.Location = new System.Drawing.Point(133, 106);
            newOSLabel.Name = "OSLabel";
            newOSLabel.Size = new System.Drawing.Size(22, 13);
            newOSLabel.TabIndex = 6;
            newOSLabel.Text = "OS";
            // 
            // priceLabel
            // 
            newPriceLabel.AutoSize = true;
            newPriceLabel.Location = new System.Drawing.Point(133, 152);
            newPriceLabel.Name = "priceLabel";
            newPriceLabel.Size = new System.Drawing.Size(31, 13);
            newPriceLabel.TabIndex = 5;
            newPriceLabel.Text = "Price";
            // 
            // GSMCDMALabel
            // 
            newGSMCDMALabel.AutoSize = true;
            newGSMCDMALabel.Location = new System.Drawing.Point(133, 82);
            newGSMCDMALabel.Name = "GSMCDMALabel";
            newGSMCDMALabel.Size = new System.Drawing.Size(67, 13);
            newGSMCDMALabel.TabIndex = 4;
            newGSMCDMALabel.Text = "GSM/CDMA";
            // 
            // RAMSizeLabel
            // 
            newRAMSizeLabel.AutoSize = true;
            newRAMSizeLabel.Location = new System.Drawing.Point(133, 56);
            newRAMSizeLabel.Name = "RAMSizeLabel";
            newRAMSizeLabel.Size = new System.Drawing.Size(52, 13);
            newRAMSizeLabel.TabIndex = 3;
            newRAMSizeLabel.Text = "RAM Info";
            // 
            // CPUInfoLabel
            // 
            newCPUInfoLabel.AutoSize = true;
            newCPUInfoLabel.Location = new System.Drawing.Point(133, 31);
            newCPUInfoLabel.Name = "CPUInfoLabel";
            newCPUInfoLabel.Size = new System.Drawing.Size(50, 13);
            newCPUInfoLabel.TabIndex = 2;
            newCPUInfoLabel.Text = "CPU Info";
            // 
            // phoneFullInfoLink
            // 
            newPhoneFullInfoLink.AutoSize = true;
            newPhoneFullInfoLink.Location = new System.Drawing.Point(133, 3);
            newPhoneFullInfoLink.Name = "phoneFullInfoLink";
            newPhoneFullInfoLink.Size = new System.Drawing.Size(99, 13);
            newPhoneFullInfoLink.TabIndex = 1;
            newPhoneFullInfoLink.TabStop = true;
            newPhoneFullInfoLink.Text = "manufacture phone";
            // 
            // phonePictureBox
            // 
            newPhonePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newPhonePictureBox.Location = new System.Drawing.Point(3, 3);
            newPhonePictureBox.Name = "phonePictureBox";
            newPhonePictureBox.Size = new System.Drawing.Size(124, 213);
            newPhonePictureBox.TabIndex = 0;
            newPhonePictureBox.TabStop = false;
            // 
            // internalStorageLabel
            // 
            newInternalStorageLabel.AutoSize = true;
            newInternalStorageLabel.Location = new System.Drawing.Point(133, 128);
            newInternalStorageLabel.Name = "internalStorageLabel";
            newInternalStorageLabel.Size = new System.Drawing.Size(82, 13);
            newInternalStorageLabel.TabIndex = 8;
            newInternalStorageLabel.Text = "Internal Storage";

            int totalHold = this.tableLayoutPanel1.ColumnCount * this.tableLayoutPanel1.RowCount;
            if (totalHold == this.tableLayoutPanel1.Controls.Count)
            {
                this.tableLayoutPanel1.RowCount++;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute,220));
            }
            
            
                this.tableLayoutPanel1.Controls.Add(newPhoneInfoPanel);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.RowCount++;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute,220));
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //take query and parse it into arraylist
            bool switchh = false;
            if (switchh)
            {
                conn = new MySqlConnection("Server=10.14.52.125;Database=cellphone;Uid=root;");
            }
            else
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=cellphone;Uid=root;");
            }
            
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                phoneDataSet = new DataSet();
                adap.Fill(phoneDataSet);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            conn.Close();

            //parse it into the arraylist
            DataTable dt = phoneDataSet.Tables[0];
            List<int> phoneArray = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                phoneArray.Add((int)dr.ItemArray[0]);
            }

            //have it run a new query to return all phone information for the results page
        }
        private void addResult(string manufactureName,
            string phoneName,
            string CpuFreq,
            string CpuCoreNum,
            string RamSize,
            string GSMCDMAType,
            string price,
            string OSname,
            string pictureURL,
            string internalStorageSize)
        {
            Panel newPhoneInfoPanel = new Panel();
            CheckBox newCompareCheckBox = new CheckBox();
            Label newOSLabel = new Label();
            Label newPriceLabel = new Label();
            Label newGSMCDMALabel = new Label();
            Label newRAMSizeLabel = new Label();
            Label newCPUInfoLabel = new Label();
            LinkLabel newPhoneFullInfoLink = new LinkLabel();
            PictureBox newPhonePictureBox = new PictureBox();
            Label newInternalStorageLabel = new Label();

            // 
            // phoneInfoPanel
            // 
            newPhoneInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newPhoneInfoPanel.Controls.Add(newInternalStorageLabel);
            newPhoneInfoPanel.Controls.Add(newCompareCheckBox);
            newPhoneInfoPanel.Controls.Add(newOSLabel);
            newPhoneInfoPanel.Controls.Add(newPriceLabel);
            newPhoneInfoPanel.Controls.Add(newGSMCDMALabel);
            newPhoneInfoPanel.Controls.Add(newRAMSizeLabel);
            newPhoneInfoPanel.Controls.Add(newCPUInfoLabel);
            newPhoneInfoPanel.Controls.Add(newPhoneFullInfoLink);
            newPhoneInfoPanel.Controls.Add(newPhonePictureBox);
            newPhoneInfoPanel.Location = new System.Drawing.Point(3, 3);
            newPhoneInfoPanel.Name = "phoneInfoPanel";
            newPhoneInfoPanel.Size = new System.Drawing.Size(294, 214);
            newPhoneInfoPanel.TabIndex = 8;
            // 
            // compareCheckBox
            // 
            newCompareCheckBox.AutoSize = true;
            newCompareCheckBox.Location = new System.Drawing.Point(136, 178);
            newCompareCheckBox.Name = "compareCheckBox";
            newCompareCheckBox.Size = new System.Drawing.Size(67, 17);
            newCompareCheckBox.TabIndex = 7;
            newCompareCheckBox.Text = "compare";
            newCompareCheckBox.UseVisualStyleBackColor = true;
            // 
            // OSLabel
            // 
            newOSLabel.AutoSize = true;
            newOSLabel.Location = new System.Drawing.Point(133, 106);
            newOSLabel.Name = "OSLabel";
            newOSLabel.Size = new System.Drawing.Size(22, 13);
            newOSLabel.TabIndex = 6;
            newOSLabel.Text = OSname;
            // 
            // priceLabel
            // 
            newPriceLabel.AutoSize = true;
            newPriceLabel.Location = new System.Drawing.Point(133, 152);
            newPriceLabel.Name = "priceLabel";
            newPriceLabel.Size = new System.Drawing.Size(31, 13);
            newPriceLabel.TabIndex = 5;
            newPriceLabel.Text = "$" + price;
            // 
            // GSMCDMALabel
            // 
            newGSMCDMALabel.AutoSize = true;
            newGSMCDMALabel.Location = new System.Drawing.Point(133, 82);
            newGSMCDMALabel.Name = "GSMCDMALabel";
            newGSMCDMALabel.Size = new System.Drawing.Size(67, 13);
            newGSMCDMALabel.TabIndex = 4;
            newGSMCDMALabel.Text = GSMCDMAType;
            // 
            // RAMSizeLabel
            // 
            newRAMSizeLabel.AutoSize = true;
            newRAMSizeLabel.Location = new System.Drawing.Point(133, 56);
            newRAMSizeLabel.Name = "RAMSizeLabel";
            newRAMSizeLabel.Size = new System.Drawing.Size(52, 13);
            newRAMSizeLabel.TabIndex = 3;
            newRAMSizeLabel.Text = RamSize + "MB RAM";
            // 
            // CPUInfoLabel
            // 
            newCPUInfoLabel.AutoSize = true;
            newCPUInfoLabel.Location = new System.Drawing.Point(133, 31);
            newCPUInfoLabel.Name = "CPUInfoLabel";
            newCPUInfoLabel.Size = new System.Drawing.Size(50, 13);
            newCPUInfoLabel.TabIndex = 2;
            newCPUInfoLabel.Text = CpuCoreNum + " cores @ " + CpuFreq + "GHz";
            // 
            // phoneFullInfoLink
            // 
            newPhoneFullInfoLink.AutoSize = true;
            newPhoneFullInfoLink.Location = new System.Drawing.Point(133, 3);
            newPhoneFullInfoLink.Name = "phoneFullInfoLink";
            newPhoneFullInfoLink.Size = new System.Drawing.Size(99, 13);
            newPhoneFullInfoLink.TabIndex = 1;
            newPhoneFullInfoLink.TabStop = true;
            newPhoneFullInfoLink.Text = manufactureName + " " + phoneName;
            // 
            // phonePictureBox
            // 
            newPhonePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newPhonePictureBox.Location = new System.Drawing.Point(3, 3);
            newPhonePictureBox.Name = "phonePictureBox";
            newPhonePictureBox.Size = new System.Drawing.Size(124, 213);
            newPhonePictureBox.TabIndex = 0;
            newPhonePictureBox.TabStop = false;
            newPhonePictureBox.ImageLocation = pictureURL;
            // 
            // internalStorageLabel
            // 
            newInternalStorageLabel.AutoSize = true;
            newInternalStorageLabel.Location = new System.Drawing.Point(133, 128);
            newInternalStorageLabel.Name = "internalStorageLabel";
            newInternalStorageLabel.Size = new System.Drawing.Size(82, 13);
            newInternalStorageLabel.TabIndex = 8;
            newInternalStorageLabel.Text = internalStorageSize + "MB Internal Storage";

            int totalHold = this.tableLayoutPanel1.ColumnCount * this.tableLayoutPanel1.RowCount;
            if (totalHold == this.tableLayoutPanel1.Controls.Count)
            {
                this.tableLayoutPanel1.RowCount++;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 220));
            }


            this.tableLayoutPanel1.Controls.Add(newPhoneInfoPanel);
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
