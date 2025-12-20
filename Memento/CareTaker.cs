using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoProject
{
    internal class CareTaker
    {
        private readonly Stack<Memento> _history = new Stack<Memento>();

        public void Backup(Originator originator)
        {
            _history.Push(originator.Save());
        }

        public void Undo(Originator originator)
        {
            if (_history.Count == 0) return;

            var memento = _history.Pop();
            originator.Restore(memento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("История:");
            foreach (var index in _history)
            {
                Console.WriteLine($" '{index._state}'");
            }
        }
    }
}
