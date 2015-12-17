using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilometersInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KILOPERMILE = 1.6;
            Console.WriteLine("Enter in the number of miles you would like to be calculated.");
            double Miles = double.Parse(Console.ReadLine());
            Console.WriteLine(Miles + " miles is equal to " + KILOPERMILE * Miles + " kilometers.");
        }
    }
}
