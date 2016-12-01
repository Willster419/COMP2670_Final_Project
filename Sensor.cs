using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    public class Sensor
    {
        /// <summary>
        /// The Unique ID of the sensor
        /// </summary>
        public int sensorID { get; set; }
        /// <summary>
        /// The name of the sensor
        /// </summary>
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
