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
    public partial class AdvancedSearch : Form
    {
        private string cpuFreqQuery = "Select distinct CPU.frequency from CPU order by CPU.frequency asc";
        private string cpuNumCoresQuery = "Select distinct CPU.numCores from CPU order by CPU.numCores asc";
        private string osQuery= "Select distinct OS.name from OS order by OS.name asc";
        private string manufactureQuery = "Select distinct Manufacturer.name from Manufacturer order by Manufacturer.name asc";
        //private string cameraSumQuery = "select count(PhoneCamera.cameraID) FROM PhoneCamera where PhoneCamera.phoneID=(SELECT Phone.phoneID from Phone)";//might not work
        private string cameraSumQuery = "select distinct count(PhoneCamera.cameraID) FROM PhoneCamera GROUP BY PhoneCamera.phoneID";//this one will prolly work
        private string cameraMPixQuery = "Select distinct Camera.mPixels from Camera order by Camera.mPixels asc";
        private string cameraOpticalZoomQuery= "Select distinct Camera.opticalZoom from Camera order by Camera.opticalZoom asc";
        private string displayResQuery = "SELECT DISTINCT Display.heightPixels, Display.widthPixels from Display order by Display.heightPixels asc, Display.widthPixels asc";
        private string displayTypeQuery= "Select distinct Display.displayType from Display order by Display.displayType asc";
        private string displaySizeQuery = "Select distinct Display.sizeInches from Display order by Display.sizeInches asc";
        private string displayTouchScreenQuery = "Select distinct Display.isTouchscreen from Display";
        private string phoneLowQuery = "SELECT MIN(Phone.price) AS 'min_phone_price' FROM Phone";
        private string phoneHighQuery = "SELECT MAX(Phone.price) AS 'max_phone_price' FROM Phone";
        private string phoneInternalQuery = "Select distinct Phone.internalCapacity from Phone order by Phone.internalCapacity asc";
        private string phoneExpandableQuery = "Select distinct Phone.expandableCapacity from Phone order by Phone.expandableCapacity asc";
        private string phoneRAMQuery = "Select distinct Phone.RAMcapacity from Phone order by Phone.RAMCapacity asc";
        private string phoneExtKeyQuery = "Select distinct Phone.hasExternalKeyboard from Phone";
        private string phoneHeadphoneJackQuery = "Select distinct Phone.analogAudioJack from Phone";
        private string phoneBattCapQuery = "Select distinct Phone.batteryCapacity from Phone order by Phone.batteryCapacity asc";
        private string networkQuery = "Select distinct Network.type from Network order by Network.type asc";
        private string carrierQuery= "Select distinct Carrier.name from Carrier order by Carrier.name asc";
        //private List<string> queryArray = new List<string>();
        public string query;
        MySqlConnection conn;
        public bool cont = false;
        public string orderPart;
        private bool isFirstQuery = false;

        public AdvancedSearch()
        {
            InitializeComponent();
            /*
             * Don't need this
             * queryArray.Add(cpuFreqQuery);
            queryArray.Add(cpuNumCoresQuery);
            queryArray.Add(osQuery);
            queryArray.Add(manufactureQuery);
            queryArray.Add(cameraSumQuery);
            queryArray.Add(cameraMPixQuery);
            queryArray.Add(cameraOpticalZoomQuery);
            queryArray.Add(displayResQuery);
            queryArray.Add(displayTypeQuery);
            queryArray.Add(displaySizeQuery);
            queryArray.Add(displayTouchScreenQuery);
            queryArray.Add(phoneLowQuery);
            queryArray.Add(phoneHighQuery);
            queryArray.Add(phoneInternalQuery);
            queryArray.Add(phoneExpandableQuery);
            queryArray.Add(phoneRAMQuery);
            queryArray.Add(phoneExtKeyQuery);
            queryArray.Add(phoneHeadphoneJackQuery);
            queryArray.Add(phoneBattCapQuery);
            queryArray.Add(networkQuery);
            queryArray.Add(carrierQuery);*/
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //create query
            query = this.createQuery();
            //select order by part
            orderPart = "";
            switch (orderByComboBox.SelectedIndex)
            {
                case 0://none

                    break;

                case 2://price high-low
                    orderPart = " order by Phone.price desc";
                    break;

                case 1://price low-high
                    orderPart = " order by Phone.price asc";
                    break;

                case 3://name
                    orderPart = " order by Phone.name asc";
                    break;

                case 5://internal capacity
                    orderPart = " order by Phone.internalCapacity asc";
                    break;

                case 4://RAM
                    orderPart = " order by Phone.RAMcapacity asc";
                    break;

                case 6://Manufacturer
                    orderPart = " order by Manufacturer.name asc";
                    break;
            }
            cont = true;
            this.Close();
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            orderByComboBox.SelectedIndex = 0;
            //clear each table
            this.clearEntries();
            //load each table
            this.addEntries();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearEntries()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    Panel p = (Panel)c;
                    foreach (Control cc in p.Controls)
                    {
                        if (cc.GetType() == typeof(CheckedListBox))
                        {
                            CheckedListBox CLB = (CheckedListBox)cc;
                            CLB.Items.Clear();
                        }
                    }
                }
            }
        }

        private void addEntries()
        {
            DataRowCollection drc;
            //CPU number of cores
            drc = runQuery(cpuNumCoresQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                CPUCoreBox.Items.Add(o);
            }
            //CPU frequency
            drc = runQuery(cpuFreqQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                CPUFreqBox.Items.Add(o);
            }
            //OS
            drc = runQuery(osQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                OSBox.Items.Add(o);
            }
            //Manufacturer
            drc = runQuery(manufactureQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                manufacturerBox.Items.Add(o);
            }
            //Camera Number of*
            drc = runQuery(cameraSumQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                cameraNumBox.Items.Add(o);
            }
            //Camera MPix
            drc = runQuery(cameraMPixQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                cameraMPixBox.Items.Add(o);
            }
            //Camera Optical Zoom
            drc = runQuery(cameraOpticalZoomQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                cameraOpticalZoomBox.Items.Add(o);
            }
            //Display Res*
            drc = runQuery(displayResQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                Object o2 = drr.ItemArray[1];
                StringBuilder sb = new StringBuilder();
                sb.Append("" + o);
                sb.Append(" x ");
                sb.Append("" + o2);
                displayResolutionBox.Items.Add(sb);
            }
            //Display Type
            drc = runQuery(displayTypeQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                displayTypeBox.Items.Add(o);
            }
            //Display Size
            drc = runQuery(displaySizeQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                displaySizeBox.Items.Add(o);
            }
            //Display touchscreen
            drc = runQuery(displayTouchScreenQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                displayTouchscreenBox.Items.Add(o);
            }
            displayTouchscreenBox.Items.Add("False");
            //Phone price low
            drc = runQuery(phoneLowQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phonePriceLowTB.Text = "" + o;
            }
            //Phone price high
            drc = runQuery(phoneHighQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phonePriceHighTB.Text = "" + o;
            }
            //Phone internal capp
            drc = runQuery(phoneInternalQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phoneInternalCapacityBox.Items.Add(o);
            }
            //Phone expandable capp
            drc = runQuery(phoneExpandableQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phoneExpandableCapacityBox.Items.Add(o);
            }
            //Phone RAM capp
            drc = runQuery(phoneRAMQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phoneRAMBox.Items.Add(o);
            }
            //PhoneExternalKeybard
            drc = runQuery(phoneExtKeyQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phoneExternalKeyboardBox.Items.Add(o);
            }
            phoneExternalKeyboardBox.Items.Add("False");
            //phone headphone Jack
            drc = runQuery(phoneHeadphoneJackQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phoneHeadphoneJackBox.Items.Add(o);
            }
            phoneHeadphoneJackBox.Items.Add("False");
            //phone cattery cap
            drc = runQuery(phoneBattCapQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                phoneBattCapBox.Items.Add(o);
            }
            //network type
            drc = runQuery(networkQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                networkTypeBox.Items.Add(o);
            }
            //carrier type
            drc = runQuery(carrierQuery).Tables[0].Rows;
            foreach (DataRow drr in drc)
            {
                Object o = drr.ItemArray[0];
                carrierNameBox.Items.Add(o);
            }

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

        private DataRowCollection getTableRows(string query)
        {
            return runQuery(cpuNumCoresQuery).Tables[0].Rows;
        }

        private string createQuery()
        {
            StringBuilder queryBuilder = new StringBuilder();
            //create the base linked query
            
            queryBuilder.Append("select distinct Phone.phoneID "+
            "from Phone " +
            "LEFT join CPU on CPU.CPUID=Phone.CPUID "+
            "LEFT join OS on OS.OSID = Phone.OSID "+
            "LEFT join Manufacturer on Manufacturer.manufacturerID = Phone.manufacturerID "+
            "LEFT join PhoneCamera on PhoneCamera.phoneID=Phone.phoneID "+
            "LEFT join Camera on PhoneCamera.cameraID=Camera.cameraID "+
            "LEFT join Display on Display.displayID=Phone.displayID "+
            "LEFT join PhoneCarrier on PhoneCarrier.phoneID=Phone.phoneID "+
            "LEFT join Carrier on Carrier.carrierID=PhoneCarrier.carrierID "+
            "LEFT join Network on Network.networkID=Carrier.networkID where ");
            string temp = this.createCPUQuery();
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }

            temp = this.createOSQuery();
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }

            temp = this.createManufacturerQuery(manufacturerBox);
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }

            temp = this.createCameraQuery(cameraMPixBox, cameraOpticalZoomBox);
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }

            temp = this.createDisplayQuery(displayResolutionBox, displayTypeBox, displaySizeBox, displayTouchscreenBox);
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }

            temp = this.createPhoneQuery(phonePriceLowTB,phonePriceHighTB,phoneInternalCapacityBox,phoneExpandableCapacityBox,phoneRAMBox,phoneExternalKeyboardBox,phoneHeadphoneJackBox,phoneBattCapBox);
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }

            temp = this.createCarrierNetworkQuery(carrierNameBox,networkTypeBox);
            if (temp != null)
            {
                queryBuilder.Append(temp);
                //queryBuilder.Append(" intersect ");
            }
            //queryBuilder.Remove(queryBuilder.Length - 7, 7);
            return queryBuilder.ToString();
        }

        private string createCPUQuery()
        {
            if (CPUFreqBox.CheckedItems.Count == 0 && CPUCoreBox.CheckedItems.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            //sb.Append("select distinct Phone.phoneID from Phone inner join CPU on CPU.cpuID=Phone.CPUID where");
            if (CPUFreqBox.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" CPU.frequency like '");
                for (int i = 0; i < CPUFreqBox.CheckedItems.Count; i++)
                {
                    sb.Append(CPUFreqBox.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            if (CPUCoreBox.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" CPU.numCores=");
                for (int i = 0; i < CPUCoreBox.CheckedItems.Count; i++)
                {
                    sb.Append(CPUCoreBox.CheckedItems[i].ToString() + " or ");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            return sb.ToString();
        }
        private string createOSQuery()
        {
            if (OSBox.CheckedItems.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            //sb.Append("select distinct Phone.PhoneID from Phone inner join OS on OS.OSID=Phone.OSID");
            if (OSBox.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" OS.name like '");
                for (int i = 0; i < OSBox.CheckedItems.Count; i++)
                {
                    sb.Append(OSBox.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            return sb.ToString();
        }

        private string createManufacturerQuery(CheckedListBox clb)
        {
            if (clb.CheckedItems.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            //sb.Append("select distinct Phone.phoneID from Phone inner join Manufacturer on Manufacturer.manufacturerID=Phone.manufacturerID");
            if (clb.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Manufacturer.name like '");
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    sb.Append(clb.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            return sb.ToString();
        }

        private string createCameraQuery(CheckedListBox clb, CheckedListBox clb2)
        {
            if (clb.CheckedItems.Count == 0 && clb2.CheckedItems.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            //sb.Append("select distinct PhoneCamera.phoneID from PhoneCamera inner join Camera on Camera.cameraID=PhoneCamera.cameraID");
            if (clb.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Camera.mPixels like '");
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    sb.Append(clb.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            if (clb2.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Camera.opticalZoom like '");
                for (int i = 0; i < clb2.CheckedItems.Count; i++)
                {
                    sb.Append(clb2.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            return sb.ToString();
        }

        private string createDisplayQuery(CheckedListBox clb, CheckedListBox clb2, CheckedListBox clb3, CheckedListBox clb4)
        {
            if (clb.CheckedItems.Count == 0 && clb2.CheckedItems.Count == 0 && clb3.CheckedItems.Count == 0 && clb4.CheckedItems.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            //sb.Append("select distinct Phone.phoneID from Phone inner join Display on Display.displayID=Phone.displayID");
            //res height
            if (clb.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Display.heightPixels like '");
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    string[] temp = clb.CheckedItems[i].ToString().Split(' ');
                    sb.Append(temp[0] + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //res width
            if (clb.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Display.widthPixels like '");
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    string[] temp = clb.CheckedItems[i].ToString().Split(' ');
                    sb.Append(temp[2] + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //type
            if (clb2.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Display.displayType like '");
                for (int i = 0; i < clb2.CheckedItems.Count; i++)
                {
                    sb.Append(clb2.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //size
            if (clb3.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Display.sizeInches like '");
                for (int i = 0; i < clb3.CheckedItems.Count; i++)
                {
                    sb.Append(clb3.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //is touchscreen
            if (clb4.CheckedItems.Count != 0)
            {
                string temp = clb4.CheckedItems[0].ToString();
                bool b = bool.Parse(temp);
                if (b)
                {
                    sb.Append(this.appendAnd());
                    sb.Append(" Display.isTouchscreen=1");
                }
                else
                {
                    sb.Append(this.appendAnd());
                    sb.Append(" Display.isTouchscreen=0");
                }
            }
            return sb.ToString();
        }

        private string createPhoneQuery(TextBox tb, TextBox tb2, CheckedListBox clb, CheckedListBox clb2, CheckedListBox clb3, CheckedListBox clb4, CheckedListBox clb5, CheckedListBox clb6)
        {
            if (tb.Text.Length == 0 && tb2.Text.Length == 0 && clb.CheckedItems.Count == 0 && clb2.CheckedItems.Count == 0 && clb3.CheckedItems.Count == 0 && clb4.CheckedItems.Count == 0 && clb5.CheckedItems.Count == 0 && clb6.CheckedItems.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            //sb.Append("select Phone.phoneID from Phone");
            //low price limit
            if (tb.Text.Length != 0)
            {
                int temp = 0;
                try
                {
                    temp = int.Parse(tb.Text);
                }
                catch (FormatException)
                {
                    temp = 0;
                }
                sb.Append(this.appendAnd());
                sb.Append(" Phone.price >= " + temp);
            }
            else
            {
                sb.Append(this.appendAnd());
                sb.Append(" Phone.price > 0");
            }
            //high price limit
            if (tb2.Text.Length != 0)
            {
                int temp = 0;
                try
                {
                    temp = int.Parse(tb2.Text);
                }
                catch (FormatException)
                {
                    temp = int.MaxValue;
                }
                sb.Append(this.appendAnd());
                sb.Append(" Phone.price <= " + temp);
            }
            else
            {
                sb.Append(this.appendAnd());
                sb.Append(" Phone.price < " + int.MaxValue);
            }
            //internal capactiy
            if (clb.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Phone.internalCapacity like '");
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    sb.Append(clb.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //expandable capactiy
            if (clb2.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Phone.expandableCapacity like '");
                for (int i = 0; i < clb2.CheckedItems.Count; i++)
                {
                    sb.Append(clb2.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //RAM capactiy
            if (clb3.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Phone.RAMCapacity like '");
                for (int i = 0; i < clb3.CheckedItems.Count; i++)
                {
                    sb.Append(clb3.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            //external keybard
            if (clb4.CheckedItems.Count != 0)
            {
                string temp = clb4.CheckedItems[0].ToString();
                bool b = bool.Parse(temp);
                if (b)
                {
                    sb.Append(this.appendAnd());
                    sb.Append(" Phone.hasExternalKeyboard=1");
                }
                else
                {
                    sb.Append(this.appendAnd());
                    sb.Append(" Phone.hasExternalKeyboard=0");
                }
            }
            //headphone Jack
            if (clb5.CheckedItems.Count != 0)
            {
                string temp = clb5.CheckedItems[0].ToString();
                bool b = bool.Parse(temp);
                if (b)
                {
                    sb.Append(this.appendAnd());
                    sb.Append(" Phone.analogAudioJack=1");
                }
                else
                {
                    sb.Append(this.appendAnd());
                    sb.Append(" Phone.analogAudioJack=0");
                }
            }
            //Battery capactiy
            if (clb6.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Phone.batteryCapacity like '");
                for (int i = 0; i < clb6.CheckedItems.Count; i++)
                {
                    sb.Append(clb6.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            return sb.ToString();
        }

        private string createCarrierNetworkQuery(CheckedListBox carrier, CheckedListBox network)
        {
            // none selected
            if (carrier.CheckedItems.Count == 0 && network.CheckedItems.Count == 0)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            //sb.Append("select DISTINCT PhoneCarrier.phoneID from PhoneCarrier inner join Carrier on Carrier.carrierID=PhoneCarrier.carrierID inner join Network on Network.networkID=Carrier.networkID where");
            //carrier section
            if (carrier.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" (Carrier.name like '");
                for (int i = 0; i < carrier.CheckedItems.Count; i++)
                {
                    sb.Append(carrier.CheckedItems[i].ToString() + "' or Carrier.name like '");
                }
                sb.Remove(sb.Length - 22, 22);
                sb.Append(")");
            }
            //network section
            if (network.CheckedItems.Count != 0)
            {
                sb.Append(this.appendAnd());
                sb.Append(" Network.type like '");
                for (int i = 0; i < network.CheckedItems.Count; i++)
                {
                    sb.Append(network.CheckedItems[i].ToString() + "' or '");
                }
                sb.Remove(sb.Length - 4, 4);
            }
            return sb.ToString();
        }

        private void displayTouchscreenBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < displayTouchscreenBox.Items.Count; ++ix)
                    if (e.Index != ix) displayTouchscreenBox.SetItemChecked(ix, false);
        }

        private void phoneExternalKeyboardBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < phoneExternalKeyboardBox.Items.Count; ++ix)
                    if (e.Index != ix) phoneExternalKeyboardBox.SetItemChecked(ix, false);
        }

        private void phoneHeadphoneJackBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < phoneHeadphoneJackBox.Items.Count; ++ix)
                    if (e.Index != ix) phoneHeadphoneJackBox.SetItemChecked(ix, false);
        }

        private string appendAnd()
        {
            if (!isFirstQuery)
            {
                isFirstQuery = true;
                return "";
            }
            else
            {
                return " and ";
            }
        }

    }
}
