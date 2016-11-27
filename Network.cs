using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    class Network
    {
        /// <summary>
        /// The ID of the network
        /// </summary>
        public int networkID { get; set; }
        /// <summary>
        /// The Type of the network that it is, eithor CDMA or GSM
        /// </summary>
        public string type { get; set; }
        public override string ToString()
        {
            return "" + networkID + " - " + type;
        }
    }
}
