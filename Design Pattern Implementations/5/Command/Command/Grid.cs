using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Game grid with 3x3 slots where the players can place their shapes.
    /// </summary>
    public class Grid
    {
        public event Action<Shape, int, int> OnShapePlaced = (shape, row, column) => { };
 
        const int GRID_SIZE = 3;
        /// <summary>
        /// Correlates that a specific slot is owned by a specific player
        /// </summary>
        public Player[][] Slots { get; private set; }

        public Grid()
        {
            this.Slots = new Player[GRID_SIZE][];
            for (int i = 0; i < GRID_SIZE; i++)
            {
                this.Slots[i] = new Player[GRID_SIZE];
            }
        }

        /// <summary>
        /// Assigns a shape to a specific grid slot, using the Player as an identifier.
        /// </summary>
        /// <param name="player">uses the player's shape. If null, assigns to a Default shape ( NullShape )</param>
        public void PlaceShapeAt(int row, int column, Player player)
        {
            if (row >= GRID_SIZE || column >= GRID_SIZE || row < 0 || column < 0)
                throw new InvalidOperationException("INDEX OUT OF GRID");

            this.Slots[row][column] = player;

            //Use default shape if player is not specified // clear the slot
            if (player == null)
                this.OnShapePlaced(new Shapes.NullShape(), row, column);
            else
                this.OnShapePlaced(player.CurrentShape, row, column);
        }
    }
}
