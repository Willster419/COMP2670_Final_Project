using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    class Display
    {
        /// <summary>
        /// The unique ID of the display
        /// </summary>
        public int displayID { get; set; }
        /// <summary>
        /// The type of technology used ot make the display, e.g. AMOLED
        /// </summary>
        public string displayType { get; set; }
        /// <summary>
        /// Indicated if the display is a touchscreen
        /// </summary>
        public bool isTouchScreen { get; set; }
        /// <summary>
        /// The size, in inches, of the display, from lower-left to upper-right
        /// </summary>
        public float sizeInches { get; set; }
        /// <summary>
        /// The height, in pixels, of the display
        /// </summary>
        public int heightPixels { get; set; }
        /// <summary>
        /// The width, in pixels, of the display
        /// </summary>
        public int widthPixels { get; set; }
        /// <summary>
        /// The Dots Per Inch (DPI) of the display
        /// </summary>
        public int dpi { get; set; }
        public override string ToString()
        {
            return displayID + " - " +
                displayType + " - " +
                dpi + " - " +
                heightPixels + " - " +
                isTouchScreen + " - " +
                sizeInches + " - " +
                widthPixels;
        }
    }
}
