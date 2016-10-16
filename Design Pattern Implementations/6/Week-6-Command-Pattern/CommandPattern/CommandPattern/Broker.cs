using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CommandPattern
{
    class Broker
    {
        private ArrayList orderList = new ArrayList();

        public void TakeOrder(Order o)
        {
            orderList.Add(o);
        }

        public void PlaceOrders()
        {
            foreach(Order o in orderList)
            {
                o.Execute();
            }
            orderList.Clear();
        }
    }
}
