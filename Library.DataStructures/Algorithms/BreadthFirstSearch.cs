using Library.DataStructures.Lists;

namespace Library.DataStructures.Algorithms
{
    public static class BreadthFirstSearch<T>
    {
        public static bool HasPath(Graphs.Node<T> source, Graphs.Node<T> destination)
        {
            var nextToVisit = new Queue<Graphs.Node<T>>();
            nextToVisit.Push(source);

            while (nextToVisit.Size > 0)
            {
                var node = nextToVisit.Pop();

                if (node == destination)
                {
                    return true;
                }

                if (node.IsVisited)
                {
                    continue;
                }
                node.IsVisited = true;

                var current = node.Adjacent.Head;
                while (current != null)
                {
                    var edge = current.Value;
                    nextToVisit.Push(edge.Destination);
                    current = current.Next;
                }
            }
            return false;
        }
    }
}
