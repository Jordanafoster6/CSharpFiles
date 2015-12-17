using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            char Danielle = 'D';
            char Edward = 'E';
            char Francis = 'F';
            double totalD = 0;
            double totalE = 0;
            double totalF = 0;
            char initial = 'X';
            string letterString = "";

            Console.WriteLine("Please follow the steps below to enter in the sales information.");
            Console.WriteLine("When you are done entering the necessary information use initial 'Z' to display the sum total of each sales associate.");
            while (initial != 'Z' && initial != 'z')
            {
                Console.WriteLine("Please enter the initial of the salesperson who helped you.");
                letterString = Console.ReadLine();
                if (letterString != "")
                {
                    initial = Convert.ToChar(letterString.ToUpper().Substring(0, 1));

                    if (initial == 'D')
                    {
                        Console.WriteLine("Danielle was your salesperson.");
                        Console.Write("How much did you sell? ");
                        double priceD = double.Parse(Console.ReadLine());
                        totalD += priceD;                       
                    }
                    else if (initial == 'E')
                    {
                        Console.WriteLine("Edward was your salesperson.");
                        Console.Write("How much did you sell? ");
                        double priceE = double.Parse(Console.ReadLine());
                        totalE += priceE;
                        
                    }
                    else if (initial == 'F')
                    {
                        Console.WriteLine("Francis was your salesperson.");
                        Console.Write("How much did you sell? ");
                        double priceF = double.Parse(Console.ReadLine());
                        totalF += priceF;
                    }
                    else if(initial != 'Z')
                    {
                        Console.WriteLine("Error, You did not enter a valid initial.");
                    }
                }
            }
            Console.WriteLine("Danielle had " + totalD.ToString("c") + " dollars in sales.");
            Console.WriteLine("Edward had " + totalE.ToString("c") + " dollars in sales.");
            Console.WriteLine("Francis had " + totalF.ToString("c") + " dollars in sales.");
        }
    }
}
