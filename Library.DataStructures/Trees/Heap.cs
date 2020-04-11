using System;
using Library.DataStructures.Lists;

namespace Library.DataStructures.Trees
{
    public abstract class Heap
    {
        public int size;
        public ArrayList<int> items;

        public Heap(ArrayList<int> items, int size)
        {
            this.items = items;
            this.size = size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Peek()
        {
            if (size == 0)
            {
                throw new Exception("Heap is empty");
            }

            return items[0];
        }

        public void Swap(int index1, int index2)
        {
            int temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

        public int GetLeftChildIndex(int index)
        {
            return 2 * index + 1;
        }

        public int GetRightChildIndex(int index)
        {
            return 2 * index + 2;
        }

        public int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        public bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) < size;
        }

        public bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) < size;
        }

        public bool HasParent(int index)
        {
            return GetParentIndex(index) >= 0;
        }

        public int GetLeftChild(int index)
        {
            return items[GetLeftChildIndex(index)];
        }

        public int GetRightChild(int index)
        {
            return items[GetRightChildIndex(index)];
        }

        public int GetParent(int index)
        {
            return items[GetParentIndex(index)];
        }

        public int Size()
        {
            return size;
        }
    }
}
