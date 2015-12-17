using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            Console.WriteLine(order1.GetHashCode());
        }
    }
}
