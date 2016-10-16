using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Invoker, that keeps track of commands done and allows to undo them
    /// </summary>
    public class CommandController
    {
        public event Action<Command> OnExecuted = (x) => { };
        public event Action<Command> OnUndone = (x) => { };

        private Stack<Command> undoStack = new Stack<Command>();
        public Command[] Commands { get { return this.undoStack.ToArray(); } }

        public bool CanUndo { get { return this.undoStack.Count != 0; } }

        public Command LastCommand
        {
            get
            {
                if (this.undoStack.Count == 0) return null;
                return this.undoStack.Peek();
            }
        }

        public void Execute(Command command)
        {
            command.Execute();
            undoStack.Push(command);
            OnExecuted(command);
        }

        public void Undo()
        {
            if (!CanUndo) return;
            Command command = undoStack.Pop();
            command.Undo();
            OnUndone(command);
        }
    }
}
