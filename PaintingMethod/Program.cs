using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of your room in inches?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your room in inches?");
            double width = double.Parse(Console.ReadLine());
            double cost = PaintCalculation(length, width);
            Console.WriteLine(cost.ToString("C"));
        }
        private static double PaintCalculation(double length, double width)
        {
            double squareFootage = (length * 9 *2) + (width * 9 * 2);
            double cost = squareFootage * 6;
            return cost;
        }
    }
}
