using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Secondary receiver
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Called when the current shape or color has been modified
        /// </summary>
        public event Action<Player> OnRepresentationAltered = (x) => { };

        public Shape CurrentShape { get; private set; }
        public System.Drawing.Color CurrentColor { get; private set; }

        public Player(Shape shape, System.Drawing.Color color)
        {
            this.CurrentShape = shape;
            this.CurrentColor = color;
        }

        public void ChangeShape(Shape shape)
        {
            this.CurrentShape = shape;
            OnRepresentationAltered(this);
        }

        public void ChangeColor(System.Drawing.Color color)
        {
            this.CurrentColor = color;
            OnRepresentationAltered(this);
        }
    }
}
