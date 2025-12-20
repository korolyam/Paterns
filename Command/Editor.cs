using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Editor
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                ICommand command = _history.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("Нет команд для Undo");
            }
        }
    }
}
