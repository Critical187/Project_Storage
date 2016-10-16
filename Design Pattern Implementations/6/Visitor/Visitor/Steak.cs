using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Steak:IRestaurantItem
    {
        public Steak(bool sauce)
        {
            this.hasSauce = sauce;
        }
        public int Accept(IRestaurantVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public int GetPrice()
        {
            return 9;
        }
        public bool hasSauce;
    }
}
