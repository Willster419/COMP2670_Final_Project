using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    public class ChargePort
    {
        /// <summary>
        /// The Unique ID of the charge port
        /// </summary>
        public int chargePortID { get; set; }
        /// <summary>
        /// The Unique name of the charge port
        /// </summary>
        public string name { get; set; }
        public override string ToString()
        {
            return chargePortID + " - " + name;
        }
    }
}
