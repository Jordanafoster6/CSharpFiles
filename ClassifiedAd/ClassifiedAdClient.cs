using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAd
{
    class ClassifiedAdClient
    {
        static void Main(string[] args)
        {
            ClassifiedAd myAd = new ClassifiedAd();
            myAd.Category = "used cars";
            myAd.WordNum = 10;
            Console.WriteLine("The category you chose was {0}. Your ad contains {1} words with a total cost of ${2}",
                myAd.Category,myAd.WordNum,myAd.Price.ToString("n2"));
        }
      
            
    }
}
