using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IPushObserver
    {
        /// <summary>
        /// Pushes the parameters defined below
        /// </summary>
        /// <param name="city"></param>
        /// <param name="scale"></param>
        void Update(string city, double scale);
    }
}
