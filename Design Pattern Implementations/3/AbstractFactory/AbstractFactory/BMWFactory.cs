using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class BMWFactory : ICarFactory
    {
        public string Name
        {
            get { return "BMW"; }
        }

        public Car CreateLowCostCar()
        {
            return new Car("X1 ", "https://a.tcimg.net/v//colorid_images/v1/1333666/360x185/f3q", 34700, this);
        }

        public Car CreateMediumCostCar()
        {
            return new Car("Series 2", "https://a.tcimg.net/v//colorid_images/v1/1328587/360x185/f3q", 43400, this);
        }

        public Car CreateHighCostCar()
        {
            return new Car("M3", "https://a.tcimg.net/v//colorid_images/v1/1326266/360x185/f3q", 61000, this);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
