using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IPullObserver
    {
        /// <summary>
        /// Notifies that the state has changed so that it fetches the information from the subject
        /// </summary>
        void Update();
    }
}
