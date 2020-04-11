using Library.DataStructures.Trees;

namespace Library.DataStructures.Algorithms
{
    public static class _HeapSort
    {
        public static void HeapSort(this int[] array)
        {
            var heap = new MaxHeap();

            for (int i = 0; i < array.Length; i++)
            {
                heap.Add(array[i]);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = heap.Poll();
            }
        }
    }
}
