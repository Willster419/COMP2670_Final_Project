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
        public string orderPart;
        FullInfo FI;
        Compare comp = new Compare();
        public List<Phone> phoneList;
        MySqlConnection conn;
        DataSet phoneDataSet;

        public Test()
        {
            InitializeComponent();
            phoneList = new List<Phone>();
        }

        public Test(string queryy, string theOrderPart)
        {
            query = queryy;
            orderPart = theOrderPart;
            InitializeComponent();
            phoneList = new List<Phone>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.RowCount++;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute,220));
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //take search query and parse it into arraylist
            phoneDataSet = this.runQuery(query);
            //parse it into the list of phone ID's
            DataTable dt = phoneDataSet.Tables[0];
            List<int> phoneIDArray = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                phoneIDArray.Add((int)dr.ItemArray[0]);//just the phone ID
            }
            //have it run a new query to return all individual/unique phone information for the results page
            //based on phoneID array
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Phone.phoneID," +//0
            "Manufacturer.name,Phone.name,CPU.frequency," +//1,2,3
            "CPU.numCores,Phone.RAMcapacity,Phone.price," +//4,5,6
            "OS.name,Phone.pictureURL,Phone.internalCapacity," +//7,8,9
            "CPU.cpuID,Manufacturer.manufacturerID,OS.OSID," +//10,11,12
            "Phone.analogAudioJack,Phone.batteryCapacity," +//13,14
            "Phone.chargePortID,ChargePort.name,CPU.model," +//15,16,17
            "CPU.brand,Display.displayID,Display.displayType," +//18,19,20
            "Display.isTouchscreen,Display.heightPixels," +//21,22
            "Display.widthPixels,Display.sizeInches,Display.DPI," +//23,24,25
            "Phone.monthReleased,Phone.yearReleased," +//26,27
            "Phone.expandableCapacity,Phone.hasExternalKeyboard," +//28,29
            "Phone.isUnlocked,Phone.numExternalSpeakers,SIM.numCards," +//30,31,32
            "Phone.physicalHomeButton,SIM.type,Phone.stillAvailable,Phone.weight" +//33,34,35,36
            " from Phone" +
            " inner join Manufacturer on Manufacturer.manufacturerID=Phone.manufacturerID" +
            " inner join OS on OS.OSID=Phone.OSID" +
            " inner join CPU on CPU.CPUID=Phone.CPUID" +
            " inner join ChargePort on ChargePort.chargePortID=Phone.chargePortID" +
            " inner join Display on Display.displayID=Phone.displayID" +
            " inner join SIM on SIM.phoneID=Phone.phoneID" +
            " where Phone.phoneID=");
            
            foreach (int i in phoneIDArray)
            {
                sb.Append("" + i + " or ");
            }
            if (phoneIDArray.Count == 0)
                return;
            string tempQuery = sb.ToString();
            tempQuery = tempQuery.Substring(0, tempQuery.Length - 4);
            tempQuery = tempQuery + orderPart;
            phoneDataSet = this.runQuery(tempQuery);
            DataTable dt2 = phoneDataSet.Tables[0];
            foreach (DataRow dr in dt2.Rows)
            {
                int i = 0;
                Phone p = new Phone();
                p.phoneID = (int)dr.ItemArray[i++];//0
                p.manufactureName = (string)dr.ItemArray[i++];
                p.name = (string)dr.ItemArray[i++];
                p.CPUFreq = (float)dr.ItemArray[i++];
                p.CPUNumCores = (int)dr.ItemArray[i++];
                p.RAMcapacity = (int)dr.ItemArray[i++];//5
                p.price = (float)dr.ItemArray[i++];
                p.OSName = (string)dr.ItemArray[i++];
                p.pictureURL = (string)dr.ItemArray[i++];
                p.internalCapacity = (int)dr.ItemArray[i++];
                p.CPUID = (int)dr.ItemArray[i++];//10
                p.manufacturerID = (int)dr.ItemArray[i++];
                p.OSID = (int)dr.ItemArray[i++];
                p.analogAudioJack = (bool)dr.ItemArray[i++];
                p.batteryCapacity = (int)dr.ItemArray[i++];
                p.chargePortID = (int)dr.ItemArray[i++];//15
                p.chargePortname = (string)dr.ItemArray[i++];
                p.CPUModel = (string)dr.ItemArray[i++];
                p.CPUName = (string)dr.ItemArray[i++];
                p.displayID = (int)dr.ItemArray[i++];
                p.displayType = (string)dr.ItemArray[i++];//20
                p.displayIsTouchScreen = (bool)dr.ItemArray[i++];
                p.displayHeightPixels = (int)dr.ItemArray[i++];
                p.displayWidthPixels = (int)dr.ItemArray[i++];
                p.displaySizeInches = (float)dr.ItemArray[i++];
                p.displayDpi = (int)dr.ItemArray[i++];//25
                p.monthReleased = (int)dr.ItemArray[i++];
                p.yearReleased = (int)dr.ItemArray[i++];
                p.expandableCapacity = (int)dr.ItemArray[i++];
                p.hasExternalKeyboard = (bool)dr.ItemArray[i++];
                p.isUnlocked = (bool)dr.ItemArray[i++];//30
                p.numExternalSpeakers = (int)dr.ItemArray[i++];
                p.numSimCards = (int)dr.ItemArray[i++];
                p.physicalHomeButton = (bool)dr.ItemArray[i++];
                p.simCardType = (string)dr.ItemArray[i++];
                p.stillAvailable = (bool)dr.ItemArray[i++];//35
                p.weight = (float)dr.ItemArray[i++];
                this.phoneList.Add(p);
            }

            //parse phone GSMCDMA type
            this.isGSMCDMA();
            //parse arrayLists
            this.addArrayInformation();
            //add to results display
            foreach (Phone p in phoneList)
            {
                this.addResult(p.manufactureName, "" + p.phoneID, p.name, "" + p.CPUFreq, "" + p.CPUNumCores, "" + p.RAMcapacity, p.isGSMCDMA, "" + p.price, p.OSName, p.pictureURL, "" + p.internalCapacity);
            }
        }
        private void isGSMCDMA()
        {
            //create dataset list of GSM and CDMA phones
            string GSMquery = "select DISTINCT Phone.phoneID, Network.type" +
            " from Phone" +
            " inner join PhoneCarrier on Phone.phoneID=PhoneCarrier.phoneID" +
            " inner join Carrier on Carrier.carrierID=PhoneCarrier.carrierID" +
            " inner join Network on Network.networkID=Carrier.NetworkID" +
            " inner join SIM on SIM.phoneID=Phone.phoneID" +
            " where Network.type='GSM'";
            string CDMAquery = "select DISTINCT Phone.phoneID, Network.type" +
            " from Phone inner join PhoneCarrier on Phone.phoneID=PhoneCarrier.phoneID" +
            " inner join Carrier on Carrier.carrierID=PhoneCarrier.carrierID" +
            " inner join Network on Network.networkID=Carrier.NetworkID" +
            " inner join SIM on SIM.phoneID=Phone.phoneID" +
            " where Network.type='CDMA'";
            DataSet GSMDataSet = new DataSet();
            DataSet CDMADataset = new DataSet();

            foreach (Phone p in phoneList)
            {
                //run through list of GSM phones
                GSMDataSet = runQuery(GSMquery);
                DataTable dt = GSMDataSet.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    int phoneIDEE = (int)dr.ItemArray[0];
                    string phoneTypeee = (string)dr.ItemArray[1];
                    if (p.phoneID == phoneIDEE)
                        p.isGSMCDMA = p.isGSMCDMA + phoneTypeee;
                }
            }

            foreach (Phone p in phoneList)
            {
                //run through list of CDMA phones
                CDMADataset = runQuery(CDMAquery);
                DataTable dt = CDMADataset.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    int phoneIDEE = (int)dr.ItemArray[0];
                    string phoneTypeee = (string)dr.ItemArray[1];
                    if (p.phoneID == phoneIDEE)
                        p.isGSMCDMA = p.isGSMCDMA + "/" + phoneTypeee;
                }
            }
            
        }

        private void addResult(string manufactureName,
            string phoneID,
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
            newPhoneFullInfoLink.LinkClicked += new LinkLabelLinkClickedEventHandler(newPhoneFullInfoLink_LinkClicked);
            newPhoneFullInfoLink.Links[0].Description = phoneID;
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
            newPhonePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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

        void newPhoneFullInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FI = new FullInfo();
            string temp = e.Link.Description;
            foreach (Phone p in phoneList)
            {
                string phoneIDD = "" + p.phoneID;
                if (phoneIDD == temp)
                    FI.samplePhone = p;
            }
            FI.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataSet runQuery(string queryyy)
        {
            bool switchh = true;
            if (switchh)
            {
                conn = new MySqlConnection("Server=10.14.52.125;Database=cellphone;Uid=root;");
            }
            else
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=cellphone;Uid=root;");
            }

            DataSet tempDataSet = new DataSet();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryyy;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                
                adap.Fill(tempDataSet);
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            conn.Close();
            return tempDataSet;
        }

        private void addArrayInformation()
        {
            //run through list of camera
            DataSet cameraDataSet = new DataSet();
            string cameraQuery = "select Phone.phoneID," +
            " Camera.cameraID, Camera.resolutionWidthPixels," +
            "Camera.resolutionHeightPixels,Camera.mPixels,Camera.fps," +
            "Camera.opticalZoom,Camera.location" +
            " from Phone" +
            " inner join PhoneCamera on Phone.phoneID=PhoneCamera.phoneID" +
            " inner join Camera on Camera.cameraID=PhoneCamera.cameraID";
            foreach (Phone p in phoneList)
            {
                cameraDataSet = runQuery(cameraQuery);
                DataTable dt = cameraDataSet.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    int phoneIDEE = (int)dr.ItemArray[0];
                    if (p.phoneID == phoneIDEE)
                    {
                        //add cameras to list
                        Camera c = new Camera();
                        c.cameraID = (int)dr.ItemArray[1];
                        c.resolutionWidthPixels = (int)dr.ItemArray[2];
                        c.resolutionHeightPixels = (int)dr.ItemArray[3];
                        c.mPixels = (float)dr.ItemArray[4];
                        c.fps = (int)dr.ItemArray[5];
                        c.opticalZoom = (int)dr.ItemArray[6];
                        c.location = (string)dr.ItemArray[7];
                        p.cameraList.Add(c);
                    }
                }
            }
            //run through list of carriers
            DataSet carrierDataSet = new DataSet();
            string carrierQuery = "select PhoneCarrier.phoneID," +
            "Carrier.carrierID,Carrier.name,Network.networkID,Network.type" +
            " from PhoneCarrier" +
            " inner join Carrier on Carrier.carrierID=PhoneCarrier.carrierID" +
            " inner join Network on Network.networkID=Carrier.networkID";
            foreach (Phone p in phoneList)
            {
                carrierDataSet = runQuery(carrierQuery);
                DataTable dt = carrierDataSet.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    int phoneIDEE = (int)dr.ItemArray[0];
                    if (p.phoneID == phoneIDEE)
                    {
                        //add carriers to list
                        Carrier c = new Carrier();
                        c.carrierID = (int)dr.ItemArray[1];
                        c.name = (string)dr.ItemArray[2];
                        c.networkID = (int)dr.ItemArray[3];
                        c.networkName = (string)dr.ItemArray[4];
                        p.carrierList.Add(c);
                    }
                }
            }
            //run through list of sensors
            DataSet sensorDataSet = new DataSet();
            string sensorQuery = "select PhoneSensor.phoneID," +
            "Sensor.sensorID,Sensor.name" +
            " from PhoneSensor" +
            " inner join Sensor on Sensor.sensorID=PhoneSensor.sensorID";
            foreach (Phone p in phoneList)
            {
                sensorDataSet = runQuery(sensorQuery);
                DataTable dt = sensorDataSet.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    int phoneIDEE = (int)dr.ItemArray[0];
                    if (p.phoneID == phoneIDEE)
                    {
                        //add sensor
                        Sensor s = new Sensor();
                        s.sensorID = (int)dr.ItemArray[1];
                        s.name = (string)dr.ItemArray[2];
                        p.sensorList.Add(s);
                    }
                }
            }
            //run through list of feature
            DataSet featureDataSet = new DataSet();
            string featureQuery = "select PhoneFeature.phoneID,Feature.featureID,Feature.name" +
            " from PhoneFeature inner join Feature on Feature.featureID=PhoneFeature.featureID";
            foreach (Phone p in phoneList)
            {
                featureDataSet = runQuery(featureQuery);
                DataTable dt = featureDataSet.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    int phoneIDEE = (int)dr.ItemArray[0];
                    if (p.phoneID == phoneIDEE)
                    {
                        //add feature to list
                        Feature f = new Feature();
                        f.featureID = (int)dr.ItemArray[1];
                        f.name = (string)dr.ItemArray[2];
                        p.featureList.Add(f);
                    }
                }
            }
        }
    }
}
