using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject.TreeClassLibrary
{
    public class Leaf : IComponent
    {
        private double _value;

        public Leaf(double value)
        {
            _value = value;  
        }

        public double GetValue()
        {
            return _value;
        }

        
    }
}
