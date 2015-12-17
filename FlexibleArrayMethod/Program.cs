using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4 };
            int[] num2 = { 11, 20, 31, 6, 8, 12 };
            int[] num3 = { 9, 14, 52, 5, 12, 19, 7};
            ArraySum(num1);
            ArraySum(num2);
            ArraySum(num3);
        }
        private static void ArraySum(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
                Console.WriteLine("Array position" + i + " is " + array[i]);
            }
            Console.WriteLine("The sum of the array is " + total);
        }
    }
}
