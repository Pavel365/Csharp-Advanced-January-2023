using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack
{
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.items = new int[initialCapacity];
        }
        public int Count { get { return this.count; } private set { this.count = value; } }

        public void Push(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;

            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!!!");
            }

            int removedItem = items[Count - 1];

            Count--;

            return removedItem;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!!!");
            }

            int removedItem = items[Count - 1];

            return removedItem;
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
    }
}
