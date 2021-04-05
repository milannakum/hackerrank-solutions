using System;
using System.Collections.Generic;

namespace Day_23___BST_Level_Order_Traversal
{
    class Program
    {
        static Node insert(Node root, int data)
        {
            if (root == null)
                return new Node(data);
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
                root = insert(root, int.Parse(Console.ReadLine()));
            levelOrder(root);
        }

        static void levelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node current = queue.Dequeue();
                Console.Write(current.data + " ");
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
        }
    }

    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}