using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Tea:IRestaurantItem
    {
        public Tea(bool jug)
        {
            this.inJug = jug;
        }
        public int Accept(IRestaurantVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public int GetPrice()
        {
            return 4;
        }
        public bool inJug;
    }
}
