using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree<T> : IEnumerable<T>
    {
        private Node<T> root;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new BinaryTreeEnum(root); // Buggy
        }

        /// <summary>
        /// Adds the paramether into the BinaryTree.
        /// </summary>
        /// <param name="insertable">The <T> type value what you'd like to add.</param>
        public void Add(T insertable)
        {
            if (root == null) { root = new Node<T>(); }
            insert(insertable, root);
        }

        private void insert(T insertable, Node<T> actual)
        {
            if (actual.Value == null)
            {
                actual.Value = insertable;
                return;
            }
            if (actual.CompareTo(insertable) > 0)
            {
                if (actual.Left == null) { actual.Left = new Node<T>(); }
                insert(insertable, actual.Left);
                return;
            }
            if (actual.CompareTo(insertable) < 0)
            {
                if (actual.Right == null) { actual.Right = new Node<T>(); }
                insert(insertable, actual.Right);
                return;
            }
        }
    }
}
