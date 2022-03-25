using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public class Color
    { 
        public Color()
        {

        }
        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = red;
            Green = green;  
            Blue = blue;
            Alpha = alpha;
        }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public int GrayScale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
