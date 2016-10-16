using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Interface that allows different producers to provide their offers for different cars
    /// </summary>
    interface ICarFactory
    {
        string Name { get; }
        Car CreateLowCostCar();
        Car CreateMediumCostCar();
        Car CreateHighCostCar();
    }
}
