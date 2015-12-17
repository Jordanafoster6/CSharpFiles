using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 35;
            int hours = (time / 60);
            double minutes = (time % 60);
            Console.WriteLine(" The number of hours you worked is " + hours + " and the number of minutes you worked is " + minutes + ".");


        }
    }
}
