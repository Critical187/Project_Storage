using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// CommandBase, allowing commands to be executed on the TicTacToeGame
    /// </summary>
    public abstract class Command
    {
        public TicTacToeGame Game { get; private set; }

        public Command(TicTacToeGame game)
        {
            this.Game = game;
        }

        public abstract void Execute();
        public abstract void Undo();

        public override string ToString()
        {
            return this.GetType().Name.Replace("Command", "");
        }
    }
}
