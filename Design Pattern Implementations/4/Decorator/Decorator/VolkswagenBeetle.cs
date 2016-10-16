using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class VolkswagenBeetle:ICar
    {
        public int getPrice()
        {
            return 30000;
        }

        public string getDescription()
        {
            return "two-door, four passenger, rear-engine economy car";
        }
    }
}
