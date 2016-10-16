using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class PlacePlayerShapeCommand : PlayerCommand
    {
        public int Row { get; private set; }
        public int Column { get; private set; }

        public PlacePlayerShapeCommand(Player player, int row, int column, TicTacToeGame game)
            : base(player, game)
        {
            this.Row = row;
            this.Column = column;
        }

        public override void Execute()
        {
            base.Game.PlacePlayerShapeAt(base.Player, this.Row, this.Column);
        }

        public override void Undo()
        {
            base.Game.PlacePlayerShapeAt(null, this.Row, this.Column);
        }
    }
}
