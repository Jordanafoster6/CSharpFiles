using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the windspeed of the tropical storm? (# of MPH)");
            double speed = double.Parse(Console.ReadLine());
            if (speed >= 157)
            {
                Console.WriteLine("Category 5 Hurricane.");
            }
            else if ((speed < 157) && (speed >= 130))
            {
                Console.WriteLine("Category 4 Hurricane");
            }
            else if ((speed < 130) && (speed >= 111))
            {
                Console.WriteLine("Category 3 Hurricane");
            }
            else if ((speed < 111) && (speed >= 96))
            {
                Console.WriteLine("Category 2 Hurricane");
            }
            else if ((speed < 96) && (speed >= 74))
            {
                Console.WriteLine("Category 1 Hurricane");
            }
            else
            {
                Console.WriteLine("This storm is not a Hurricane.");
            }
        }
    }
}
