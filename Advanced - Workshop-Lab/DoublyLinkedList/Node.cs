
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedList;

namespace DoublyLinkedList
{
    public class Node
    {
        private int value;
        private Node next;
        private Node previous;

        public Node(int value, Node next = null, Node previous = null)
        {
            this.Value = value;
            this.Next = next;
            this.Previous = previous;
        }

        public int Value { get { return this.value; } set { this.value = value; } }

        public Node Next { get { return this.next; } set { this.next = value;} }

        public Node Previous { get { return this.previous; } set { this.previous = value; } }
    }
}
