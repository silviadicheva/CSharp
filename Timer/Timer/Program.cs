using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.Write("m=");
            double m = double.Parse(Console.ReadLine());
            m = m + 15;
            if (m >= 60)
                Console.WriteLine();
            {
                m = m - 60;
                h = h + 1;
            }
            if (h >= 24) h = h - 24;
            Console.WriteLine("{0}:{1}", h, m);
        }
    }
}
