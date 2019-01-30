using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Bathroom : Room
    {
        public Bathroom(double area, string color)
            : base(area, color)
        {
            area = 6;
            color = "green";
            return;
        }
    }
}
