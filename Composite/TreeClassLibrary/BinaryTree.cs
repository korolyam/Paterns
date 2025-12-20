using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Collections;
using CompositeProject.TreeClassLibrary.IteratorProject;

namespace CompositeProject.TreeClassLibrary
{
    public class BinaryTree : IteratorAggregate
    {
        private IComponent _root = null;
        public int Count { get; private set; } = 0;
        private bool _direction = false;

        public BinaryTree() { }

        public void Add(double value)
        {
            Console.WriteLine($"Элемент {value} добавлен");

            if (_root == null)
            {
                _root = new Leaf(value);
                Count++;
                return;
            }

            IComponent current = _root;
            IComponent parent = null;
            bool goLeft = false;

            while (current is Node node)
            {
                parent = current;

                if (value < node.GetValue())
                {
                    if (node.Left == null)
                    {
                        current = null;
                        goLeft = true;
                        break;
                    }
                    current = node.Left;
                    goLeft = true;
                }
                else
                {
                    if (node.Right == null)
                    {
                        current = null;
                        goLeft = false;
                        break;
                    }
                    current = node.Right;
                    goLeft = false;
                }
            }

            if (current == null)
            {
                Node parentNode = (Node)parent;
                Leaf newLeaf = new Leaf(value);
                if (goLeft)
                {
                    parentNode.Left = newLeaf;
                }
                else
                {
                    parentNode.Right = newLeaf;
                }
                Count++;
                return;
            }

            Leaf leaf = (Leaf)current;
            Node newNode = new Node(leaf.GetValue(), null, null);

            if (parent == null)
            {
                _root = newNode;
            }
            else
            {
                Node parentNode = (Node)parent;

                if (leaf.GetValue() < parent.GetValue())
                {
                    parentNode.Left = newNode;
                }
                else
                {
                    parentNode.Right = newNode;
                }
            }

            if (value < newNode.GetValue())
            {
                newNode.Left = new Leaf(value);
            }
            else
            {
                newNode.Right = new Leaf(value);
            }

            Count++;
        }

        public double Min()
        {
            if (!IsEmpty())
            {
                IComponent current = _root;

                while (current is Node node && node.Left != null)
                {
                    current = node.Left;
                }

                Console.WriteLine($"Минимальный элемент = {current.GetValue()}");
                return current.GetValue();
            }
            else
            {
                throw new InvalidOperationException("Дерево пусто");
            }
        }

        public double Max()
        {
            if (!IsEmpty())
            {
                IComponent current = _root;

                while (current is Node node && node.Right != null)
                {
                    current = node.Right;
                }

                Console.WriteLine($"Максимальный элемент = {current.GetValue()}");
                return current.GetValue();
            }
            else
            {
                throw new InvalidOperationException("Дерево пусто");
            }
        }

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        private void FillList(IComponent element, List<double> values, ref int index)
        {
            if (element == null)
            {
                return;
            }
            if (element is Leaf leaf)
            {
                values.Add(leaf.GetValue());
                return;
            }

            Node node = (Node)element;

            FillList(node.Left, values, ref index);
            values.Add(node.GetValue());
            FillList(node.Right, values, ref index);
        }

        public List<double> GetAllValues()
        {
            List<double> values = new List<double>();
            int index = 0;
            FillList(_root, values, ref index);
            return values;
        }

        private bool Search(double value)
        {
            if (_root == null)
            {
                return false;
            }

            IComponent current = _root;
            while (true)
            {
                if (current is Leaf leaf)
                {
                    return leaf.GetValue() == value;
                }
                else
                {
                    Node node = (Node)current;
                    if (value < node.GetValue())
                    {
                        current = node.Left;
                    }
                    else if (value > node.GetValue())
                    {
                        current = node.Right;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Contains(double value)
        {
            if (Search(value))
            {
                Console.WriteLine($"Элемент {value} содержится в дереве");
                return true;
            }
            else
            {
                Console.WriteLine($"Элемент {value} отсутствует в дереве");
                return false;
            }
        }

        public bool IsEmpty()
        {
            return _root == null;
        }

        public void IsEmptyString()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Дерево пусто");
            }
            else
            {
                Console.WriteLine("Дерево не пусто");
            }
        }

        public void Clear()
        {
            Console.WriteLine("Дерево очищено");
            _root = null;
            Count = 0;
        }

        private int Height(IComponent element)
        {
            if (element == null)
            {
                return -1;
            }
            if (element is Leaf)
            {
                return 0;
            }

            Node node = (Node)element;
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        public int Height()
        {
            return Height(_root);
        }

        public override IEnumerator GetEnumerator()
        {
            return new BinaryTreeIterator(this, _direction);
        }
    }
}
