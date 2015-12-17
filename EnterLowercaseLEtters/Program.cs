using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLEtters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'i';
            string letterString = "";

            while(letter != '!')
            {
                WriteLine("Please enter in a lowercase letter");
                letterString = Console.ReadLine();
                if (letterString != "")
                {
                    letter = Convert.ToChar(letterString.Substring(0, 1));

                    if (letter >= 97 && letter <= 122)
                    {
                        WriteLine("OK");
                    }
                    else if (letter >= 65 && letter <= 90)
                    {
                        WriteLine("Error, capital letter.");
                    }
                }
                else
                {
                    WriteLine("Program cannot evaluate nothing.");
                }
            }
        }
    }
}
