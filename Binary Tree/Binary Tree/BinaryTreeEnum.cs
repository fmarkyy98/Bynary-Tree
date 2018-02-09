using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTreeEnum<T> : IEnumerator<T>
    {
        private Node<T> root;

        int position = -1;

        int Count
        {
            get
            {
                //TODO
                return 0;
            }
        }

        public BinaryTreeEnum(Node<T> root)
        {

            this.root = new Node<T>();
            //TODO
        }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
