using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifiedAd
{
    // Class Header (Object)
    class ClassifiedAd
    {
        // Instance Fields
        private string category;
        private int wordNum;
        private double price;

        //Properties 
        public int WordNum
        {
            get { return wordNum; }
            set
            {
                wordNum = value;
                price = value * .09;
            }
        }

        public double Price
        {
            get { return price; }
        }


        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //mutator for category
        public void SetCategory(string category)
        {
            this.category = category;
        }

        //mutator for wordNum
        public void SetWordNum(int wordNum)
        {
            this.wordNum = wordNum;
        }

    }
}
