using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter("jordan", "9/1/15");
            CertifiedLetter letter2 = new CertifiedLetter(73849875);
            letter2.name = "Andy";
            letter2.dateMailed = "8/30/15";
            Console.WriteLine(letter1.ToString());
            Console.WriteLine(letter2.ToString());
        }
    }
}
