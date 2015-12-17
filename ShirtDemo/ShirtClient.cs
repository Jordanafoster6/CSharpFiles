using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtDemo
{
    class ShirtClient
    {
        static void Main(string[] args)
        {
            Shirt[] array1 = new Shirt[5];
            array1[0] = new Shirt("Cotton", "black", "Large");
            array1[1] = new Shirt("Nylon", "White", "Small" );
            array1[2] = new Shirt("Cotton", "yellow", "medium");
            array1[3] = new Shirt("Nylon", "green", "Large" );
            array1[4] = new Shirt("Cotton", "black", "Medium" );

            DisplayStrings(array1);
        }

        // params array method
        public static void DisplayStrings(params Shirt[] array)
        {
            foreach (Shirt x in array)
            {
                Console.WriteLine("Material is:" + x.material);
                Console.WriteLine("Size is:" + x.size);
                Console.WriteLine("Color is:" + x.color);
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
