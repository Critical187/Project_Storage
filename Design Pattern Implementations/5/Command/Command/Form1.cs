using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        TicTacToeGame Game;
        CommandController CommandController;

        Dictionary<Button, ButtonToGridAssociation> associations = new Dictionary<Button, ButtonToGridAssociation>();

        public Form1()
        {
            InitializeComponent();

            this.Game = new TicTacToeGame();
            this.CommandController = new CommandController();

            this.CommandController.OnExecuted += (command) => RefreshLastCmd(command);
            this.CommandController.OnUndone += (command) => RefreshLastCmd(command);

            this.Game.Player1.OnRepresentationAltered += (x) => { RefreshGrid(); RefreshInfoLabel(); };
            this.Game.Player2.OnRepresentationAltered += (x) => { RefreshGrid(); RefreshInfoLabel(); };

            this.Game.Grid.OnShapePlaced += (shape, row, column) => 
                this.associations.Where(x => x.Value.Row == row && x.Value.Column == column).First().Value.Update(this.Game.Grid);

            ColorAssociation[] colorAssociations = new ColorAssociation[]
            {
                new ColorAssociation("Black", Color.Black),
                new ColorAssociation("Red", Color.Red),
                new ColorAssociation("Purple", Color.Purple),
                new ColorAssociation("Green", Color.Green),
            };

            foreach (Type shapeType in typeof(Shape).Assembly.GetTypes().Where(x=>x.IsSubclassOf(typeof(Shape))))
            {
                if (shapeType == typeof(Shapes.NullShape)) continue;
                cboxP1Shape.Items.Add(Activator.CreateInstance(shapeType, null));
                cboxP2Shape.Items.Add(Activator.CreateInstance(shapeType, null));
            }

            this.cboxP1Shape.SelectedValueChanged += (x, y) =>
                CommandController.Execute(
                    new Commands.ChangePlayerShapeCommand(
                    Game.Player1, (this.cboxP1Shape.SelectedItem as Shape), this.Game)
                );

            this.cboxP2Shape.SelectedValueChanged += (x, y) =>
                CommandController.Execute(
                    new Commands.ChangePlayerShapeCommand(
                    Game.Player2, (this.cboxP2Shape.SelectedItem as Shape), this.Game)
                );

            this.cboxP1Color.Items.AddRange(colorAssociations);
            this.cboxP2Color.Items.AddRange(colorAssociations);

            this.cboxP2Color.SelectedValueChanged += (x, y) => 
                CommandController.Execute(
                    new Commands.ChangePlayerColorCommand(
                    Game.Player2, (this.cboxP2Color.SelectedItem as ColorAssociation).Color, this.Game)
                );

            this.cboxP1Color.SelectedValueChanged += (x, y) =>
                CommandController.Execute(
                    new Commands.ChangePlayerColorCommand(
                    Game.Player1, (this.cboxP1Color.SelectedItem as ColorAssociation).Color, this.Game)
                ); 

            RefreshInfoLabel();

            AddAssociation(button1, 0, 0);
            AddAssociation(button2, 0, 1);
            AddAssociation(button3, 0, 2);

            AddAssociation(button4, 1, 0);
            AddAssociation(button5, 1, 1);
            AddAssociation(button6, 1, 2);

            AddAssociation(button7, 2, 0);
            AddAssociation(button8, 2, 1);
            AddAssociation(button9, 2, 2);

            RefreshGrid();
        }

        void RefreshInfoLabel()
        {
            Player winner = Game.Winner;
            if (winner != null)
            {
                this.infoLabel.Text = "Player with " + winner.CurrentShape.Representation + " has won";
                this.infoLabel.ForeColor = winner.CurrentColor;
            }
            else
            {
                this.infoLabel.ForeColor = Game.CurrentPlayer.CurrentColor;
                this.infoLabel.Text = "Player with " + Game.CurrentPlayer.CurrentShape.Representation + " is on turn";
            }
        }

        void RefreshLastCmd(Command command)
        {
            if (CommandController.CanUndo)
                this.lastCmd.Text = command.ToString();
            else
                this.lastCmd.Text = "Nothing to undo";
        }

        private void AddAssociation(Button button, int row, int column)
        {
            this.associations.Add(button, new ButtonToGridAssociation(button, row, column));
            button.Click += (x, y) => HandleClick(row, column);
        }

        private void HandleClick(int row, int column)
        {
            if (Game.HasWinner) return;
            if(Game.Grid.Slots[row][column] == null)
                this.CommandController.Execute(new Commands.PlacePlayerShapeCommand(Game.CurrentPlayer, row, column, this.Game));
            RefreshInfoLabel();
        }

        private void RefreshGrid()
        {
            foreach (var item in associations)
            {
                RefreshGridAt(item.Key);
            }
        }

        private void RefreshGridAt(Button button)
        {
            this.associations[button].Update(this.Game.Grid);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            CommandController.Undo();
        }

        class ButtonToGridAssociation
        {
            public Button Button;
            public int Row;
            public int Column;

            public ButtonToGridAssociation(Button button, int row, int column)
            {
                this.Button = button;
                this.Row = row;
                this.Column = column;
            }

            public void Update(Grid grid)
            {
                Player slot = grid.Slots[Row][Column];
                if (slot == null)
                    Button.Text = "";
                else
                {
                    Button.ForeColor = slot.CurrentColor;
                    Button.Text = slot.CurrentShape.Representation.ToString();
                }
            }
        }

        class ColorAssociation
        {
            public string Name { get; private set; }
            public Color Color { get; private set; }

            public ColorAssociation(string name, Color color)
            {
                this.Name = name;
                this.Color = color;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }
    }
}
