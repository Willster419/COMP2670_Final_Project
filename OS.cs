using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    class OS
    {
        /// <summary>
        /// The Unique ID of the Operating System
        /// </summary>
        public int OSID { get; set; }
        /// <summary>
        /// The Unique name of the Operating System
        /// </summary>
        public string name { get; set; }
        public override string ToString()
        {
            return OSID + " - " + name;
        }
    }
}
