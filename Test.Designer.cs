namespace GameOfPhones
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.phoneInfoPanel = new System.Windows.Forms.Panel();
            this.compareCheckBox = new System.Windows.Forms.CheckBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.GSMCDMALabel = new System.Windows.Forms.Label();
            this.RAMSizeLabel = new System.Windows.Forms.Label();
            this.CPUInfoLabel = new System.Windows.Forms.Label();
            this.phoneFullInfoLink = new System.Windows.Forms.LinkLabel();
            this.phonePictureBox = new System.Windows.Forms.PictureBox();
            this.internalStorageLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.phoneInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.phoneInfoPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 440);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // phoneInfoPanel
            // 
            this.phoneInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneInfoPanel.Controls.Add(this.internalStorageLabel);
            this.phoneInfoPanel.Controls.Add(this.compareCheckBox);
            this.phoneInfoPanel.Controls.Add(this.OSLabel);
            this.phoneInfoPanel.Controls.Add(this.priceLabel);
            this.phoneInfoPanel.Controls.Add(this.GSMCDMALabel);
            this.phoneInfoPanel.Controls.Add(this.RAMSizeLabel);
            this.phoneInfoPanel.Controls.Add(this.CPUInfoLabel);
            this.phoneInfoPanel.Controls.Add(this.phoneFullInfoLink);
            this.phoneInfoPanel.Controls.Add(this.phonePictureBox);
            this.phoneInfoPanel.Location = new System.Drawing.Point(4, 4);
            this.phoneInfoPanel.Name = "phoneInfoPanel";
            this.phoneInfoPanel.Size = new System.Drawing.Size(294, 214);
            this.phoneInfoPanel.TabIndex = 8;
            // 
            // compareCheckBox
            // 
            this.compareCheckBox.AutoSize = true;
            this.compareCheckBox.Location = new System.Drawing.Point(136, 178);
            this.compareCheckBox.Name = "compareCheckBox";
            this.compareCheckBox.Size = new System.Drawing.Size(67, 17);
            this.compareCheckBox.TabIndex = 7;
            this.compareCheckBox.Text = "compare";
            this.compareCheckBox.UseVisualStyleBackColor = true;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(133, 106);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(22, 13);
            this.OSLabel.TabIndex = 6;
            this.OSLabel.Text = "OS";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(133, 152);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            // 
            // GSMCDMALabel
            // 
            this.GSMCDMALabel.AutoSize = true;
            this.GSMCDMALabel.Location = new System.Drawing.Point(133, 82);
            this.GSMCDMALabel.Name = "GSMCDMALabel";
            this.GSMCDMALabel.Size = new System.Drawing.Size(67, 13);
            this.GSMCDMALabel.TabIndex = 4;
            this.GSMCDMALabel.Text = "GSM/CDMA";
            // 
            // RAMSizeLabel
            // 
            this.RAMSizeLabel.AutoSize = true;
            this.RAMSizeLabel.Location = new System.Drawing.Point(133, 56);
            this.RAMSizeLabel.Name = "RAMSizeLabel";
            this.RAMSizeLabel.Size = new System.Drawing.Size(52, 13);
            this.RAMSizeLabel.TabIndex = 3;
            this.RAMSizeLabel.Text = "RAM Info";
            // 
            // CPUInfoLabel
            // 
            this.CPUInfoLabel.AutoSize = true;
            this.CPUInfoLabel.Location = new System.Drawing.Point(133, 31);
            this.CPUInfoLabel.Name = "CPUInfoLabel";
            this.CPUInfoLabel.Size = new System.Drawing.Size(50, 13);
            this.CPUInfoLabel.TabIndex = 2;
            this.CPUInfoLabel.Text = "CPU Info";
            // 
            // phoneFullInfoLink
            // 
            this.phoneFullInfoLink.AutoSize = true;
            this.phoneFullInfoLink.Location = new System.Drawing.Point(133, 3);
            this.phoneFullInfoLink.Name = "phoneFullInfoLink";
            this.phoneFullInfoLink.Size = new System.Drawing.Size(99, 13);
            this.phoneFullInfoLink.TabIndex = 1;
            this.phoneFullInfoLink.TabStop = true;
            this.phoneFullInfoLink.Text = "manufacture phone";
            // 
            // phonePictureBox
            // 
            this.phonePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonePictureBox.Location = new System.Drawing.Point(3, 3);
            this.phonePictureBox.Name = "phonePictureBox";
            this.phonePictureBox.Size = new System.Drawing.Size(124, 213);
            this.phonePictureBox.TabIndex = 0;
            this.phonePictureBox.TabStop = false;
            // 
            // internalStorageLabel
            // 
            this.internalStorageLabel.AutoSize = true;
            this.internalStorageLabel.Location = new System.Drawing.Point(133, 128);
            this.internalStorageLabel.Name = "internalStorageLabel";
            this.internalStorageLabel.Size = new System.Drawing.Size(82, 13);
            this.internalStorageLabel.TabIndex = 8;
            this.internalStorageLabel.Text = "Internal Storage";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1003, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1090, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test";
            this.Text = "Test";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.phoneInfoPanel.ResumeLayout(false);
            this.phoneInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel phoneInfoPanel;
        private System.Windows.Forms.CheckBox compareCheckBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label GSMCDMALabel;
        private System.Windows.Forms.Label RAMSizeLabel;
        private System.Windows.Forms.Label CPUInfoLabel;
        private System.Windows.Forms.LinkLabel phoneFullInfoLink;
        private System.Windows.Forms.PictureBox phonePictureBox;
        private System.Windows.Forms.Label internalStorageLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
    }
}