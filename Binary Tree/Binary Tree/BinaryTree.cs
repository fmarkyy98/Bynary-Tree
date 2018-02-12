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

        class NodeEnumerator : IEnumerator<T>, IDisposable
        {
            List<Node<T>> states = new List<Node<T>>();
            Node<T> actual;
            public NodeEnumerator(Node<T> node) {
                if (node == null) return;
            }
            public T Current
            {
                get
                {
                    return states.Last().Value;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                if (states.Count == 0) return false;
                if (actual.Right != n) ;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            #region IDisposable Support
            private bool disposedValue = false; // To detect redundant calls

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // TODO: dispose managed state (managed objects).
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
                }
            }

            // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
            // ~NodeEnumerator() {
            //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            //   Dispose(false);
            // }

            // This code added to correctly implement the disposable pattern.
            public void Dispose()
            {
                // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
                Dispose(true);
                // TODO: uncomment the following line if the finalizer is overridden above.
                // GC.SuppressFinalize(this);
            }
            #endregion
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new NodeEnumerator(root);
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
