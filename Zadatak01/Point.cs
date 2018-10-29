using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get => x;

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Must be between 0-100");
                }
                x = value;
            }
        }

        public int Y
        {

            get => y;

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Must be between 0-100");
                }
                y = value;
            }
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
