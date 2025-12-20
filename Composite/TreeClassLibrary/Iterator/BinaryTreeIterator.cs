using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeProject.TreeClassLibrary;

namespace CompositeProject.TreeClassLibrary.IteratorProject
{
    public class BinaryTreeIterator : Iterator
    {
        private BinaryTree _tree;
        private int _position = -1;
        private bool _reverse = false;

        public BinaryTreeIterator(BinaryTree tree, bool reverse = false)
        {
            _tree = tree;
            _reverse = reverse;

            if (reverse)
            {
                _position = tree.Count;
            }
        }

        public override object Current()
        {
            return _tree.GetAllValues()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _tree.Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _tree.Count - 1 : 0;
        }
    }
}
