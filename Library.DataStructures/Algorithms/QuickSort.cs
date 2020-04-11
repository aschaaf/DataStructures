namespace Library.DataStructures.Algorithms
{
    public static class _QuickSort
    {
        public static void QuickSort(this int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    array.SwapPositions(i, j);
                }
            }

            array.SwapPositions(i + 1, high);
            return i + 1;
        }


        private static void SwapPositions(this int[] array, int index1, int index2)
        {
            var value1 = array[index1];
            array[index1] = array[index2];
            array[index2] = value1;
        }
    }
}
