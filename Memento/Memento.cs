using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoProject
{
    public class Memento
    {
        public string _state { get; }

        public Memento(string state)
        {
            _state = state;
        }
    }
}
