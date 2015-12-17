using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] Array1 = new Room[10];

            Array1[0] = new Room(122, 1);
            Array1[1] = new Room(43, 91);
            Array1[2] = new Room(2, 16);
            Array1[3] = new Room(46, 54);
            Array1[4] = new Room(56, 5);
            Array1[5] = new Room(72, 31);
            Array1[6] = new Room(637, 74);
            Array1[7] = new Room(122, 57);
            Array1[8] = new Room(87, 19);
            Array1[9] = new Room(183, 61);


            for (int i = 0; i < Array1.Length; i++)
            {
            Console.WriteLine("Room " + (i + 1));
            Console.WriteLine("Width: " + Array1[i].Width);
            Console.WriteLine("Length: " + Array1[i].Length);
            Console.WriteLine("Square Feet: " + Array1[i].FloorArea);
            Console.WriteLine("Box Number: " + Array1[i].BoxNum);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("                                           ");
            }
        }

    }
}
