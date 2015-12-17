using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in the score for test one.");
            double testOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the score for test two.");
            double testTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the score for test three.");
            double testThree = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the score for test four.");
            double testFour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the score for test five.");
            double testFive = double.Parse(Console.ReadLine());
            double total = testOne + testTwo + testThree + testFour + testFive;
            double avg = total / 5 / 100;
            Console.WriteLine("Your average test score is " + avg.ToString("p"));
        }
    }
}
