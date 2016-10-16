using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Shapes
{
    class SquareShape : Shape
    {
        public override char Representation
        {
            get { return '■'; }
        }
    }
}
