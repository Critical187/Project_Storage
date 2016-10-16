using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock theAbcStock)
        {
            abcStock = theAbcStock;
        }
        public void Execute()
        {
            abcStock.Buy();
        }
    }
}
