using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Fries:IRestaurantItem
    {
        public Fries(bool ketchup)
        {
            this.withKetchup = ketchup;
        }
        public int Accept(IRestaurantVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public int GetPrice()
        {
            return 5;
        }
        public bool withKetchup;
    }
}
