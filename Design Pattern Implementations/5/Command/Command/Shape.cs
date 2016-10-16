using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Base class for a shape within the game
    /// </summary>
    public abstract class Shape
    {
        public abstract char Representation { get; }

        public override string ToString()
        {
            return this.GetType().Name.Replace("Shape", "");
        }
    }
}
