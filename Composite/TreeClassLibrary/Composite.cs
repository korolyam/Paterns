using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject.TreeClassLibrary
{
    public class Composite : IComponent
    {
        private double _value;

        private List<IComponent> _children = new List<IComponent>();

        public Composite(double value)
        {
            _value = value;
        }

        public void Add(IComponent child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Нельзя добавить ничего");
            }
            _children.Add(child);
        }

        public void Remove(IComponent child)
        {
            if (!_children.Contains(child))
            {
                throw new ArgumentException("Такого компонента и так нет");
            }
            _children.Remove(child);
        }

        public double GetValue()
        {
            return _value;
        }

        public List<double> GetValueOfAllChildren()
        {
            List<double> children = new List<double>();
            for (int i = 0; i < _children.Count; i++)
            {
                if (_children[i] is Composite)
                {
                    Composite child = (Composite)_children[i];
                    children.AddRange(child.GetValueOfAllChildren());
                }
                else
                {
                    children.Add(_children[i].GetValue());
                }
            }
            children.Add(_value);
            return children;
        }
    }
}
        