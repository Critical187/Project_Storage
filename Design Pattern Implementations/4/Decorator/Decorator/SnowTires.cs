using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SnowTires:CarDecorator
    {
        public SnowTires(ICar c) : base(c) { }
        public override int getPrice()
        {
            return base.getPrice() + 120;
        }
        public override string getDescription()
        {
            return base.getDescription() + "\nwith added snow tires, of type " + getType();
        }
        public string getType()
        {
            return "radial";
        }
    }
}
