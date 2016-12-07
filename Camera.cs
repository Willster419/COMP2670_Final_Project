using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfPhones
{
    public class Camera
    {
        /// <summary>
        /// The Unique ID of this camera
        /// </summary>
        public int cameraID { get; set; }
        /// <summary>
        /// The resolution height of the camera lens, measured in pixels
        /// </summary>
        public int resolutionHeightPixels { get; set; }
        /// <summary>
        /// The resolution width of the camera lens, measured in pixels
        /// </summary>
        public int resolutionWidthPixels { get; set; }
        /// <summary>
        /// The optical zoom amount that the camera can zoom
        /// </summary>
        public float opticalZoom { get; set; }
        /// <summary>
        /// The megaPixel amount of the phone
        /// </summary>
        public float mPixels { get; set; }
        /// <summary>
        /// The maximum Frames Per Second (FPS) of the camera at it's standard resolution (Usaully the highest camera resolution)
        /// </summary>
        public int fps { get; set; }
        /// <summary>
        /// The location, front or back, where the camera is on the phone.
        /// </summary>
        public string location { get; set; }
        public override string ToString()
        {
            return cameraID + " - "
                + resolutionHeightPixels
                + " - " + resolutionWidthPixels
                + " - " + opticalZoom
                + " - " + mPixels
                + " - " + fps
                + " - " + location;
        }
    }
}
