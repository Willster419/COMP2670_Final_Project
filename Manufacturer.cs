using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    public class Manufacturer
    {
        /// <summary>
        /// The Unique ID of the manufacturer
        /// </summary>
        public int manufacturerID { get; set; }
        /// <summary>
        /// The name of the manufacturer
        /// </summary>
        public string name { get; set; }
        public override string ToString()
        {
            return manufacturerID + " - " + name;
        }
    }
}
