using System;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            Node node = new Node(1);
            Node node1 = new Node(2);
            Node node2 = new Node(3);
            Node node3 = new Node(4);
            Node node4 = new Node(5);

            node.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            Node current = node;

            while (current != null)
            {
                Console.WriteLine(current.Value);

                current = current.Next;
            }
        }
    }
}
