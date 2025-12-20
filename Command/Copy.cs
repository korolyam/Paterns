using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Command
{
    public class Copy : ICommand
    {
        private readonly Document _document;
        private readonly string _selection;

        public Copy(Document document, string selection)
        {
            _document = document;
            _selection = selection;
        }

        public void Execute()
        {
            _document.Copy(_selection);
        }

        public void Undo()
        {
            Console.WriteLine("Undo для Copy не нужен");
        }
    }
}