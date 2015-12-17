using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativesBirthdayDemo
{
    class RelativesBirthday : IComparable
    {
        public string name { get; set; }
        public string relationship { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int year { get; set; }

        //Constructors
        public RelativesBirthday(string n, string r, int m, int d, int y)
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
            RelativesBirthday temp = (RelativesBirthday)o;
            return string.Compare(this.name, temp.name);
        }
    }
}
