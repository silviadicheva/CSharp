using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Building[] buildings = new Building[] {};

            foreach (Building building in buildings)
            
                Console.WriteLine("Building area: {0}, building color: {1}, building height: {2}",
                                             building.Area, building.Color, building.Height);
            }

        }
    }

    


