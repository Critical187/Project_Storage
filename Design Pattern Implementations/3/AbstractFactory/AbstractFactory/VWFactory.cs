using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class VWFactory : ICarFactory
    {
        public string Name
        {
            get { return "VolksWagen"; }
        }

        public Car CreateLowCostCar()
        {
            return new Car("GOLF", "https://a.tcimg.net/v//colorid_images/v1/1339498/360x185/f3q", 26000, this);
        }

        public Car CreateMediumCostCar()
        {
            return new Car("Passat", "https://a.tcimg.net/v//colorid_images/v1/1356463/360x185/f3q",35000, this);
        }

        public Car CreateHighCostCar()
        {
            return new Car("Touareg", "https://a.tcimg.net/v//colorid_images/v1/1343375/360x185/f3q",48200, this);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
