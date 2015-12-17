using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class TaxPayer
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
                if (grossIncome < 30000 )
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
    }
}
