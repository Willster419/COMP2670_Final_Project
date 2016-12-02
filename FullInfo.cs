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
using System.Globalization;

namespace GameOfPhones
{
    public partial class FullInfo : Form
    {
        MySqlConnection conn;
        DataSet phoneDataSet;
        public Phone samplePhone;

        public FullInfo()
        {
            InitializeComponent();
            samplePhone = new Phone();
            phoneDataSet = new DataSet();
        }

        private void FullInfo_Load(object sender, EventArgs e)
        {
            //parse the single values
            analogHeadphoneJackValue.Text = yesNo(samplePhone.analogAudioJack);
            batteryCapacityValue.Text = "" + samplePhone.batteryCapacity;
            chargePortValue.Text = samplePhone.chargePortname;
            CPUBrandValue.Text = samplePhone.CPUName;
            CPUCoresValue.Text = "" + samplePhone.CPUNumCores;
            CPUFreqValue.Text = "" + samplePhone.CPUFreq;
            CPUModelValue.Text = samplePhone.CPUModel;
            displayDPIValue.Text = "" + samplePhone.displayDpi;
            displayResValue.Text = "" + samplePhone.displayWidthPixels + " x " + samplePhone.displayHeightPixels;
            displaySizeValue.Text = "" + samplePhone.displaySizeInches;
            displayTouchscreenValue.Text = yesNo(samplePhone.displayIsTouchScreen);
            displayTypeValue.Text = samplePhone.displayType;
            expCapValue.Text = "" + samplePhone.expandableCapacity;
            extKeyValue.Text = yesNo(samplePhone.hasExternalKeyboard);
            internalCapValue.Text = "" + samplePhone.internalCapacity;
            manufactureValue.Text = samplePhone.manufactureName;
            monthReleasedValue.Text = int2Month(samplePhone.monthReleased);
            nameValue.Text = samplePhone.name;
            numSimCardsValue.Text = "" + samplePhone.numSimCards;
            numSpeakersValue.Text = "" + samplePhone.numExternalSpeakers;
            OSValue.Text = samplePhone.OSName;
            physicalHomeButtonValue.Text = yesNo(samplePhone.physicalHomeButton);
            priceValue.Text = "$" + samplePhone.price;
            RAMCapValue.Text = "" + samplePhone.RAMcapacity;
            simCardTypeValue.Text = samplePhone.simCardType;
            stillProducedValue.Text = yesNo(samplePhone.stillAvailable);
            unlockedValue.Text = yesNo(samplePhone.isUnlocked);
            weightValue.Text = "" + samplePhone.weight;
            yearReleasedValue.Text = "" + samplePhone.yearReleased;
            phonePictureBox.ImageLocation = samplePhone.pictureURL;
            //parse the multivalues
            featureListBox.Items.Clear();
            foreach (Feature f in samplePhone.featureList)
            {
                featureListBox.Items.Add(f);
            }
            sensorListBox.Items.Clear();
            foreach (Sensor s in samplePhone.sensorList)
            {
                sensorListBox.Items.Add(s);
            }
            CarrierListBox.Items.Clear();
            foreach (Carrier c in samplePhone.carrierList)
            {
                CarrierListBox.Items.Add(c);
            }
            phoneDataSet = runQuery("select COUNT(PhoneCamera.cameraID) from PhoneCamera where PhoneCamera.phoneID=" + samplePhone.phoneID);
            DataTable dt = phoneDataSet.Tables[0];
            DataRow dr = dt.Rows[0];
            Int64 numCameras = (Int64)dr.ItemArray[0];
            CameraLabel.Text = "Cameras (Total " + numCameras + ")";
            cameraTableLayout.RowCount = 0;
            cameraTableLayout.RowStyles.Clear();
            int cameraCounter = 0;
            int currentRow = 0;
            foreach (Camera c in samplePhone.cameraList)
            {
                cameraCounter++;
                for (int i = 0; i < 5; i++)
                {
                    currentRow++;
                    cameraTableLayout.RowCount++;
                    cameraTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute,20));
                }
                Label cameraResolutionTitle = new Label();
                cameraResolutionTitle.Text = "Camera " + cameraCounter + " Resolution";
                cameraResolutionTitle.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraResolutionTitle);

                Label cameraResolutionValue = new Label();
                cameraResolutionValue.Text = "" + c.resolutionWidthPixels + " x " + c.resolutionHeightPixels;
                cameraResolutionValue.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraResolutionValue);

                Label cameraOpticalZoomTitle = new Label();
                cameraOpticalZoomTitle.Text = "Camera " + cameraCounter + " Optical Zoom";
                cameraOpticalZoomTitle.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraOpticalZoomTitle);

                Label cameraOpticalZoomValue = new Label();
                if (c.opticalZoom == 0)
                {
                    cameraOpticalZoomValue.Text = "None";
                }
                else
                {
                    cameraOpticalZoomValue.Text = "" + c.opticalZoom + "x";
                }
                cameraOpticalZoomValue.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraOpticalZoomValue);

                Label cameraMPixTitle = new Label();
                cameraMPixTitle.Text = "Camera " + cameraCounter + " Megapixel";
                cameraMPixTitle.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraMPixTitle);

                Label cameraMPixValue = new Label();
                cameraMPixValue.Text = "" + c.mPixels;
                cameraMPixValue.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraMPixValue);

                Label camerafpsTitle = new Label();
                camerafpsTitle.Text = "Camera " + cameraCounter + " Max FPS";
                camerafpsTitle.AutoSize = true;
                cameraTableLayout.Controls.Add(camerafpsTitle);

                Label camerafpsValue = new Label();
                camerafpsValue.Text = "" + c.fps;
                camerafpsValue.AutoSize = true;
                cameraTableLayout.Controls.Add(camerafpsValue);

                Label cameraLocationTitle = new Label();
                cameraLocationTitle.Text = "Camera " + cameraCounter + " Location";
                cameraLocationTitle.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraLocationTitle);

                Label cameraLocationValue = new Label();
                cameraLocationValue.Text = c.location;
                cameraLocationValue.AutoSize = true;
                cameraTableLayout.Controls.Add(cameraLocationValue);
            }
        }

        private DataSet runQuery(string queryy)
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
                cmd.CommandText = queryy;
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

        private string yesNo(bool b)
        {
            if (b)
                return "Yes";
            else
                return "No";
        }

        private string int2Month(int month)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }
    }
}
