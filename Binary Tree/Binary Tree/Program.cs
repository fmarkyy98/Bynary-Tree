using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static BinaryTree<string> tree = new BinaryTree<string>();

        static void Main(string[] args)
        {
            tree.Add("Fejes Jennifer");
            tree.Add("Basa Richárd");
            tree.Add("Budaházy Bendegúz");
            tree.Add("Soós Barna");
            tree.Add("Gáspár Marcel");
            tree.Add("Fekete Márk");
            Console.ReadKey();
        }
    }
}
