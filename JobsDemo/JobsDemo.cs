using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDemo
{
    class JobsDemo
    {
        static void Main(string[] args)
        {
            Jobs newJob1 = new Jobs(2, 100, "car wash");
            Console.WriteLine(newJob1.Description);
            Console.WriteLine(newJob1.TimeInHours);
            Console.WriteLine(newJob1.HourRate);
            
            Jobs newJob2 = new Jobs(4, 200, "carpet cleaning");
            Console.WriteLine(newJob2.Description);
            Console.WriteLine(newJob2.TimeInHours);
            Console.WriteLine(newJob2.HourRate);

            Jobs newJob3 = new Jobs();
            newJob3 = newJob1 + newJob2;
            Console.WriteLine(newJob3.Description);
            Console.WriteLine(newJob3.TimeInHours);
            Console.WriteLine(newJob3.HourRate);
            Console.WriteLine(newJob3.);
        }
    }
}
