using System;

namespace Day_24___More_Linked_Lists
{
    class Program
    {
        public static Node removeDuplicates(Node head)
        {
            Node tmp = head;
            while (tmp.next != null)
            {
                if (tmp.data == tmp.next.data)
                    tmp.next = tmp.next.next;
                else
                    tmp = tmp.next;
            }
            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);
            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(String[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
                head = insert(head, int.Parse(Console.ReadLine()));
            display(removeDuplicates(head));
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}