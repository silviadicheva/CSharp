using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace House
{
    class House 
    {
        private double area;
        public double Area
        {
            get { return area; }
        }

        public double Height { get; set; }
        public string Color { get; set; }

        protected void Building(double height, string color)

        {
            Height = height;
            Color = color;
        }

        public void Building(double area, double height, string color)
        {
            this.area = area;
            Height = height;
            Color = color;
        }
    }

    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    class Room
    {
        public double Area { get; set; }
        public string Color { get; set; }

        public Room(double area, string color)
        {
            Area = area;
            Color = color;
        }
    }

    class Bathroom
    {
        public Bathroom(double area, string color)
            : base(area, color)
        {
        }
    }

    class Bedroom
    {
        public Bedroom(double area, string color)
           : base(area, color)
        {
        }
    }

    class Kitchen
    {
        public Kitchen(double area, string color)
            : base(area, color)
        {
        }
    }
}
