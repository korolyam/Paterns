using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject.TreeClassLibrary
{
    public class Node : IComponent
    {
        private  double _value;
        
        public IComponent Left { get; set; }

        public IComponent Right { get; set; }

        public Node(double value, IComponent left, IComponent right)
        {
            _value = value;
            Left = left;
            Right = right;
        }

        public double GetValue()
        {
            return _value;
        }
    }
}
