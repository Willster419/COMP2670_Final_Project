using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    class CPU
    {
        /// <summary>
        /// The Unique ID of the CPU
        /// </summary>
        public int CPUID { get; set; }
        /// <summary>
        /// The Manufactorer name
        /// </summary>
        public string brand { get; set; }
        /// <summary>
        /// The manufactor's specified model number
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// The number of cores of the processor
        /// </summary>
        public int numCores { get; set; }
        /// <summary>
        /// The frequency of the highest clocked core in the phone.
        /// </summary>
        public float frequency { get; set; }
        public override string ToString()
        {
            return CPUID + " - " +
                brand + " - " +
                model + " - " +
                numCores + " - " +
                frequency + " - ";
        }
    }
}
