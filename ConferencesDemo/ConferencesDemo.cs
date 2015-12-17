using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencesDemo
{
    class ConferencesDemo
    {
        static void Main(string[] args)
        {
            Conferences[] array1 = new Conferences[5];

            for (int i = 0; i < array1.Length; i++)
            {
                string group;
                string date;
                int num;
                Console.WriteLine("Please enter in your group name.");
                group = Console.ReadLine();
                Console.WriteLine("Please enter in the date.");
                date = Console.ReadLine();
                Console.WriteLine("Please enter in your attendance number.");
                num = int.Parse(Console.ReadLine());
                array1[i] = new Conferences(group, date, num);
            }

            Array.Sort(array1);

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Name: " + array1[i].Name);
                Console.WriteLine("Date: " + array1[i].Date);
                Console.WriteLine("Attendee Number: " + array1[i].AtendeeNum);
                Console.WriteLine("------------------------");
                Console.WriteLine();

            }
        }
    }
}
