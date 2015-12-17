using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativesListDemo
{
    class RelativesList : IComparable
    {
        public string name { get; set; }
        public string relationship { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int year { get; set; }

        //Constructors
        public RelativesList(string n, string r, int m, int d, int y)
        {
            name = n;
            relationship = r;
            month = m;
            day = d;
            year = y;
        }

        //IComparable
        int IComparable.CompareTo(object o)
        {
            RelativesList temp = (RelativesList)o;
            return string.Compare(this.name, temp.name);
        }
    }
}
