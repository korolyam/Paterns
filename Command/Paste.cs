using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Command
{
    public class PasteCommand : ICommand
    {
        private readonly Document _document;
        private string _pastedText = "";

        public PasteCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _pastedText = _document.Clipboard;
            _document.Paste();
        }

        public void Undo()
        {
            _document.Remove(_pastedText);
            Console.WriteLine($"Undo Paste: удалено '{_pastedText}'");
        }
    }
}
