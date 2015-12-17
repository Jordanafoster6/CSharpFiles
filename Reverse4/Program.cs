using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 1;
            int secondInt = 2;
            int thirdInt = 3;
            int fourthInt = 4;
            Console.WriteLine(firstInt);
            Console.WriteLine(secondInt);
            Console.WriteLine(thirdInt);
            Console.WriteLine(fourthInt);
            Console.WriteLine("vvvvvvvv Reversed Position vvvvvvvv");
            Reverse(ref firstInt, ref secondInt, ref thirdInt, ref fourthInt);
            Console.WriteLine(firstInt);
            Console.WriteLine(secondInt);
            Console.WriteLine(thirdInt);
            Console.WriteLine(fourthInt);
        }
        private static void Reverse(ref int firstInt, ref int secondInt, ref int thirdInt, ref int fourthInt)
        {
            int holder = firstInt;
            firstInt = fourthInt;
            fourthInt = holder;
            int holder2 = secondInt;
            secondInt = thirdInt;
            thirdInt = holder2;
        }
    }
}
