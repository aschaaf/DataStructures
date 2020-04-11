using System;
using System.Collections.Generic;
using System.Text;
using Library.DataStructures.Graphs;

namespace Library.DataStructures.Algorithms
{
    public static class DijkstrasAlgorithm<T>
    {
        public static void Run(Node<T> start)
        {
            start.DistanceFromSource = 0;
            start.IsVisited = true;

            var queue = new Queue<Edge<T>>();
            foreach (var edge in start.Adjacent)
            {
                queue.Enqueue(edge);
            }

            while (queue.Count > 0)
            {
                var currentEdge = queue.Dequeue();
                var currentNode = currentEdge.Source;
                var destinationNode = currentEdge.Destination;
                foreach (var edge in destinationNode.Adjacent)
                {
                    if (!edge.Destination.IsVisited)
                    {
                        queue.Enqueue(edge);
                    }
                }

                if (currentNode.DistanceFromSource + currentEdge.Weight < destinationNode.DistanceFromSource)
                {
                    destinationNode.DistanceFromSource = currentNode.DistanceFromSource + currentEdge.Weight;
                    destinationNode.PreviousNode = currentNode;
                }

                currentNode.IsVisited = true;
            }
        }
    }
}
