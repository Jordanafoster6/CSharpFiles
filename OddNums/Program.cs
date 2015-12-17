using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                   // even number
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
