using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node<T> : IComparable
    {
        T value;
        Node<T> left = null;
        Node<T> right = null;

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Node<T> Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node<T> Right
        {
            get { return right; }
            set { right = value; }
        }

        /// <summary>
        /// Compare to a <T> to an other <T>.
        /// Less than zero: This instance precedes obj in the sort order.
        /// Zero: This instance occurs in the same position in the sort order as obj.
        /// Greater than zero: This instance follows obj in the sort order.
        /// Throws InvalidOperationException() if the compared type is not valid.
        /// </summary>
        /// <param name="obj">Compared</param>
        public int CompareTo(object obj)
        {
            if (value.GetType().Name.ToLower() == "string")
            {
                string s1 = value.ToString();
                string s2 = obj.ToString();
                return s1.CompareTo(s2);
            }
            if (value.GetType().Name.ToLower() == "int")
            {
                int s1 = int.Parse(value.ToString());
                int s2 = int.Parse(obj.ToString());
                return s1.CompareTo(s2);
            }
            if (value.GetType().Name.ToLower() == "double")
            {
                double s1 = double.Parse(value.ToString());
                double s2 = double.Parse(obj.ToString());
                return s1.CompareTo(s2);
            }
            throw new InvalidOperationException();
        }

    }
}
