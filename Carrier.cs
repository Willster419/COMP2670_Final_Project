using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    class Carrier
    {
        /// <summary>
        /// The ID of the carrier
        /// </summary>
        public int carrierID { get; set; }
        /// <summary>
        /// The ID of the network of this carrier. Is the same as the index (+1) of the networkList
        /// </summary>
        public int networkID { get; set; }
        /// <summary>
        /// The name of the Carrier
        /// </summary>
        public string name { get; set; }
        public override string ToString()
        {
            return carrierID + " - " + networkID + " - " + name;
        }
    }
}
