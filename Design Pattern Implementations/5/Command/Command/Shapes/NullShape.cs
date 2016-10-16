using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Shapes
{
    /// <summary>
    /// Shape that is used to fill in the grid when no player has made a move
    /// </summary>
    public class NullShape : Shape
    {
        public override char Representation
        {
            get { return ' '; }
        }
    }
}
