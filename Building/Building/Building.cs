using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public  class Building
    {
        private double area;
        public virtual double Area
        {
            get { return area; }
        }


        public double Height { get; set; }
        public string Color { get; set; }

        public Building(double height, string color)
        {
            this.Height = height;
            this.Color = color;
        }

        public Building(double area, double height, string color)
        {
            this.area = area;
            this.Height = height;
            this.Color = color;
        }
    }
}
