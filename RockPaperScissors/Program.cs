using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Please enter in rock, paper, or scissors.");
            input = Console.ReadLine();

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(0, 3);
            Console.WriteLine(randomNumber);

            if (input == "r" && randomNumber == 0)
            {
                
            }

        }
    }
}
