using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer2[] array1 = new TaxPayer2[2];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new TaxPayer2();
                Console.WriteLine("Please enter in your gross income.");
                array1[i].GrossIncome = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter in your Social Security Number (SSN)");
                array1[i].SocialSecurityNumber = Console.ReadLine();

                Console.WriteLine(array1[i]);
                Console.WriteLine("Your Social Secruity Number is: " + array1[i].SocialSecurityNumber);
                Console.WriteLine("Your Gross Income is: " + array1[i].GrossIncome.ToString("c"));
                Console.WriteLine("Your taxes owed for this year are: " + array1[i].TaxOwed.ToString("C"));
                Console.WriteLine("----------------------------------------------");
            }

            Array.Sort(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine("Your Social Secruity Number is: " + array1[i].SocialSecurityNumber);
                Console.WriteLine("Your Gross Income is: " + array1[i].GrossIncome.ToString("c"));
                Console.WriteLine("Your taxes owed for this year are: " + array1[i].TaxOwed.ToString("C"));
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
