namespace GameOfPhones
{
    partial class AdvancedSearch
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
            this.CPUFreqBox = new System.Windows.Forms.CheckedListBox();
            this.CPUCatagoryLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.CPUPanel = new System.Windows.Forms.Panel();
            this.CPUCoreBox = new System.Windows.Forms.CheckedListBox();
            this.CPUCoresLabel = new System.Windows.Forms.Label();
            this.CPUFrequencyLabel = new System.Windows.Forms.Label();
            this.OSCatagoryLabel = new System.Windows.Forms.Label();
            this.cameraCatagoryLabel = new System.Windows.Forms.Label();
            this.networkCatagoryLabel = new System.Windows.Forms.Label();
            this.carrierCatagoryLabel = new System.Windows.Forms.Label();
            this.manufacturerCatagoryLabel = new System.Windows.Forms.Label();
            this.displayCatagoryLabel = new System.Windows.Forms.Label();
            this.phoneCatagoryLabel = new System.Windows.Forms.Label();
            this.OSPanel = new System.Windows.Forms.Panel();
            this.OSBox = new System.Windows.Forms.CheckedListBox();
            this.cameraPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cameraOpticalZoomBox = new System.Windows.Forms.CheckedListBox();
            this.cameraMPixBox = new System.Windows.Forms.CheckedListBox();
            this.cameraOpticalZoomLabel = new System.Windows.Forms.Label();
            this.cameraMPixelsLabel = new System.Windows.Forms.Label();
            this.cameraNumCamerasLabel = new System.Windows.Forms.Label();
            this.cameraNumBox = new System.Windows.Forms.CheckedListBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.displayTouchscreenBox = new System.Windows.Forms.CheckedListBox();
            this.displayTouchscreenLabel = new System.Windows.Forms.Label();
            this.displaySizeBox = new System.Windows.Forms.CheckedListBox();
            this.displaySizeLabel = new System.Windows.Forms.Label();
            this.displayTypeBox = new System.Windows.Forms.CheckedListBox();
            this.displayTypeLabel = new System.Windows.Forms.Label();
            this.displayResolutionLabel = new System.Windows.Forms.Label();
            this.displayResolutionBox = new System.Windows.Forms.CheckedListBox();
            this.phonePanel = new System.Windows.Forms.Panel();
            this.phonePriceHighLabel = new System.Windows.Forms.Label();
            this.phonePriceLowLabel = new System.Windows.Forms.Label();
            this.phonePriceHighTB = new System.Windows.Forms.TextBox();
            this.phonePriceLowTB = new System.Windows.Forms.TextBox();
            this.phoneBattCapBox = new System.Windows.Forms.CheckedListBox();
            this.batteryCapacityLabel = new System.Windows.Forms.Label();
            this.phoneHeadphoneJackBox = new System.Windows.Forms.CheckedListBox();
            this.headphoneJackLabel = new System.Windows.Forms.Label();
            this.phoneExternalKeyboardBox = new System.Windows.Forms.CheckedListBox();
            this.extKeyboardLabel = new System.Windows.Forms.Label();
            this.phoneRAMBox = new System.Windows.Forms.CheckedListBox();
            this.phoneRAMLabel = new System.Windows.Forms.Label();
            this.phoneExpandableCapacityBox = new System.Windows.Forms.CheckedListBox();
            this.phoneExpandableCapacityLabel = new System.Windows.Forms.Label();
            this.phoneInternalCapacityBox = new System.Windows.Forms.CheckedListBox();
            this.phoneInternalCapacityLabel = new System.Windows.Forms.Label();
            this.phonePriceLabel = new System.Windows.Forms.Label();
            this.networkPanel = new System.Windows.Forms.Panel();
            this.networkTypeBox = new System.Windows.Forms.CheckedListBox();
            this.carrierPanel = new System.Windows.Forms.Panel();
            this.carrierNameBox = new System.Windows.Forms.CheckedListBox();
            this.ManufacturePanel = new System.Windows.Forms.Panel();
            this.manufacturerBox = new System.Windows.Forms.CheckedListBox();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.CPUPanel.SuspendLayout();
            this.OSPanel.SuspendLayout();
            this.cameraPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.phonePanel.SuspendLayout();
            this.networkPanel.SuspendLayout();
            this.carrierPanel.SuspendLayout();
            this.ManufacturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPUFreqBox
            // 
            this.CPUFreqBox.CheckOnClick = true;
            this.CPUFreqBox.FormattingEnabled = true;
            this.CPUFreqBox.Items.AddRange(new object[] {
            "CPU1",
            "CPU2",
            "CPU3"});
            this.CPUFreqBox.Location = new System.Drawing.Point(3, 16);
            this.CPUFreqBox.Name = "CPUFreqBox";
            this.CPUFreqBox.Size = new System.Drawing.Size(93, 109);
            this.CPUFreqBox.TabIndex = 2;
            // 
            // CPUCatagoryLabel
            // 
            this.CPUCatagoryLabel.AutoSize = true;
            this.CPUCatagoryLabel.Location = new System.Drawing.Point(5, 6);
            this.CPUCatagoryLabel.Name = "CPUCatagoryLabel";
            this.CPUCatagoryLabel.Size = new System.Drawing.Size(29, 13);
            this.CPUCatagoryLabel.TabIndex = 3;
            this.CPUCatagoryLabel.Text = "CPU";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(780, 322);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CPUPanel
            // 
            this.CPUPanel.AutoScroll = true;
            this.CPUPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUPanel.Controls.Add(this.CPUCoreBox);
            this.CPUPanel.Controls.Add(this.CPUCoresLabel);
            this.CPUPanel.Controls.Add(this.CPUFrequencyLabel);
            this.CPUPanel.Controls.Add(this.CPUFreqBox);
            this.CPUPanel.Location = new System.Drawing.Point(8, 22);
            this.CPUPanel.Name = "CPUPanel";
            this.CPUPanel.Size = new System.Drawing.Size(101, 326);
            this.CPUPanel.TabIndex = 5;
            // 
            // CPUCoreBox
            // 
            this.CPUCoreBox.CheckOnClick = true;
            this.CPUCoreBox.FormattingEnabled = true;
            this.CPUCoreBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CPUCoreBox.Location = new System.Drawing.Point(2, 147);
            this.CPUCoreBox.Name = "CPUCoreBox";
            this.CPUCoreBox.Size = new System.Drawing.Size(94, 94);
            this.CPUCoreBox.TabIndex = 5;
            // 
            // CPUCoresLabel
            // 
            this.CPUCoresLabel.AutoSize = true;
            this.CPUCoresLabel.Location = new System.Drawing.Point(-1, 131);
            this.CPUCoresLabel.Name = "CPUCoresLabel";
            this.CPUCoresLabel.Size = new System.Drawing.Size(86, 13);
            this.CPUCoresLabel.TabIndex = 4;
            this.CPUCoresLabel.Text = "Number of Cores";
            // 
            // CPUFrequencyLabel
            // 
            this.CPUFrequencyLabel.AutoSize = true;
            this.CPUFrequencyLabel.Location = new System.Drawing.Point(3, 0);
            this.CPUFrequencyLabel.Name = "CPUFrequencyLabel";
            this.CPUFrequencyLabel.Size = new System.Drawing.Size(87, 13);
            this.CPUFrequencyLabel.TabIndex = 3;
            this.CPUFrequencyLabel.Text = "Frequency (GHz)";
            // 
            // OSCatagoryLabel
            // 
            this.OSCatagoryLabel.AutoSize = true;
            this.OSCatagoryLabel.Location = new System.Drawing.Point(112, 6);
            this.OSCatagoryLabel.Name = "OSCatagoryLabel";
            this.OSCatagoryLabel.Size = new System.Drawing.Size(22, 13);
            this.OSCatagoryLabel.TabIndex = 6;
            this.OSCatagoryLabel.Text = "OS";
            // 
            // cameraCatagoryLabel
            // 
            this.cameraCatagoryLabel.AutoSize = true;
            this.cameraCatagoryLabel.Location = new System.Drawing.Point(294, 6);
            this.cameraCatagoryLabel.Name = "cameraCatagoryLabel";
            this.cameraCatagoryLabel.Size = new System.Drawing.Size(43, 13);
            this.cameraCatagoryLabel.TabIndex = 7;
            this.cameraCatagoryLabel.Text = "Camera";
            // 
            // networkCatagoryLabel
            // 
            this.networkCatagoryLabel.AutoSize = true;
            this.networkCatagoryLabel.Location = new System.Drawing.Point(726, 6);
            this.networkCatagoryLabel.Name = "networkCatagoryLabel";
            this.networkCatagoryLabel.Size = new System.Drawing.Size(47, 13);
            this.networkCatagoryLabel.TabIndex = 8;
            this.networkCatagoryLabel.Text = "Network";
            // 
            // carrierCatagoryLabel
            // 
            this.carrierCatagoryLabel.AutoSize = true;
            this.carrierCatagoryLabel.Location = new System.Drawing.Point(726, 71);
            this.carrierCatagoryLabel.Name = "carrierCatagoryLabel";
            this.carrierCatagoryLabel.Size = new System.Drawing.Size(37, 13);
            this.carrierCatagoryLabel.TabIndex = 9;
            this.carrierCatagoryLabel.Text = "Carrier";
            // 
            // manufacturerCatagoryLabel
            // 
            this.manufacturerCatagoryLabel.AutoSize = true;
            this.manufacturerCatagoryLabel.Location = new System.Drawing.Point(112, 190);
            this.manufacturerCatagoryLabel.Name = "manufacturerCatagoryLabel";
            this.manufacturerCatagoryLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerCatagoryLabel.TabIndex = 10;
            this.manufacturerCatagoryLabel.Text = "Manufacturer";
            // 
            // displayCatagoryLabel
            // 
            this.displayCatagoryLabel.AutoSize = true;
            this.displayCatagoryLabel.Location = new System.Drawing.Point(412, 6);
            this.displayCatagoryLabel.Name = "displayCatagoryLabel";
            this.displayCatagoryLabel.Size = new System.Drawing.Size(41, 13);
            this.displayCatagoryLabel.TabIndex = 11;
            this.displayCatagoryLabel.Text = "Display";
            // 
            // phoneCatagoryLabel
            // 
            this.phoneCatagoryLabel.AutoSize = true;
            this.phoneCatagoryLabel.Location = new System.Drawing.Point(560, 6);
            this.phoneCatagoryLabel.Name = "phoneCatagoryLabel";
            this.phoneCatagoryLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneCatagoryLabel.TabIndex = 12;
            this.phoneCatagoryLabel.Text = "Phone";
            // 
            // OSPanel
            // 
            this.OSPanel.AutoScroll = true;
            this.OSPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OSPanel.Controls.Add(this.OSBox);
            this.OSPanel.Location = new System.Drawing.Point(115, 22);
            this.OSPanel.Name = "OSPanel";
            this.OSPanel.Size = new System.Drawing.Size(176, 165);
            this.OSPanel.TabIndex = 13;
            // 
            // OSBox
            // 
            this.OSBox.CheckOnClick = true;
            this.OSBox.FormattingEnabled = true;
            this.OSBox.Items.AddRange(new object[] {
            "Android 6.0 Marshmellow",
            "IOS",
            "Crackberry"});
            this.OSBox.Location = new System.Drawing.Point(3, 3);
            this.OSBox.Name = "OSBox";
            this.OSBox.Size = new System.Drawing.Size(168, 94);
            this.OSBox.TabIndex = 0;
            // 
            // cameraPanel
            // 
            this.cameraPanel.AutoScroll = true;
            this.cameraPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraPanel.Controls.Add(this.label16);
            this.cameraPanel.Controls.Add(this.cameraOpticalZoomBox);
            this.cameraPanel.Controls.Add(this.cameraMPixBox);
            this.cameraPanel.Controls.Add(this.cameraOpticalZoomLabel);
            this.cameraPanel.Controls.Add(this.cameraMPixelsLabel);
            this.cameraPanel.Controls.Add(this.cameraNumCamerasLabel);
            this.cameraPanel.Controls.Add(this.cameraNumBox);
            this.cameraPanel.Location = new System.Drawing.Point(297, 22);
            this.cameraPanel.Name = "cameraPanel";
            this.cameraPanel.Size = new System.Drawing.Size(112, 326);
            this.cameraPanel.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "* of best camera";
            // 
            // cameraOpticalZoomBox
            // 
            this.cameraOpticalZoomBox.CheckOnClick = true;
            this.cameraOpticalZoomBox.FormattingEnabled = true;
            this.cameraOpticalZoomBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cameraOpticalZoomBox.Location = new System.Drawing.Point(3, 133);
            this.cameraOpticalZoomBox.Name = "cameraOpticalZoomBox";
            this.cameraOpticalZoomBox.Size = new System.Drawing.Size(74, 94);
            this.cameraOpticalZoomBox.TabIndex = 19;
            // 
            // cameraMPixBox
            // 
            this.cameraMPixBox.CheckOnClick = true;
            this.cameraMPixBox.FormattingEnabled = true;
            this.cameraMPixBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cameraMPixBox.Location = new System.Drawing.Point(3, 20);
            this.cameraMPixBox.Name = "cameraMPixBox";
            this.cameraMPixBox.Size = new System.Drawing.Size(74, 94);
            this.cameraMPixBox.TabIndex = 18;
            // 
            // cameraOpticalZoomLabel
            // 
            this.cameraOpticalZoomLabel.AutoSize = true;
            this.cameraOpticalZoomLabel.Location = new System.Drawing.Point(3, 117);
            this.cameraOpticalZoomLabel.Name = "cameraOpticalZoomLabel";
            this.cameraOpticalZoomLabel.Size = new System.Drawing.Size(74, 13);
            this.cameraOpticalZoomLabel.TabIndex = 17;
            this.cameraOpticalZoomLabel.Text = "Optical Zoom*";
            // 
            // cameraMPixelsLabel
            // 
            this.cameraMPixelsLabel.AutoSize = true;
            this.cameraMPixelsLabel.Location = new System.Drawing.Point(3, 4);
            this.cameraMPixelsLabel.Name = "cameraMPixelsLabel";
            this.cameraMPixelsLabel.Size = new System.Drawing.Size(47, 13);
            this.cameraMPixelsLabel.TabIndex = 16;
            this.cameraMPixelsLabel.Text = "MPixels*";
            // 
            // cameraNumCamerasLabel
            // 
            this.cameraNumCamerasLabel.AutoSize = true;
            this.cameraNumCamerasLabel.Location = new System.Drawing.Point(3, 268);
            this.cameraNumCamerasLabel.Name = "cameraNumCamerasLabel";
            this.cameraNumCamerasLabel.Size = new System.Drawing.Size(69, 13);
            this.cameraNumCamerasLabel.TabIndex = 15;
            this.cameraNumCamerasLabel.Text = "# of cameras";
            this.cameraNumCamerasLabel.Visible = false;
            // 
            // cameraNumBox
            // 
            this.cameraNumBox.CheckOnClick = true;
            this.cameraNumBox.FormattingEnabled = true;
            this.cameraNumBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3+"});
            this.cameraNumBox.Location = new System.Drawing.Point(3, 283);
            this.cameraNumBox.Name = "cameraNumBox";
            this.cameraNumBox.Size = new System.Drawing.Size(74, 4);
            this.cameraNumBox.TabIndex = 0;
            this.cameraNumBox.Visible = false;
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Controls.Add(this.displayTouchscreenBox);
            this.displayPanel.Controls.Add(this.displayTouchscreenLabel);
            this.displayPanel.Controls.Add(this.displaySizeBox);
            this.displayPanel.Controls.Add(this.displaySizeLabel);
            this.displayPanel.Controls.Add(this.displayTypeBox);
            this.displayPanel.Controls.Add(this.displayTypeLabel);
            this.displayPanel.Controls.Add(this.displayResolutionLabel);
            this.displayPanel.Controls.Add(this.displayResolutionBox);
            this.displayPanel.Location = new System.Drawing.Point(415, 23);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(146, 325);
            this.displayPanel.TabIndex = 15;
            // 
            // displayTouchscreenBox
            // 
            this.displayTouchscreenBox.CheckOnClick = true;
            this.displayTouchscreenBox.FormattingEnabled = true;
            this.displayTouchscreenBox.Location = new System.Drawing.Point(3, 357);
            this.displayTouchscreenBox.Name = "displayTouchscreenBox";
            this.displayTouchscreenBox.Size = new System.Drawing.Size(120, 34);
            this.displayTouchscreenBox.TabIndex = 7;
            this.displayTouchscreenBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.displayTouchscreenBox_ItemCheck);
            // 
            // displayTouchscreenLabel
            // 
            this.displayTouchscreenLabel.AutoSize = true;
            this.displayTouchscreenLabel.Location = new System.Drawing.Point(3, 341);
            this.displayTouchscreenLabel.Name = "displayTouchscreenLabel";
            this.displayTouchscreenLabel.Size = new System.Drawing.Size(70, 13);
            this.displayTouchscreenLabel.TabIndex = 6;
            this.displayTouchscreenLabel.Text = "Touchscreen";
            // 
            // displaySizeBox
            // 
            this.displaySizeBox.CheckOnClick = true;
            this.displaySizeBox.FormattingEnabled = true;
            this.displaySizeBox.Location = new System.Drawing.Point(3, 244);
            this.displaySizeBox.Name = "displaySizeBox";
            this.displaySizeBox.Size = new System.Drawing.Size(120, 94);
            this.displaySizeBox.TabIndex = 5;
            // 
            // displaySizeLabel
            // 
            this.displaySizeLabel.AutoSize = true;
            this.displaySizeLabel.Location = new System.Drawing.Point(3, 228);
            this.displaySizeLabel.Name = "displaySizeLabel";
            this.displaySizeLabel.Size = new System.Drawing.Size(27, 13);
            this.displaySizeLabel.TabIndex = 4;
            this.displaySizeLabel.Text = "Size";
            // 
            // displayTypeBox
            // 
            this.displayTypeBox.CheckOnClick = true;
            this.displayTypeBox.FormattingEnabled = true;
            this.displayTypeBox.Location = new System.Drawing.Point(3, 131);
            this.displayTypeBox.Name = "displayTypeBox";
            this.displayTypeBox.Size = new System.Drawing.Size(120, 94);
            this.displayTypeBox.TabIndex = 3;
            // 
            // displayTypeLabel
            // 
            this.displayTypeLabel.AutoSize = true;
            this.displayTypeLabel.Location = new System.Drawing.Point(3, 115);
            this.displayTypeLabel.Name = "displayTypeLabel";
            this.displayTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.displayTypeLabel.TabIndex = 2;
            this.displayTypeLabel.Text = "Display Type";
            // 
            // displayResolutionLabel
            // 
            this.displayResolutionLabel.AutoSize = true;
            this.displayResolutionLabel.Location = new System.Drawing.Point(3, 3);
            this.displayResolutionLabel.Name = "displayResolutionLabel";
            this.displayResolutionLabel.Size = new System.Drawing.Size(92, 13);
            this.displayResolutionLabel.TabIndex = 1;
            this.displayResolutionLabel.Text = "Resolution Quality";
            // 
            // displayResolutionBox
            // 
            this.displayResolutionBox.CheckOnClick = true;
            this.displayResolutionBox.FormattingEnabled = true;
            this.displayResolutionBox.Location = new System.Drawing.Point(3, 18);
            this.displayResolutionBox.Name = "displayResolutionBox";
            this.displayResolutionBox.Size = new System.Drawing.Size(120, 94);
            this.displayResolutionBox.TabIndex = 0;
            // 
            // phonePanel
            // 
            this.phonePanel.AutoScroll = true;
            this.phonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonePanel.Controls.Add(this.phonePriceHighLabel);
            this.phonePanel.Controls.Add(this.phonePriceLowLabel);
            this.phonePanel.Controls.Add(this.phonePriceHighTB);
            this.phonePanel.Controls.Add(this.phonePriceLowTB);
            this.phonePanel.Controls.Add(this.phoneBattCapBox);
            this.phonePanel.Controls.Add(this.batteryCapacityLabel);
            this.phonePanel.Controls.Add(this.phoneHeadphoneJackBox);
            this.phonePanel.Controls.Add(this.headphoneJackLabel);
            this.phonePanel.Controls.Add(this.phoneExternalKeyboardBox);
            this.phonePanel.Controls.Add(this.extKeyboardLabel);
            this.phonePanel.Controls.Add(this.phoneRAMBox);
            this.phonePanel.Controls.Add(this.phoneRAMLabel);
            this.phonePanel.Controls.Add(this.phoneExpandableCapacityBox);
            this.phonePanel.Controls.Add(this.phoneExpandableCapacityLabel);
            this.phonePanel.Controls.Add(this.phoneInternalCapacityBox);
            this.phonePanel.Controls.Add(this.phoneInternalCapacityLabel);
            this.phonePanel.Controls.Add(this.phonePriceLabel);
            this.phonePanel.Location = new System.Drawing.Point(563, 22);
            this.phonePanel.Name = "phonePanel";
            this.phonePanel.Size = new System.Drawing.Size(160, 326);
            this.phonePanel.TabIndex = 16;
            // 
            // phonePriceHighLabel
            // 
            this.phonePriceHighLabel.AutoSize = true;
            this.phonePriceHighLabel.Location = new System.Drawing.Point(5, 64);
            this.phonePriceHighLabel.Name = "phonePriceHighLabel";
            this.phonePriceHighLabel.Size = new System.Drawing.Size(49, 13);
            this.phonePriceHighLabel.TabIndex = 17;
            this.phonePriceHighLabel.Text = "High limit";
            // 
            // phonePriceLowLabel
            // 
            this.phonePriceLowLabel.AutoSize = true;
            this.phonePriceLowLabel.Location = new System.Drawing.Point(5, 22);
            this.phonePriceLowLabel.Name = "phonePriceLowLabel";
            this.phonePriceLowLabel.Size = new System.Drawing.Size(47, 13);
            this.phonePriceLowLabel.TabIndex = 16;
            this.phonePriceLowLabel.Text = "Low limit";
            // 
            // phonePriceHighTB
            // 
            this.phonePriceHighTB.Location = new System.Drawing.Point(8, 80);
            this.phonePriceHighTB.Name = "phonePriceHighTB";
            this.phonePriceHighTB.Size = new System.Drawing.Size(100, 20);
            this.phonePriceHighTB.TabIndex = 15;
            // 
            // phonePriceLowTB
            // 
            this.phonePriceLowTB.Location = new System.Drawing.Point(8, 38);
            this.phonePriceLowTB.Name = "phonePriceLowTB";
            this.phonePriceLowTB.Size = new System.Drawing.Size(100, 20);
            this.phonePriceLowTB.TabIndex = 14;
            // 
            // phoneBattCapBox
            // 
            this.phoneBattCapBox.CheckOnClick = true;
            this.phoneBattCapBox.FormattingEnabled = true;
            this.phoneBattCapBox.Location = new System.Drawing.Point(5, 605);
            this.phoneBattCapBox.Name = "phoneBattCapBox";
            this.phoneBattCapBox.Size = new System.Drawing.Size(120, 94);
            this.phoneBattCapBox.TabIndex = 13;
            // 
            // batteryCapacityLabel
            // 
            this.batteryCapacityLabel.AutoSize = true;
            this.batteryCapacityLabel.Location = new System.Drawing.Point(5, 589);
            this.batteryCapacityLabel.Name = "batteryCapacityLabel";
            this.batteryCapacityLabel.Size = new System.Drawing.Size(84, 13);
            this.batteryCapacityLabel.TabIndex = 12;
            this.batteryCapacityLabel.Text = "Battery Capacity";
            // 
            // phoneHeadphoneJackBox
            // 
            this.phoneHeadphoneJackBox.CheckOnClick = true;
            this.phoneHeadphoneJackBox.FormattingEnabled = true;
            this.phoneHeadphoneJackBox.Location = new System.Drawing.Point(5, 536);
            this.phoneHeadphoneJackBox.Name = "phoneHeadphoneJackBox";
            this.phoneHeadphoneJackBox.Size = new System.Drawing.Size(120, 34);
            this.phoneHeadphoneJackBox.TabIndex = 11;
            this.phoneHeadphoneJackBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.phoneHeadphoneJackBox_ItemCheck);
            // 
            // headphoneJackLabel
            // 
            this.headphoneJackLabel.AutoSize = true;
            this.headphoneJackLabel.Location = new System.Drawing.Point(5, 520);
            this.headphoneJackLabel.Name = "headphoneJackLabel";
            this.headphoneJackLabel.Size = new System.Drawing.Size(89, 13);
            this.headphoneJackLabel.TabIndex = 10;
            this.headphoneJackLabel.Text = "Headphone Jack";
            // 
            // phoneExternalKeyboardBox
            // 
            this.phoneExternalKeyboardBox.CheckOnClick = true;
            this.phoneExternalKeyboardBox.FormattingEnabled = true;
            this.phoneExternalKeyboardBox.Location = new System.Drawing.Point(5, 471);
            this.phoneExternalKeyboardBox.Name = "phoneExternalKeyboardBox";
            this.phoneExternalKeyboardBox.Size = new System.Drawing.Size(120, 34);
            this.phoneExternalKeyboardBox.TabIndex = 9;
            this.phoneExternalKeyboardBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.phoneExternalKeyboardBox_ItemCheck);
            // 
            // extKeyboardLabel
            // 
            this.extKeyboardLabel.AutoSize = true;
            this.extKeyboardLabel.Location = new System.Drawing.Point(5, 455);
            this.extKeyboardLabel.Name = "extKeyboardLabel";
            this.extKeyboardLabel.Size = new System.Drawing.Size(67, 13);
            this.extKeyboardLabel.TabIndex = 8;
            this.extKeyboardLabel.Text = "Ext. Keybard";
            // 
            // phoneRAMBox
            // 
            this.phoneRAMBox.CheckOnClick = true;
            this.phoneRAMBox.FormattingEnabled = true;
            this.phoneRAMBox.Location = new System.Drawing.Point(5, 358);
            this.phoneRAMBox.Name = "phoneRAMBox";
            this.phoneRAMBox.Size = new System.Drawing.Size(120, 94);
            this.phoneRAMBox.TabIndex = 7;
            // 
            // phoneRAMLabel
            // 
            this.phoneRAMLabel.AutoSize = true;
            this.phoneRAMLabel.Location = new System.Drawing.Point(5, 342);
            this.phoneRAMLabel.Name = "phoneRAMLabel";
            this.phoneRAMLabel.Size = new System.Drawing.Size(56, 13);
            this.phoneRAMLabel.TabIndex = 6;
            this.phoneRAMLabel.Text = "RAM (MB)";
            // 
            // phoneExpandableCapacityBox
            // 
            this.phoneExpandableCapacityBox.CheckOnClick = true;
            this.phoneExpandableCapacityBox.FormattingEnabled = true;
            this.phoneExpandableCapacityBox.Location = new System.Drawing.Point(5, 245);
            this.phoneExpandableCapacityBox.Name = "phoneExpandableCapacityBox";
            this.phoneExpandableCapacityBox.Size = new System.Drawing.Size(120, 94);
            this.phoneExpandableCapacityBox.TabIndex = 5;
            // 
            // phoneExpandableCapacityLabel
            // 
            this.phoneExpandableCapacityLabel.AutoSize = true;
            this.phoneExpandableCapacityLabel.Location = new System.Drawing.Point(5, 229);
            this.phoneExpandableCapacityLabel.Name = "phoneExpandableCapacityLabel";
            this.phoneExpandableCapacityLabel.Size = new System.Drawing.Size(132, 13);
            this.phoneExpandableCapacityLabel.TabIndex = 4;
            this.phoneExpandableCapacityLabel.Text = "Expandable Capacity (MB)";
            // 
            // phoneInternalCapacityBox
            // 
            this.phoneInternalCapacityBox.CheckOnClick = true;
            this.phoneInternalCapacityBox.FormattingEnabled = true;
            this.phoneInternalCapacityBox.Location = new System.Drawing.Point(3, 131);
            this.phoneInternalCapacityBox.Name = "phoneInternalCapacityBox";
            this.phoneInternalCapacityBox.Size = new System.Drawing.Size(120, 94);
            this.phoneInternalCapacityBox.TabIndex = 3;
            // 
            // phoneInternalCapacityLabel
            // 
            this.phoneInternalCapacityLabel.AutoSize = true;
            this.phoneInternalCapacityLabel.Location = new System.Drawing.Point(3, 115);
            this.phoneInternalCapacityLabel.Name = "phoneInternalCapacityLabel";
            this.phoneInternalCapacityLabel.Size = new System.Drawing.Size(111, 13);
            this.phoneInternalCapacityLabel.TabIndex = 2;
            this.phoneInternalCapacityLabel.Text = "Internal Capacity (MB)";
            // 
            // phonePriceLabel
            // 
            this.phonePriceLabel.AutoSize = true;
            this.phonePriceLabel.Location = new System.Drawing.Point(5, 2);
            this.phonePriceLabel.Name = "phonePriceLabel";
            this.phonePriceLabel.Size = new System.Drawing.Size(31, 13);
            this.phonePriceLabel.TabIndex = 1;
            this.phonePriceLabel.Text = "Price";
            // 
            // networkPanel
            // 
            this.networkPanel.AutoScroll = true;
            this.networkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkPanel.Controls.Add(this.networkTypeBox);
            this.networkPanel.Location = new System.Drawing.Point(729, 23);
            this.networkPanel.Name = "networkPanel";
            this.networkPanel.Size = new System.Drawing.Size(67, 45);
            this.networkPanel.TabIndex = 17;
            // 
            // networkTypeBox
            // 
            this.networkTypeBox.CheckOnClick = true;
            this.networkTypeBox.FormattingEnabled = true;
            this.networkTypeBox.Items.AddRange(new object[] {
            "GSM",
            "CDMA"});
            this.networkTypeBox.Location = new System.Drawing.Point(3, 3);
            this.networkTypeBox.Name = "networkTypeBox";
            this.networkTypeBox.Size = new System.Drawing.Size(59, 34);
            this.networkTypeBox.TabIndex = 0;
            // 
            // carrierPanel
            // 
            this.carrierPanel.AutoScroll = true;
            this.carrierPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carrierPanel.Controls.Add(this.carrierNameBox);
            this.carrierPanel.Location = new System.Drawing.Point(729, 87);
            this.carrierPanel.Name = "carrierPanel";
            this.carrierPanel.Size = new System.Drawing.Size(126, 100);
            this.carrierPanel.TabIndex = 18;
            // 
            // carrierNameBox
            // 
            this.carrierNameBox.CheckOnClick = true;
            this.carrierNameBox.FormattingEnabled = true;
            this.carrierNameBox.Location = new System.Drawing.Point(3, 5);
            this.carrierNameBox.Name = "carrierNameBox";
            this.carrierNameBox.Size = new System.Drawing.Size(113, 79);
            this.carrierNameBox.TabIndex = 0;
            // 
            // ManufacturePanel
            // 
            this.ManufacturePanel.AutoScroll = true;
            this.ManufacturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturePanel.Controls.Add(this.manufacturerBox);
            this.ManufacturePanel.Location = new System.Drawing.Point(115, 206);
            this.ManufacturePanel.Name = "ManufacturePanel";
            this.ManufacturePanel.Size = new System.Drawing.Size(176, 142);
            this.ManufacturePanel.TabIndex = 19;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.CheckOnClick = true;
            this.manufacturerBox.FormattingEnabled = true;
            this.manufacturerBox.Location = new System.Drawing.Point(3, 3);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(168, 94);
            this.manufacturerBox.TabIndex = 0;
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
            "Internal Capacity (Low-High)",
            "Manufacturer (A-Z)"});
            this.orderByComboBox.Location = new System.Drawing.Point(729, 210);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderByComboBox.TabIndex = 21;
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(726, 194);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(45, 13);
            this.orderByLabel.TabIndex = 20;
            this.orderByLabel.Text = "order by";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(729, 322);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 23);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(865, 354);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderByComboBox);
            this.Controls.Add(this.orderByLabel);
            this.Controls.Add(this.ManufacturePanel);
            this.Controls.Add(this.carrierPanel);
            this.Controls.Add(this.networkPanel);
            this.Controls.Add(this.phonePanel);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.cameraPanel);
            this.Controls.Add(this.OSPanel);
            this.Controls.Add(this.phoneCatagoryLabel);
            this.Controls.Add(this.displayCatagoryLabel);
            this.Controls.Add(this.manufacturerCatagoryLabel);
            this.Controls.Add(this.carrierCatagoryLabel);
            this.Controls.Add(this.networkCatagoryLabel);
            this.Controls.Add(this.cameraCatagoryLabel);
            this.Controls.Add(this.OSCatagoryLabel);
            this.Controls.Add(this.CPUPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.CPUCatagoryLabel);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.Load += new System.EventHandler(this.AdvancedSearch_Load);
            this.CPUPanel.ResumeLayout(false);
            this.CPUPanel.PerformLayout();
            this.OSPanel.ResumeLayout(false);
            this.cameraPanel.ResumeLayout(false);
            this.cameraPanel.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.phonePanel.ResumeLayout(false);
            this.phonePanel.PerformLayout();
            this.networkPanel.ResumeLayout(false);
            this.carrierPanel.ResumeLayout(false);
            this.ManufacturePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CPUFreqBox;
        private System.Windows.Forms.Label CPUCatagoryLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel CPUPanel;
        private System.Windows.Forms.CheckedListBox CPUCoreBox;
        private System.Windows.Forms.Label CPUCoresLabel;
        private System.Windows.Forms.Label CPUFrequencyLabel;
        private System.Windows.Forms.Label OSCatagoryLabel;
        private System.Windows.Forms.Label cameraCatagoryLabel;
        private System.Windows.Forms.Label networkCatagoryLabel;
        private System.Windows.Forms.Label carrierCatagoryLabel;
        private System.Windows.Forms.Label manufacturerCatagoryLabel;
        private System.Windows.Forms.Label displayCatagoryLabel;
        private System.Windows.Forms.Label phoneCatagoryLabel;
        private System.Windows.Forms.Panel OSPanel;
        private System.Windows.Forms.CheckedListBox OSBox;
        private System.Windows.Forms.Panel cameraPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox cameraOpticalZoomBox;
        private System.Windows.Forms.CheckedListBox cameraMPixBox;
        private System.Windows.Forms.Label cameraOpticalZoomLabel;
        private System.Windows.Forms.Label cameraMPixelsLabel;
        private System.Windows.Forms.Label cameraNumCamerasLabel;
        private System.Windows.Forms.CheckedListBox cameraNumBox;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.CheckedListBox displayTouchscreenBox;
        private System.Windows.Forms.Label displayTouchscreenLabel;
        private System.Windows.Forms.CheckedListBox displaySizeBox;
        private System.Windows.Forms.Label displaySizeLabel;
        private System.Windows.Forms.CheckedListBox displayTypeBox;
        private System.Windows.Forms.Label displayTypeLabel;
        private System.Windows.Forms.Label displayResolutionLabel;
        private System.Windows.Forms.CheckedListBox displayResolutionBox;
        private System.Windows.Forms.Panel phonePanel;
        private System.Windows.Forms.CheckedListBox phoneBattCapBox;
        private System.Windows.Forms.Label batteryCapacityLabel;
        private System.Windows.Forms.CheckedListBox phoneHeadphoneJackBox;
        private System.Windows.Forms.Label headphoneJackLabel;
        private System.Windows.Forms.CheckedListBox phoneExternalKeyboardBox;
        private System.Windows.Forms.Label extKeyboardLabel;
        private System.Windows.Forms.CheckedListBox phoneRAMBox;
        private System.Windows.Forms.Label phoneRAMLabel;
        private System.Windows.Forms.CheckedListBox phoneExpandableCapacityBox;
        private System.Windows.Forms.Label phoneExpandableCapacityLabel;
        private System.Windows.Forms.CheckedListBox phoneInternalCapacityBox;
        private System.Windows.Forms.Label phoneInternalCapacityLabel;
        private System.Windows.Forms.Label phonePriceLabel;
        private System.Windows.Forms.Panel networkPanel;
        private System.Windows.Forms.CheckedListBox networkTypeBox;
        private System.Windows.Forms.Panel carrierPanel;
        private System.Windows.Forms.CheckedListBox carrierNameBox;
        private System.Windows.Forms.Panel ManufacturePanel;
        private System.Windows.Forms.CheckedListBox manufacturerBox;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label phonePriceHighLabel;
        private System.Windows.Forms.Label phonePriceLowLabel;
        private System.Windows.Forms.TextBox phonePriceHighTB;
        private System.Windows.Forms.TextBox phonePriceLowTB;
    }
}