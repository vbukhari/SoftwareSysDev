using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class aRandomNumberGenerator
    {
        public int setLow { get; set; }
        public int setHigh { get; set; }
        public int setSeed { get; set; }
        public aRandomNumberGenerator(int low, int high)
        {
            setRange(low, high);
            Random num = new Random();
            num.Next(setLow, setHigh);
        }
        public aRandomNumberGenerator(int low, int high, int seed)
        {
            setRange(low, high);
            Random num = new Random(seed);
            num.Next(setLow, setHigh);
        }

        public void setRange(int l, int h)
        {
            setLow = l;
            setHigh = h;
        }

    }
}
