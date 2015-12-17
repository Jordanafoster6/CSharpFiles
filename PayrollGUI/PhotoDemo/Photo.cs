using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class Photo
    {
        private double width;
        private double height;
        protected double price;

        //Properties
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }

        //Constructors
        public Photo()
        {

        }
        public Photo(double h, double w)
        {
            this.height = h;
            this.width = w;

            if (w == 8 && h ==10)
            {
                price = 3.99;
            }
            else if (w == 10 && h ==12)
            {
                price = 5.99;
            }
            else
            {
                price = 9.99;
            }
        }

        //To String Override
        public override string ToString()
        {
            string s;
            s = " // Type:" + this.GetType() + " // Width:" + this.width + " // Height:" + this.height + " // Price: " + this.price;
            return s;
        }
    }
}
