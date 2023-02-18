using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList
    {
        private const int initialCapacity = 2;
        private int[] items;
        private int count;

        public CustomList()
        {
            this.items =new int[initialCapacity];
        }

        public int Count { get { return this.count; } private set { this.count = value; } }

        public int this[int index]
        {
            get
            {
                ValidateIndex(index);

                return this.items[index];
            }
            set
            {
                ValidateIndex(index);

                this.items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;

            Count++;
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int removedItem = items[index];

            items[index] = default(int);

            ShiftLeft(index);

            Count--;

            if (Count <= items.Length/4)
            {
                Shrink();
            }

            return removedItem;
        }

        public void Insert(int index, int item)
        {
            ValidateIndex(index);

            if (items.Length == Count)
            {
                Resize();
            }

            ShiftRigh(index);

            items[index] = item;

            Count++;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;  
        }

        public void AddRange(int[] items)
        {
            foreach (int item in items)
            {
                Add(item);
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length*2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ShiftRigh(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }
    }
}
