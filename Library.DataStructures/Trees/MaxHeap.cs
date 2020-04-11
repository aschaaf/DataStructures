using System;
using Library.DataStructures.Lists;

namespace Library.DataStructures.Trees
{
    public class MaxHeap : Heap
    {
        public MaxHeap() : base(new ArrayList<int>(), 0) { }

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
            while (HasParent(index) && GetParent(index) < items[index])
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
                int largestChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    largestChildIndex = GetRightChildIndex(index);
                }
                
                if (items[index] > items[largestChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, largestChildIndex);
                }

                index = largestChildIndex;
            }
        }
    }
}
