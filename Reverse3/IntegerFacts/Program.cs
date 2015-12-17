using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            int high, low, sum, avg;
          //  outIntegers(out high, out low, out sum, avg);
            int[] nums = new int[20];
            fillMethod(nums);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            
            

        }

        private static void fillMethod(int[] nums)
        {
            int x = 0;

            Console.WriteLine("What is the first number?");

            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 999)
            {
                nums[x] = num;
                x++;
                Console.WriteLine("What is the next number?");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void outIntegers(out int high, out int low, out int sum, out int avg)
        {

        }
        
    }
}
