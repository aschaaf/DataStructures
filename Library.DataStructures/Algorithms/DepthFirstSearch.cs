using Library.DataStructures.Graphs;

namespace Library.DataStructures.Algorithms
{
    public static class DepthFirstSearch<T>
    {
        public static bool HasPath(Node<T> source, Node<T> destination)
        {
            if (source.IsVisited)
            {
                return false;
            }
            source.IsVisited = true;

            if (source == destination)
            {
                return true;
            }

            var current = source.Adjacent.Head;
            while (current != null)
            {
                var child = current.Value;
                if (HasPath(child.Destination, destination))
                {
                    return true;
                }
                current = current.Next;
            }
            
            return false;
        }
    }
}
