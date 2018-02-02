using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTree<T>
    {
        Node<T> root = null;

        public void Add(Node<T> insertable, Node<T> actula = this.root)
        {
            if (actula == null)
            {
                this.root = insertable;
                return;
            }
            if (actula.CompareTo(insertable) ==1)
            {
                root.Left = insertable;
            }
        }
    }
}
