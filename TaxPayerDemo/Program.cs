using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer[] array1 = new TaxPayer[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new TaxPayer();
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

        }
    }
}
