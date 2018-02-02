using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree<T>
    {
        private Node<T> root;
        
        /// <summary>
        /// Adds the paramether into the BinaryTree.
        /// </summary>
        /// <param name="insertable">The <T> type value what you'd like to add.</param>
        public void Add(T insertable)
        {
            insert(insertable, root);
        }
        private void insert(T insertable, Node<T> actual)
        {
            if (actual == null)
            {
                actual = new Node<T>();
                actual.Value = insertable;
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
