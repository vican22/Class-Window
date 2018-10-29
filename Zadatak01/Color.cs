using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    class Color
    {
        private int r;
        private int g;
        private int b;

        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public int R
        {
            get => r;
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new Exception("No can do this, value must be between 0-255");
                }
                r = value;
            }
        }

        public int G
        {
            get => g;
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new Exception("No can do this, value must be between 0-255");
                }
                g = value;
            }

        }

        public int B
        {
            get => b;
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new Exception("No can do this, value must be between 0-255");
                }
                b = value;
            }
        }

        public override string ToString() => $"({R}, {G}, {B})";
        
    }
}
