using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Command that has to be executed using a player of the TicTacToe game
    /// </summary>
    public abstract class PlayerCommand : Command
    {
        public Player Player { get; private set; }

        public PlayerCommand(Player player, TicTacToeGame game)
            : base(game)
        {
            this.Player = player;
        }

        public override string ToString()
        {
            return base.ToString().Replace("Player", "Player ");
        }
    }
}
