using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Holder for details of a car.
    /// </summary>
    class Car
    {
        public string Model { get; private set; }
        public string ImageURL { get; private set; }
        public int Price { get; private set; }

        /// <summary>Returns the name of the producer</summary>
        public string Brand { get { return this.Producer.Name; } }
        /// <summary>Returns the Brand Model and Price combined</summary>
        public string Description { get { return this.Brand + " " + this.Model + ":$" + this.Price; } }

        public ICarFactory Producer { get; private set; }

        public Car(string model, string imageUrl,int price, ICarFactory creator)
        {
            this.Model = model;
            this.ImageURL = imageUrl;
            this.Price = price;
            this.Producer = creator;
        }
    }
}
