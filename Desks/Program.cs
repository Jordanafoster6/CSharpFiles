using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static double DeskInput()
        {
            Console.WriteLine("Please enter the number of drawers you would like on your desk.");
            double drawerNum = double.Parse(Console.ReadLine());
            return drawerNum;
        }
        private static string woodType()
        {
            Console.WriteLine("Please enter the type of wood you would like.");
            string wood = Console.ReadLine();
        }
        private static string deskCalc()
        {

        }
    }
}
