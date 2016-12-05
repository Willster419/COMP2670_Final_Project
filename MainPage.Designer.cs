namespace GameOfPhones
{
    partial class MainPage
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.QuickSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.advancedSearchButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(199, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(86, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Game of Phones";
            // 
            // QuickSearchBox
            // 
            this.QuickSearchBox.Location = new System.Drawing.Point(32, 48);
            this.QuickSearchBox.Name = "QuickSearchBox";
            this.QuickSearchBox.Size = new System.Drawing.Size(363, 20);
            this.QuickSearchBox.TabIndex = 1;
            this.QuickSearchBox.Enter += new System.EventHandler(this.QuickSearchBox_Enter);
            this.QuickSearchBox.Leave += new System.EventHandler(this.QuickSearchBox_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(401, 48);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.Location = new System.Drawing.Point(401, 90);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(75, 23);
            this.advancedSearchButton.TabIndex = 3;
            this.advancedSearchButton.Text = "advanced search";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            this.advancedSearchButton.Click += new System.EventHandler(this.advancedSearchButton_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(29, 32);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(260, 13);
            this.HintLabel.TabIndex = 4;
            this.HintLabel.Text = "Enter manufacter or phone name, seperate by spaces";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(417, 74);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(16, 13);
            this.orLabel.TabIndex = 5;
            this.orLabel.Text = "or";
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(29, 74);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(45, 13);
            this.orderByLabel.TabIndex = 6;
            this.orderByLabel.Text = "order by";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Items.AddRange(new object[] {
            "None",
            "Price (Low-High)",
            "Price (High-Low)",
            "Phone Name",
            "RAM (High-Low)",
            "Internal Capacity (High-Low)",
            "Manufacturer (A-Z)"});
            this.orderByComboBox.Location = new System.Drawing.Point(80, 71);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderByComboBox.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 157);
            this.Controls.Add(this.orderByComboBox);
            this.Controls.Add(this.orderByLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.advancedSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.QuickSearchBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainPage";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox QuickSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button advancedSearchButton;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.ComboBox orderByComboBox;
    }
}