using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Queue
{
    public class CustomQueue
    {
        private const int initialCapacity = 4;
        private const int firstElementINdex = 0;
        private int[] items;
        private int count;

        public CustomQueue()
        {
            this.items = new int[initialCapacity];
        }
        public int Count { get { return this.count; } private set { this.count = value; } }

        public void Enqueue(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;

            Count++;
        }

        public int Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!!!");
            }

            int removedItem = items[firstElementINdex];

            ShiftLeft();

            Count--;

            return removedItem;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!!!");
            }

            int removedItem = items[firstElementINdex];

            return removedItem;
        }

        public void Clear()
        {
            this.items = new int[initialCapacity];

            Count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currItem = items[i];

                action(currItem);
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ShiftLeft()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }
    }
}
