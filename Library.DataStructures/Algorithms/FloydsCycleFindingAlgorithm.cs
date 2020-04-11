using Library.DataStructures.Lists;

namespace Library.DataStructures.Algorithms
{
    public static class FloydsCycleFindingAlgorithm<T>
    {
        public static bool HasCycle(Node<T> head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
