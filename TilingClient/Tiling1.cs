using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingClient
{
    class Room
    {
        // Instance Fields
        private double length;
        private double width;
        private double floorArea;
        private int boxNum;

        public Room()
        {

        }
        public Room(double l, double w)
        {
            this.length = l;
            this.width = w;
            this.floorArea = getFloorArea(this.length, this.width);
            this.boxNum = getBoxNum(this.floorArea);
        }
        private double getFloorArea(double l, double w)
        {
            return l * w;
        }
        private int getBoxNum(double area)
        {
            int x = 1;
            x += Convert.ToInt32(area / 12);
            if (x % 12 > 0)
            {
                ++x;
            }
            return x;
        }
        public double Length
        {
            get
            {
                return length;
            }

        }
        public double Width
        {
            get
            {
                return width;
            }

        }
        public double FloorArea
        {
            get
            {
                return floorArea;
            }

        }
        public int BoxNum
        {
            get
            {
                return boxNum;
            }

        }
    }
}
