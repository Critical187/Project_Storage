using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    static class Extentions
    {
        public static IEnumerable<Car> AllModels(this ICarFactory factory)
        {
            List<Car> models = new List<Car>();
            //iterate all classes that implement ICarFactory within the assembly of ICarFactory
            foreach (var method in typeof(ICarFactory).GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                //get all methods that Create a car and invoke them to create a car
                //all methods in the factory are without parameters by design.
                if (method.ReturnType == typeof(Car) && method.GetParameters().Length == 0) models.Add(method.Invoke(factory, null) as Car);
            }

            return models;
        }
    }
}
