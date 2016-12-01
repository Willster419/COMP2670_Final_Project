using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    public class Phone
    {
        //define all parameters we will need
        public Phone()
        {
            carrierList = new List<Carrier>();
            cameraList = new List<Camera>();
            sensorList = new List<Sensor>();
            featureList = new List<Feature>();
        }
        /// <summary>
        /// The Unique ID number of the phone
        /// </summary>
        public int phoneID { get; set; }
        /// <summary>
        /// The name (including product line) of the phone
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The Display ID number where all display information for this phone is kept. Corresponds to the index (+1 over) of the displayList
        /// </summary>
        public int displayID { get; set; }
        /// <summary>
        /// The ID of the charge port type of the phone. Further information is linked by using this ID -1 as index for chargePortList
        /// </summary>
        public int chargePortID { get; set; }
        /// <summary>
        /// The ID of the Operating System (OS) of the phone. Further information is linked by using the ID -1 as the index for OSList
        /// </summary>
        public int OSID { get; set; }
        /// <summary>
        /// The ID of the CPU used in the phone. Further information is linked by using the ID -1 as the index for CPUList
        /// </summary>
        public int CPUID { get; set; }
        /// <summary>
        /// Determines if the phone is locked into a specific carrier
        /// </summary>
        public bool isUnlocked { get; set; }
        /// <summary>
        /// The purchase price of the phone new
        /// </summary>
        public float price { get; set; }
        /// <summary>
        /// The Internal raw (unformated) Storage Capacity of the phone meaured in MB
        /// </summary>
        public int internalCapacity { get; set; }
        /// <summary>
        /// The External raw (informated) Storage Capacity of the phone measured in MB. A 0 indicates the phone does not have expandable storage.
        /// </summary>
        public int expandableCapacity { get; set; }
        /// <summary>
        /// The Amount of RAM the phone has measured in MB
        /// </summary>
        public int RAMcapacity { get; set; }
        /// <summary>
        /// The month, in int form, when the phone was released. EX: 1=Jan,2=Feb...
        /// </summary>
        public int monthReleased { get; set; }
        /// <summary>
        /// The year the phone was released. EX: 2016
        /// </summary>
        public int yearReleased { get; set; }
        /// <summary>
        /// Indicates wether the phone is still available to be purchased new
        /// </summary>
        public bool stillAvailable { get; set; }
        /// <summary>
        /// The weight of the phone, measured in grams
        /// </summary>
        public float weight { get; set; }
        /// <summary>
        /// Wether of not the phone comes with a build in external keyboard
        /// </summary>
        public bool hasExternalKeyboard { get; set; }
        /// <summary>
        /// The number of exernal speakers (loudspeakers) the phone has built-in
        /// </summary>
        public int numExternalSpeakers { get; set; }
        /// <summary>
        /// Indicates if the phone has an analog audio jack
        /// </summary>
        public bool analogAudioJack { get; set; }
        /// <summary>
        /// Indicates if the phone has a physical home button
        /// </summary>
        public bool physicalHomeButton { get; set; }
        /// <summary>
        /// The ID of the manufacturer of the phone. The name can be linked using this value as the index -1 for MmnufactureList
        /// </summary>
        public int manufacturerID { get; set; }
        /// <summary>
        /// The capacity of the phone's battery, measured in milli-amp hours (MaH)
        /// </summary>
        public int batteryCapacity { get; set; }
        /// <summary>
        /// The URL to a direct link of the phone's picture
        /// </summary>
        public string pictureURL { get; set; }
        /// <summary>
        /// The number of SIM cards the phone can take
        /// </summary>
        public int numSimCards { get; set; }
        /// <summary>
        /// The type of SIM card the phone takes
        /// </summary>
        public string simCardType { get; set; }

        public string isGSMCDMA { get; set; }

        public string manufactureName { get; set; }

        public string OSName { get; set; }

        public string chargePortname { get; set; }

        public float CPUFreq { get; set; }

        public string CPUName { get; set; }

        public string CPUModel { get; set; }

        public int CPUNumCores { get; set; }

        public string displayType { get; set; }

        public bool displayIsTouchScreen { get; set; }

        public float displaySizeInches { get; set; }

        public int displayHeightPixels { get; set; }

        public int displayWidthPixels { get; set; }

        public int displayDpi { get; set; }

        public List<Camera> cameraList;

        public List<Carrier> carrierList;

        public List<Sensor> sensorList;

        public List<Feature> featureList;
    }
}
