using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemoClient
{
    class SalesTransactionClient
    {
        static void Main(string[] args)
        {
            SalesTransaction trans1 = new SalesTransaction("Jordan", 20.34, .10);
            SalesTransaction trans2 = new SalesTransaction("andy", 30, .02);
            SalesTransaction trans3 = new SalesTransaction("alex");

            
            Console.WriteLine("Transaction 1");
            Console.WriteLine("Sales Person :" + trans1.SalesPerson );
            Console.WriteLine("Sale Amount :" + trans1.SaleAmount);
            Console.WriteLine("Commission Rate :" + trans1.CommissionRate);
            Console.WriteLine("Commission :" + trans1.Commission);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Transaction 2");
            Console.WriteLine("Sales Person :" + trans2.SalesPerson);
            Console.WriteLine("Sale Amount :" + trans2.SaleAmount);
            Console.WriteLine("Commission Rate :" + trans2.CommissionRate);
            Console.WriteLine("Commission :" + trans2.Commission);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Transaction 3");
            Console.WriteLine("Sales Person :" + trans3.SalesPerson);
            Console.WriteLine("Sale Amount :" + trans3.SaleAmount);
            Console.WriteLine("Commission Rate :" + trans3.CommissionRate);
            Console.WriteLine("Commission :" + trans3.Commission);
            Console.WriteLine("-----------------------------------------------------------------");

        }
    }
}
