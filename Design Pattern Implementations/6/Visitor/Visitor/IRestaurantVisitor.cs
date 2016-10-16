using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IRestaurantVisitor
    {
        //basic methods for each object
        int Visit(Steak steak);
        int Visit(Tea tea);
        int Visit(Fries fries);
    }
}
