using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class RestaurantVisitor: IRestaurantVisitor
    {
        //extra func: using a first time coupon to reduce the price of each thing you order by a different amount
        private bool hasFirstTimeCoupon;
        private int price;
        public RestaurantVisitor(bool coupon)
        {
            this.hasFirstTimeCoupon = coupon;
        }
        //implements the basic methods of the interface
        public int Visit(Steak steak)
        {
            price = steak.GetPrice();
            if (steak.hasSauce) { price += 5; }
            if (hasFirstTimeCoupon) { price -= 3; }
            return price;
        }

        public int Visit(Tea tea)
        {
            price = tea.GetPrice();
            if (tea.inJug) { price += 3; }
            if (hasFirstTimeCoupon) { price -= 2; }
            return price;
        }

        public int Visit(Fries fries)
        {
            price = fries.GetPrice();
            if (fries.withKetchup) { price += 2; }
            if (hasFirstTimeCoupon) { price -= 1; }
            return price;
        }
    }
}
