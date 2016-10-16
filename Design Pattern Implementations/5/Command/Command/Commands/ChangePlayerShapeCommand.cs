using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    class ChangePlayerShapeCommand : PlayerCommand
    {
        public Shape Shape { get; private set; }
        private Shape shapeBeforeExecute;

        public ChangePlayerShapeCommand(Player player, Shape shape, TicTacToeGame game)
            : base(player, game)
        {
            this.Shape = shape;
        }

        public override void Execute()
        {
            this.shapeBeforeExecute = base.Player.CurrentShape;
            base.Game.ChangePlayerShapeTo(base.Player, this.Shape);
        }

        public override void Undo()
        {
            base.Game.ChangePlayerShapeTo(base.Player, this.shapeBeforeExecute);
        }
    }
}
