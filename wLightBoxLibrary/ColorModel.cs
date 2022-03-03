using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wLightBoxLibrary
{
    public class Color
    {
        public int RedValue { get; set; }
        public int GreenValue { get; set; }
        public int BlueValue { get; set; }
        public int WarmWhiteValue { get; set; }
        public int ColdWhiteValue { get; set; }

        public Color(int redValue, int greenValue, int blueValue, int warmWhiteValue, int coldWhiteValue)
        {
            RedValue = redValue;
            GreenValue = greenValue;
            BlueValue = blueValue;
            WarmWhiteValue = warmWhiteValue;
            ColdWhiteValue = coldWhiteValue;
        }

        // this method convert int (0 - 255) to hex (00 - FF) and returns its value
        public string GetHexColor(int RedValue, int GreenValue, int BlueValue, int WarmWhiteValue, int ColdWhiteValue)
        {
            return $"{ RedValue.ToString("X2") }{ GreenValue.ToString("X2") }{ BlueValue.ToString("X2") }{ WarmWhiteValue.ToString("X2") }{ ColdWhiteValue.ToString("X2") }";
        }
    }
}
