using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    class ChangePlayerColorCommand : PlayerCommand
    {
        public System.Drawing.Color Color { get; private set; }
        private System.Drawing.Color colorBeforeExecute;

        public ChangePlayerColorCommand(Player player, System.Drawing.Color color, TicTacToeGame game)
            : base(player, game)
        {
            this.Color = color;
        }

        public override void Execute()
        {
            this.colorBeforeExecute = base.Player.CurrentColor;
            base.Game.ChangePlayerColorTo(base.Player, this.Color);
        }

        public override void Undo()
        {
            base.Game.ChangePlayerColorTo(base.Player, this.colorBeforeExecute);
        }
    }
}
