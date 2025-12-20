using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class CutCommand : ICommand
    {
        private readonly Document _document;
        private readonly string _selection;

        public CutCommand(Document document, string selection)
        {
            _document = document;
            _selection = selection;
        }

        public void Execute()
        {
            _document.Cut(_selection);
        }

        public void Undo()
        {
            _document.Append(_selection);
            Console.WriteLine($"Undo Cut: возвращено '{_selection}'");
        }
    }
}
