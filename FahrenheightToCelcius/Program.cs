using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheightToCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Fahrenheight and this program will convert it to Celcius");
            double Fahr = double.Parse(Console.ReadLine());
            double Celc = (Fahr - 32) * (5.0/ 9);
            Console.WriteLine("The temperature you entered is " + Fahr + " degrees in Fahrenheight and it is " + Celc.ToString("f2") + " degrees in Celcius.");
        }
    }
}
