using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public class Ball : Color
    {
        public Ball(int red, int green, int blue, int alpha = 255) : base(red, green, blue, alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Ball(int s)
        {
            Size = s;
        }

        int count = 0;
        public void Pop()
        {
            Size = 0;
        }
        public void Throw()
        {
            count++;
        }
        public int CThrow()
        {
            return count;
        }

        public int Size { get; set; }
    }
}
