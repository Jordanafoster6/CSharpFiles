using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const double RAISE = 1.04;
            Console.WriteLine("Enter your current salary to see what it will be after your 4 percent raise.");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine(salary + " dollars a year plus your 4 percent raise is " + RAISE * salary + " dollars per year.");
        }
    }
}
