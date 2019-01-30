using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Kitchen : Room
    {
        public Kitchen(double area, string color)
            : base(area, color)
        {
            area = 12;
            color = "green";
            return;
        
        }
    }
}
