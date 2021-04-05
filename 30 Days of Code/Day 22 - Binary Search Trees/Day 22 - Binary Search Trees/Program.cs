using System;

namespace Day_22___Binary_Search_Trees
{
    class Program
    {
        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
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
            Console.WriteLine(getHeight(root));
        }

        static int getHeight(Node root)
        {
            int x = 0, y = 0;
            if (root.left == null && root.right == null)
                return 0;
            if (root.left != null)
                x = getHeight(root.left) + 1;
            if (root.right != null)
                y = getHeight(root.right) + 1;
            return Math.Max(x, y);
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