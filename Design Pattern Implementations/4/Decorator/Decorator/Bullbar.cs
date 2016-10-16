using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Bullbar:CarDecorator
    {
        public Bullbar(ICar c) : base(c) { }
        public override int getPrice()
        {
            return base.getPrice() + 80;
        }
        public override string getDescription()
        {
            return base.getDescription() + "\nwith an added bull bar that weights " + getWeight().ToString();
        }

        public int getWeight()
        {
            return 10;
        }
    }
}
