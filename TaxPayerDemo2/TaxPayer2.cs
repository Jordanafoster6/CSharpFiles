using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo2
{
    class TaxPayer2: IComparable
    {
        // Instance Fields
        private string socialSecurityNumber;
        private double grossIncome;
        private double taxOwed;

        // Properties
        public double GrossIncome
        {
            get
            {
                return grossIncome;
            }
            set
            {
                grossIncome = value;
                if (grossIncome < 30000)
                {
                    taxOwed = grossIncome * .15;
                }
                else
                {
                    taxOwed = grossIncome * .28;
                }
            }
        }

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                socialSecurityNumber = value;
            }
        }

        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }

        int IComparable.CompareTo(object o)
        {
            int returnVal;
            TaxPayer2 temp = (TaxPayer2)o;
            if (this.taxOwed > temp.taxOwed)
            {
                returnVal = 1;
            }
            else if (this.taxOwed < temp.taxOwed)
            {
                returnVal = -1;
            }
            else
            {
                returnVal = 0;
            }
            return returnVal;
        }
    }
}
