using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Order
    {
        //fields
        private string orderNumber;
        private string cusName;
        private double quantity;
        private double totalPrice;

        //properties
        public string OrderNumber
        {
            get
            {
                return orderNumber;
            }
            set
            {
                orderNumber = value;
            }
        }
        public string CusName
        {
            get
            {
                return cusName;
            }
            set
            {
                cusName = value;
            }
        }
        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public double TotalPrice
        {
            get
            {
                totalPrice = quantity * 19.95;
                return totalPrice;
            }
        }
        
        //constructors
        public Order()
        {

        }
        public Order(string num, string name, double q)
        {
            orderNumber = num;
            cusName = name;
            quantity = q;
        }

        //methods
        public override bool Equals(Object e)  //equals()
        {
            bool isEqual;
            Order temp = (Order)e;
            if (orderNumber == temp.orderNumber)
                isEqual = true;
            else
                isEqual = false;
            return isEqual; 
        }


    }
}
