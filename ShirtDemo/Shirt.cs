using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtDemo
{
    class Shirt
    {
        //Instances
        public string material { get; set; }
        public string color { get; set; }
        public string size { get; set; }

        public Shirt()
        {

        }
        public Shirt(string m, string c, string s)
        {
            this.material = m;
            this.color = c;
            this.size = s;
        }

    }
}
