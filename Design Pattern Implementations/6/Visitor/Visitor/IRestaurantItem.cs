using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IRestaurantItem
    {
        //basic methods for each item
        int Accept(IRestaurantVisitor visitor);
        int GetPrice();
    }
}
