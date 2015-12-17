using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class PhotoDemo
    {
        static void Main(string[] args)
        {
            Photo p1 = new Photo(12, 10);
            MattedPhoto p2 = new MattedPhoto("blue");
            FramedPhoto p3 = new FramedPhoto("Gold", "Modern");
            p2.Height = 18;
            p2.Width = 16;
            p3.Height = 9;
            p3.Width = 6;
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());

        }
    }
}
