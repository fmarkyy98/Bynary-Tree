using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree<T>
    {
        private Node<T> root = null;

        public void Add(Node<T> insertable)
        {
            insert(insertable, root);
        }
        private void insert(Node<T> insertable, Node<T> actual)
        {
            if (actual == null)
            {
                actual = insertable;
                return;
            }
            if (actual.CompareTo(insertable) > 0)
            {
                insert(insertable, root.Left);
                return;
            }
            if (actual.CompareTo(insertable) < 0)
            {
                insert(insertable, root.Right);
                return;
            }
        }
    }
}
