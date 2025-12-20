using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Document
    {
        private string _text = "";
        public string Clipboard { get; private set; } = "";

        public void Copy(string selection)
        {
            Clipboard = selection;
            Console.WriteLine($"Скопировано: '{Clipboard}'");
        }

        public void Paste()
        {
            Append(Clipboard);
            Console.WriteLine($"Вставлено: '{Clipboard}'");
        }

        public void Cut(string selection)
        {
            Clipboard = selection;
            Remove(selection);
            Console.WriteLine($"Вырезано: '{Clipboard}'");
        }

        public void Append(string text)
        {
            _text += text;
        }

        public void Remove(string text)
        {
            _text = _text.Replace(text, "");
        }

        public void Show()
        {
            Console.WriteLine($"Текущий текст: '{_text}'");
        }
    }
}
