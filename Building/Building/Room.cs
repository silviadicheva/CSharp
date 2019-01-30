using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Room
    {
        public double Area { get; set; }
        public string Color { get; set; }

        public Room(double area, string color)
        {
            this.Area = area;
            this.Color = color;
            
        }

        public int Length { get; set; }
    }
}
