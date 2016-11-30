using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    public class Feature
    {
        /// <summary>
        /// The Unique ID of the feature
        /// </summary>
        public int featureID { get; set; }
        /// <summary>
        /// The name of the feature
        /// </summary>
        public string name { get; set; }
        public override string ToString()
        {
            return featureID + " - " + name;
        }
    }
}
