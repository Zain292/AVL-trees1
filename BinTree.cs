using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()//creates empty tree with no child nodes yet...
        {
            root = null;
        }

        public BinTree(Node<T> node) // Creating a tree with node as the root
        {
            root = node;
        }

        public void inOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree == null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + " , ";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void preOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + " , ";

                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

       





        




        




}
}