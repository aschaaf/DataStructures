using Library.DataStructures.Lists;
using Library.DataStructures.Graphs;

namespace Library.DataStructures.Algorithms
{
    public static class DijkstrasAlgorithm<T>
    {
        public static void Run(Graphs.Node<T> start)
        {
            start.DistanceFromSource = 0;
            start.IsVisited = true;

            var queue = new Queue<Edge<T>>();

            var current = start.Adjacent.Head;
            while (current != null)
            {
                var edge = current.Value;
                queue.Push(edge);
                current = current.Next;
            }

            while (queue.Size > 0)
            {
                var currentEdge = queue.Pop();
                var currentNode = currentEdge.Source;
                var destinationNode = currentEdge.Destination;

                var adjNode = destinationNode.Adjacent.Head;
                while (adjNode != null)
                {
                    var edge = adjNode.Value;
                    if(!edge.Destination.IsVisited)
                    {
                        queue.Push(edge);
                    }
                    adjNode = adjNode.Next;
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
