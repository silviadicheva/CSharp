using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Bedroom : Room
    {
        public Bedroom(double area, string color)
            : base(area, color)
        {
            area = 20;
            color = "green";
            return;
        }
    }
}
