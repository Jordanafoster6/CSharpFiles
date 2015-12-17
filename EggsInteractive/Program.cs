using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in the number of eggs you would like to be calculated for chicken number one.  ");
            int chickOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the number of eggs you would like to be calculated for chicken number two.");
            int chickTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the number of eggs you would like to be calculated for chicken number three.");
            int chickThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the number of eggs you would like to be calculated for chicken number four.");
            int chickFour = int.Parse(Console.ReadLine());
            int total = chickOne + chickTwo + chickThree + chickFour;
            int doz = total / 12;
            int less = total % 12;
            Console.WriteLine("You have a total of " + doz + " dozen and " + less + " eggs.");
        }
    }
}