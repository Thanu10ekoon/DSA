using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    public class BST
    {
        private TreeNode? Root;
        public BST()
        {
            Root = null;
        }

        public TreeNode InsertRecusively(int key, TreeNode? root)
        {
            if (root == null)
            {
                return new TreeNode(key);
            }

            if (key < root.Key)
            {
                root.Left = InsertRecusively(key, root.Left);
            }
            else if (key > root.Key)
            {
                root.Right = InsertRecusively(key, root.Right);
            }
            return root;
        }
        //Same Insert Function without recursion
        public void InsertIterativel(int key)
        {
            TreeNode current = Root;
            TreeNode parent = null;

            if(current == null) //empty tree
            {
                Root = new TreeNode(key);
                return;
            }

            while (current != null)
            {
                if (key > current.Key)
                {
                    parent = current;
                    current = current.Right;
                }
                else if (key < current.Key)
                {
                    parent = current;
                    current = current.Left;
                }
                else 
                {
                    return;//duplicate key
                }
            }
        }
        public void PrintInOrder(TreeNode? root)
        {
            if (root != null)
            {
                PrintInOrder(root.Left);
                Console.WriteLine(root.Key);
                PrintInOrder(root.Right);
            }
        }

        public void PrintPreOrder(TreeNode? root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Key);
                PrintPreOrder(root.Left);
                PrintPreOrder(root.Right);
            }
        }

        public void PrintPostOrder(TreeNode? root)
        {
            if (root != null)
            {
                PrintPostOrder(root.Left);
                PrintPostOrder(root.Right);
                Console.WriteLine(root.Key);
            }
        }

        public void Print()
        {
            PrintInOrder(Root);
        }

        public void Insert(int key)
        {
            Root = InsertRecusively(key, Root);
        }
    }

    //10 20 30 5 6 7 25
}
