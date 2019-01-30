using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("h= ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("w= ");
            double w = double.Parse(Console.ReadLine());

            w *= 100;                  
            h *= 100;

            double LengthJobs = Math.Floor((w - 100) / 70);
            double WidthJobs = Math.Floor(h / 120);
            double Seats = (LengthJobs * WidthJobs) - 3;

            Console.WriteLine(Seats);

        }
    }
}
