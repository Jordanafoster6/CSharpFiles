using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 1;
            int middleInt = 2;
            int lastInt = 3;
            Console.WriteLine(firstInt);
            Console.WriteLine(middleInt);
            Console.WriteLine(lastInt);
            Console.WriteLine("vvvvvvvv Reversed Position vvvvvvvv");
            Reverse(ref firstInt, ref middleInt, ref lastInt);
            Console.WriteLine(firstInt);
            Console.WriteLine(middleInt);
            Console.WriteLine(lastInt);
        }
        private static void Reverse(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            int holder = firstInt;
            firstInt = lastInt;
            lastInt = holder;
        }
    }
}
