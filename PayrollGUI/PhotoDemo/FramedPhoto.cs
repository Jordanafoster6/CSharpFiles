using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class FramedPhoto : Photo
    {
        public string frameMaterial;
        public string frameStyle;

        //Properties
        public string FrameMaterial
        {
            get
            {
                return frameMaterial;
            }
            set
            {
                frameMaterial = value;
            }
        }
        public string FrameStyle
        {
            get
            {
                return frameStyle;
            }
            set
            {
                frameStyle = value;
            }
        }

        //Constructors
        public FramedPhoto()
        {

        }
        public FramedPhoto(string m, string s)
        {
            this.frameMaterial = m;
            this.frameStyle = s;
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
        public FramedPhoto(double w, double h, string m, string s)
        {
            this.frameMaterial = m;
            this.frameStyle = s;

            if (w == 8 && h == 10)
            {
                price = 3.99;
            }
            else if (w == 10 && h == 12)
            {
                price = 5.99;
            }
            else
            {
                price = 9.99;
            }
        }

        //ToString
        public override string ToString()
        {
            string s;
            s = " // Type:" + this.GetType() + " // Material:" + this.frameMaterial + " // Style:" + this.frameStyle + " // Price:" + (this.price + 25);
            return s;
        }
    }
}
