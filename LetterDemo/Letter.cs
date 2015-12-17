using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    class Letter
    {
        public string name { get; set; }
        public string dateMailed { get; set; }
        public override string ToString()
        {
            string s;
            s = " // Type:" + this.GetType() + " // Name:" + this.name + " // Date Mailed:" + this.dateMailed;
            return s;
        }
        public Letter()
        {
        }
        public Letter(string n, string d)
        {
            this.name = n;
            this.dateMailed = d;
        }
    }
}
