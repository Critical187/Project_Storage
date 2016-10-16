using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IEarthQuake
    {
        void Attach(IPullObserver observer);
        //Attaches an observer using the pull-interface to the oven

        void Attach(IPushObserver observer);
        //Attaches an observer using the push-interface to the oven

        void Detach(IPullObserver observer);
        //Detaches a pull-observer

        void Detach(IPushObserver observer);
        //Detaches a push-observer

        void Notify();
        //A function to update the information on all the observers attached to the oven 
    }
}

