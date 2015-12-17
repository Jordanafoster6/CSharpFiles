using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencesDemo
{
    class Conferences : IComparable
    {
        private string name;
        private string date;
        private int atendeeNum;

        //Constructor
        public Conferences(string n, string d, int a)
        {
            name = n;
            date = d;
            atendeeNum = a;
        }

        // Proerties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int AtendeeNum
        {
            get
            {
                return atendeeNum;
            }
            set
            {
                atendeeNum = value;
            }
        }

        //IComparable
        int IComparable.CompareTo(object o)
        {
            int returnVal;
            Conferences temp = (Conferences)o;
            if (this.atendeeNum > temp.atendeeNum)
            {
                returnVal = 1;
            }
            else if (this.atendeeNum < temp.atendeeNum)
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
