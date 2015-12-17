using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random ranNumberGenerator = new Random();
            int randomNumber;
            int randomNumber2;
            randomNumber = ranNumberGenerator.Next(0, 6);
            randomNumber2 = ranNumberGenerator.Next(0, 6);

            while (randomNumber == randomNumber2)
            {
                randomNumber2 = ranNumberGenerator.Next(0, 6);
            }
            DisplayFortunes(randomNumber, randomNumber2);
        }
        private static void DisplayFortunes(int x, int y)
        {
            string[] fortunes = new string[6];
            fortunes[0] = "Tomorrow something good will happen to you.";
            fortunes[1] = "Learn from your past so you don't repeat it.";
            fortunes[2] = "Smile, you dont own all the problems in the world.";
            fortunes[3] = "Learn to accept a change that is coming to you.";
            fortunes[4] = "Keep working toward your goal you're almost there.";
            fortunes[5] = "Patience is a virtue. Good things are coming.";

            Console.WriteLine(fortunes[x]);
            Console.WriteLine(fortunes[y]);
        }
    }
}
