using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock theAbcStock)
        {
            abcStock = theAbcStock;
        }
        public void Execute()
        {
            abcStock.Sell();
        }
    }
}
