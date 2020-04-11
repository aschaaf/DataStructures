namespace Library.DataStructures.Algorithms
{
    public class BinarySearch
    {
        public static bool Search(int[] array, int value)
        {
            return Search(array, value, 0, array.Length - 1);
        } 

        public static bool Search(int[] array, int value, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            int mid = (left + right) / 2;

            if (array[mid] == value)
            {
                return true;
            }
            else if (value < array[mid])
            {
                return Search(array, value, left, mid - 1);
            }
            else
            {
                return Search(array, value, mid + 1, right);
            }
        }
    }
}
