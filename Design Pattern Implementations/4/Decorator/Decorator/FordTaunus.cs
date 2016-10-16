using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class FordTaunus:ICar
    {
        public int getPrice()
        {
            return 16000;
        }

        public string getDescription()
        {
            return "two-door, front engine, family car";
        }
    }
}
