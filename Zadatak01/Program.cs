using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Color c = new Color(255, 15, 246);
            //Point p = new Point(39, 85);

            //Console.WriteLine(c.ToString());
            //Console.WriteLine(p.ToString());

            Window w = new Window();
            w.Title = "Window";
            w.Label = "w";
            w.TopLeft = new Point(1, 1);
            w.BottomRight = new Point(15, 23);

            w.Color = new Color(255, 255, 0);
            w.IsActive = false;

            Console.WriteLine(w.ToString());

            w.Draw();
        }
    }
}
