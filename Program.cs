using System;
using System.Text;

namespace BST
{
    class Node
    {
        public int Data;
        public Node Left, Right;
    }
    
    public class Program
    {
        private static StringBuilder str = new StringBuilder();
        static Node Insert(Node tree, int x)
        {
            if (tree == null)
            {
                tree = new Node();
                tree.Right = null;
                tree.Left = null;
                tree.Data = x;
                return tree;
            }

            if (tree.Data < x)
            {
                tree.Right = Insert(tree.Right, x);
                return tree;
            }
            else
            {
                tree.Left = Insert(tree.Left, x);
                return tree;
            }
        }
        
        static void InOrder(Node tree)
        {
            if(tree == null) return;
            InOrder(tree.Right);
            str.Append(tree.Data + " ");
            InOrder(tree.Left);
        }

        static void PreOrder(Node tree)
        {
            if(tree == null) return;
            str.Append(tree.Data + " ");
            PreOrder(tree.Right);
            PreOrder(tree.Left);
        }

        static void PostOrder(Node tree)
        {
            if(tree == null) return;
            PostOrder(tree.Right);
            PostOrder(tree.Left);
            str.Append(tree.Data + " ");
            
        }

        static void Main(string[] args)
        {
            Node root = null;
            root = Insert(root, 55);
            root = Insert(root, 104);
            root = Insert(root, 65);
            root = Insert(root, 34);
            root = Insert(root, 19);
            root = Insert(root, 12);
            root = Insert(root, 28);
            root = Insert(root, 98);

            InOrder(root);
            Console.WriteLine(str.ToString());
        }
    }
}
