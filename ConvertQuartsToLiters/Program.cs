using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertQuartsToLiters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of quarts and we'll calculate ut into liters.");
            double quarts = double.Parse(Console.ReadLine());
            double liters = PaintCalculation(quarts);
            Console.WriteLine(liters + "liters.");
            
        }
        private static double PaintCalculation(double quarts)
        {
            double liter = .966353;
            double liters = quarts * liter;
            return liters;
        }
     }
}
