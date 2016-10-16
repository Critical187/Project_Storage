using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Receiver of Command Pattern
    /// </summary>
    public class TicTacToeGame
    {
        public Player Player1 = new Player(new Shapes.XShape(), System.Drawing.Color.Black);
        public Player Player2 = new Player(new Shapes.CircleShape(), System.Drawing.Color.Black);

        public Player CurrentPlayer { get; private set; }

        public Grid Grid = new Grid();

        /// <summary>
        /// Goes thorough all of the slots and finds a row/diagonal/column with 3 same pieces placed by a player
        /// </summary>
        public Player Winner
        {
            get
            {
                int gridSize = Grid.Slots.Length;
                Player[][] slots = Grid.Slots;
                int same = 0;
                //check Left - Right
                for (int i = 0; i < gridSize; i++)
                {
                    same = 0;
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (slots[i][j] == null) break;

                        if (slots[i][j] == slots[i][0])
                            same += 1;
                        if (same == gridSize)
                        {
                            return slots[i][j];
                        }
                    }
                }

                //Check Up - Down
                for (int i = 0; i < gridSize; i++)
                {
                    same = 0;
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (slots[j][i] == null) break;

                        if (slots[j][i] == slots[0][i])
                            same += 1;
                        if (same == gridSize)
                        {
                            return slots[j][i];
                        }
                    }
                }
                same = 0;
                //Check Diagonal Top Left - Bottom Right
                for (int i = 0; i < gridSize; i++)
                {
                    if (slots[i][i] == null) break;

                    if (slots[i][i] == slots[0][0])
                        same += 1;
                    if (same == gridSize)
                    {
                        return slots[i][i];
                    }
                }

                same = 0;
                //Check Diagonal Top Right - Bottom Left
                int currentRow = 0;
                for (int i = gridSize - 1; i > -1; i--, currentRow++)
                {
                    if (slots[currentRow][i] == null) break;

                    if (slots[currentRow][i] == slots[0][gridSize - 1])
                        same += 1;
                    if (same == gridSize)
                    {
                        return slots[currentRow][i];
                    }
                }

                return null;
            }
        }

        public bool HasWinner
        {
            get
            {
                return Winner != null;
            }
        }

        public TicTacToeGame()
        {
            this.CurrentPlayer = Player1;
        }

        public void ChangePlayerShapeTo(Player player, Shape shape)
        {
            player.ChangeShape(shape);
        }

        public void ChangePlayerColorTo(Player player, System.Drawing.Color color)
        {
            player.ChangeColor(color);
        }

        /// <summary>
        /// Places a shape based on the player specified. If the player is null, then the slot is cleared
        /// </summary>
        /// <param name="player">The player who is placing the shape or null.</param>
        public void PlacePlayerShapeAt(Player player, int row, int column)
        {
            //check if the correct player is at turn
            if (player != null)
                if (CurrentPlayer != player) return;

            //otherwise set the other to be at turn
            if (player == Player1)
                CurrentPlayer = Player2;
            else if (player == Player2)
                CurrentPlayer = Player1;
            else if (player == null) // if the shape was undone -> player == null -> use the previous player
                if (CurrentPlayer == Player1)
                    CurrentPlayer = Player2;
                else if (CurrentPlayer == Player2)
                    CurrentPlayer = Player1;

            Grid.PlaceShapeAt(row, column, player);
        }
    }
}
