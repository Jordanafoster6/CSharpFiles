using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDemo
{
    class Jobs
    {
        private string description;
        private double timeInHours;
        private double hourRate;
        private double totalFee;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public double TimeInHours
        {
            get
            {
                return timeInHours;
            }
            set
            {
                timeInHours = value;
                totalFee = timeInHours * hourRate;
            }
        }
        public double HourRate
        {
            get
            {
                return hourRate;
            }
            set
            {
                hourRate = value;
                totalFee = hourRate * timeInHours;
            }
        }

        public Jobs()
        {

        }

        public Jobs(double time, double hour, string enterJob) // always public capital then params
        {
            this.totalFee = time * hour;
        }

        public static Jobs operator +(Jobs x, Jobs y)
        {
            string s = x.description + "and" + y.description;
            double h = x.timeInHours + y.timeInHours;
            double r = x.hourRate + y.hourRate;
            return new Jobs(h, r, s);
        }
    }
}
