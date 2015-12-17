using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    class CertifiedLetter : Letter
    {
        public double trackingNum { get; set; }

        public CertifiedLetter(double tNum)
        {
            this.trackingNum = tNum;
        }

        public override string ToString()
        {
            string s;
            s = " // Type:" + this.GetType() + " // Name:" + this.name + " // Date Mailed:" + this.dateMailed + " // Tracking Number: " + this.trackingNum;
            return s;
        }
    }
}
