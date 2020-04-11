using System;
using System.Collections.Generic;
using System.Text;
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

            foreach (var child in source.Adjacent)
            {
                if (HasPath(child.Destination, destination))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
