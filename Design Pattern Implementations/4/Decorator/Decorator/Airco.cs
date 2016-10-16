using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Airco:CarDecorator
    {
        public Airco(ICar c) : base(c) { }
        public override int getPrice()
        {
            return base.getPrice() + 300 + getServiceCost();
        }
        public override string getDescription()
        {
            return base.getDescription() + "\nwith an added air conditioning system";
        }
        public int getServiceCost()
        {
            return 25;
        }
    }
}
