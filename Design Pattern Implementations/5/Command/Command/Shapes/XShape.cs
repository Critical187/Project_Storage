using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Shapes
{
    class XShape : Shape
    {
        public override char Representation
        {
            get { return 'X'; }
        }
    }
}
