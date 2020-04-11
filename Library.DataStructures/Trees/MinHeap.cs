using System;
using Library.DataStructures.Lists;

namespace Library.DataStructures.Trees
{
    public class MinHeap : Heap
    {
        public MinHeap() : base(new ArrayList<int>(), 0) { }

        public int Poll()
        {
            if (size == 0)
            {
                throw new Exception("Heap is empty");
            }

            int item = items[0];
            items[0] = items[size - 1];
            size--;
            HeapifyDown();

            return item;
        }

        public void Add(int item)
        {
            items[size] = item;
            size++;
            HeapifyUp();
        }

        public void HeapifyUp()
        {
            int index = size - 1;
            while (HasParent(index) && GetParent(index) > items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        public void HeapifyDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (items[index] < items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }
    }
}
