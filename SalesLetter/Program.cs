using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayContactInfo();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hello, Thank you for choosing Elite Auto care for your car care needs.");
            Console.WriteLine("We have a variety of different services to offer from paint correction");
            Console.WriteLine("to leather treatment and engine cleaning.");
            Console.WriteLine("The options are endless with Elite Auto so contact us! We would love");
            Console.WriteLine("to give you a quote!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("You can contact me through my contact information below.");
            DisplayContactInfo();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Or you can contact my business partner and associate through his contact");
            Console.WriteLine(" information.");
            DisplayBensContactInfo();
        }
        private static void DisplayContactInfo()
        {
            Console.WriteLine("Jordan Foster, CEO");
            Console.WriteLine("********Contact Information********");
            Console.WriteLine("Home Phone: 1 618 555 5555");
            Console.WriteLine("Cell Phone: 1 618 420 3646");
            Console.WriteLine("Email: Jordanafoster6@gmail.com");
        }
        private static void DisplayBensContactInfo()
        {
            Console.WriteLine("Ben Schneider, CEO");
            Console.WriteLine("********Contact Information********");
            Console.WriteLine("Home Phone: 1 618 555 5555");
            Console.WriteLine("Cell Phone: 1 618 610 8248");
            Console.WriteLine("Email: BenjaminSchneider6@gmail.com");
        }
    }
}
