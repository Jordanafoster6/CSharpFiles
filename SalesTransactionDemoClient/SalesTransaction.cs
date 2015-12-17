using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemoClient
{
    class SalesTransaction
    {
        private string salesPerson;
        private double saleAmount;
        private double commission;
        private double commissionRate;

        public SalesTransaction(string name, double amount, double rate)
        {
            this.salesPerson = name;
            this.saleAmount = amount;
            this.commissionRate = rate;

            this.commission = (saleAmount * commissionRate);
        }

        public SalesTransaction(string name, double amount)
        {
            this.salesPerson = name;
            this.saleAmount = amount;
            this.commissionRate = 0;
        }

        public SalesTransaction(string name)
        {
            this.salesPerson = name;
            this.saleAmount = 0;
            this.commissionRate = 0;
            this.commission = 0;
        }

        public static SalesTransaction  operator+(SalesTransaction first, SalesTransaction second)
        {
            double newValue;
            newValue = first.saleAmount + second.saleAmount;

            string newName;
            newName = first.salesPerson + "and" + second.salesPerson;

            return (new SalesTransaction(newName, newValue)); 
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
        }
        public string SalesPerson
        {
            get
            {
                return salesPerson;
            }
            set
            {
                salesPerson = value;
            }
        }
        public double SaleAmount
        {
            get
            {
                return saleAmount;
            }
            set
            {
                saleAmount = value;
            }
        }
        public double Commission
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }

    }
}
