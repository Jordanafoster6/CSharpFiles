using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KILOPERMILE = 1.6;
            double Miles = 3;
            Console.WriteLine(Miles + " miles is equal to " + KILOPERMILE * Miles + " kilometers.");

        }
    }
}
