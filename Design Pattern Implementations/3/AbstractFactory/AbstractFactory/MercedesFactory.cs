using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MercedesFactory : ICarFactory
    {
        public string Name
        {
            get { return "Mercedes"; }
        }

        public Car CreateLowCostCar()
        {
            return new Car("B class", "https://a.tcimg.net/v//colorid_images/v1/1313968/360x185/f3q", 40000, this);
        }

        public Car CreateMediumCostCar()
        {
            return new Car("E class", "https://a.tcimg.net/v//colorid_images/v1/1318932/360x185/f3q", 51300, this);
        }

        public Car CreateHighCostCar()
        {
            return new Car("S class", "https://a.tcimg.net/v//colorid_images/v1/1341728/360x185/f3q", 92300, this);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
