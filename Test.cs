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
    public partial class Test : Form
    {

        public Test()
        {
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
    }
}
