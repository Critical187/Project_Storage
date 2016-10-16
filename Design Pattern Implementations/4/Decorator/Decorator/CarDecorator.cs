using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class CarDecorator:ICar
    {
        ICar car;
        public CarDecorator(ICar c)
        {
            this.car = c;
        }
        public virtual int getPrice()
        {
            return car.getPrice();
        }

        public virtual string getDescription()
        {
            return car.getDescription();
        }
    }
}
