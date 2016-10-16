using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class SpecialRestaurantVisitor:IRestaurantVisitor
    {
        public SpecialRestaurantVisitor(int disc)
        {
            this.Discount = disc;
        }
        //implementing the interface using a discount as added func
        public int Visit(Steak steak)
        {
            if (steak.hasSauce) { return steak.GetPrice() + 4 - Discount; }
            else return steak.GetPrice() - Discount;
        }

        public int Visit(Tea tea)
        {
            if (tea.inJug) { return tea.GetPrice() + 3 - Discount; }
            else return tea.GetPrice() - Discount;
        }

        public int Visit(Fries fries)
        {
            if (fries.withKetchup) { return fries.GetPrice() + 2 - Discount; }
            else return fries.GetPrice()-Discount;
        }
        //extra func: a discount
        private int Discount;
    }
}
