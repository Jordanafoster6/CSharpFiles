using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your admission test score.");
            double test = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your grade point average.");
            double gpa = double.Parse(Console.ReadLine());
            if ((gpa >= 3.0 && test >= 60) || (gpa <= 3.0 && test >= 80))
            {
                Console.WriteLine("Accepted.");
            }
            else
	        {
                Console.WriteLine("Rejected.");
            }

        }
    }
}
