using System;
using System.Collections.Generic;
using System.Text;
using Library.DataStructures.Graphs;

namespace Library.DataStructures.Algorithms
{
    public static class BreadthFirstSearch<T>
    {
        public static bool HasPath(Node<T> source, Node<T> destination)
        {
            var nextToVisit = new Queue<Node<T>>();
            nextToVisit.Enqueue(source);

            while (nextToVisit.Count > 0)
            {
                var node = nextToVisit.Dequeue();

                if (node == destination)
                {
                    return true;
                }

                if (node.IsVisited)
                {
                    continue;
                }
                node.IsVisited = true;

                foreach (var neighbor in node.Adjacent)
                {
                    nextToVisit.Enqueue(neighbor.Destination);
                }
            }
            return false;
        }
    }
}
