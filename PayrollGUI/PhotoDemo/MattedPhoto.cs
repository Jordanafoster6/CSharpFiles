using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class MattedPhoto : Photo
    {
        public string color;

        //Properties
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        //Constructors
        public MattedPhoto()
        {

        }
        public MattedPhoto(string c)
        {
            this.color = c;
            if (this.Width == 8 && this.Height == 10)
            {
                this.price = 3.99;
            }
            else if (this.Width == 10 && this.Height == 12)
            {
                this.price = 5.99;
            }
            else
            {
                this.price = 9.99;
            }
        }
        public MattedPhoto(double w, double h, string c)
        {
            this.color = c;
        }

        //ToString
        public override string ToString()
        {
            string s;
            s = " // Type:" + this.GetType() + " // Color:" + this.color + " // Price:" + (this.price + 10);
            return s;
        }
    }
}
