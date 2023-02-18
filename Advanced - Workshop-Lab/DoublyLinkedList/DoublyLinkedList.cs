
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private Node head;
        private Node tail;
        private int count;

        public Node Head { get { return this.head; } set { this.head = value; } }

        public Node Tail { get { return this.tail; } set { this.tail = value;} }

        public int Count { get { return this.count; } set { this.count = value;} }

        public void AddFirst(int value)
        {
            this.Count++;   
            Node node = new Node(value);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;

                return;
            }

            node.Next = this.Head;
            Head.Previous = node;
            Head = node;
        }

        public void AddLast(int value)
        {
            this.Count++;
            Node node = new Node(value);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;

                return;
            }

            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("The list is empty!!!");
            }

            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
            }
            Node oldHead = this.Head;
            this.Head = Head.Next;
            oldHead.Next = null;
            Head.Previous = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (Tail.Previous == null)
            {
                Tail = null;
                Head = null;
            }
            Node oldTail = this.Tail;
            Tail = Tail.Previous;

            oldTail.Previous = null;
            Tail.Next = null;

            Count--;
        }

        public int[] ToArray()
        {
            int[] array = new int [Count];
            int i = 0;


            ForEach(e => array[i++] = e );

            return array;
        }

        public void ForEach(Action<int> callback)
        {
            Node current = Head;

            while (current != null)
            {
                callback(current.Value);
                current = current.Next;
            }
        }

        public void ForEachReversed(Action<int> callback)
        {
            Node current = Tail;

            while (current != null)
            {
                callback(current.Value);
                current = current.Previous;
            }
        }
    }
}
