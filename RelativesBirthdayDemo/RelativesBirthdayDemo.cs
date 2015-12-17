using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativesBirthdayDemo
{
    class RelativesBirthdayDemo
    {
        static void Main(string[] args)
        {
            RelativesBirthday[] array1 = new RelativesBirthday[12];
            for (int i = 0; i < array1.Length; i++)
            {
                string name;
                string relationship;
                int month;
                int day;
                int year;
                Console.WriteLine("Please enter in your name.");
                name = Console.ReadLine();
                Console.WriteLine("Please enter in your relationship (Aunt, Father, Etc..).");
                relationship = Console.ReadLine();
                Console.WriteLine("Please enter in your birth month (mm).");
                month = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter in your birth day (dd).");
                day = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter in your birth year (yyyy).");
                year = int.Parse(Console.ReadLine());
                array1[i] = new RelativesBirthday(name, relationship, month, day, year);
            }

            Array.Sort(array1);

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Name: " + array1[i].name);
                Console.WriteLine("Relationship: " + array1[i].relationship);
                Console.WriteLine("Birthdate:{0}/{1}/{2} " + array1[i].month, array1[i].day, array1[i].year);
                Console.WriteLine("------------------------");
                Console.WriteLine();

            }

            Console.WriteLine("Enter a relatives name to see their relationship and birthday.");
            string relativeName = Console.ReadLine();
        }
        public static void NameFind(string n, RelativesBirthday[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (n == array[i].name)
                {
                    Console.WriteLine("Their relationship isn {0} and their birtjhday is {1}/{2}/{3}", array[i].relationship, array[i].month, array[i].day, array[i].year);
                }
                else
                {
                    Console.WriteLine("Error, Relative not found");
                }
            }
        }
    }
}
