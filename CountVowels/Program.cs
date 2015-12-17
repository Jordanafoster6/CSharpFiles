using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        private static int CountVowel(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                switch (str[i])
                {
                    case 'A':
                        count++;
                        break;
                    case 'a':
                        count++;
                        break;
                    case 'E':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'I':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'O':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'U':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;

                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int total = 0;
            string Str;
            Console.WriteLine("Please enter a phase so we can count the vowels.");
            Str = Console.ReadLine();
            total = CountVowel(Str);

            Console.WriteLine("The total number of vowels in the string you entered is: {0}", total);


        }
    }
}
