using System.Collections.Generic;
using Library.DataStructures.Algorithms;

namespace Library.DataStructures.Graphs
{
    public class Graph<T>
    {
        private Dictionary<T, Node<T>> nodeLookup = new Dictionary<T, Node<T>>();

        private Node<T> GetNode(T key)
        {
            if (nodeLookup.ContainsKey(key))
            {
                return nodeLookup[key];
            }
            return null;
        }

        public void AddNode(T val)
        {
            var node = new Node<T>(val);
            nodeLookup.Add(val, node);
        }

        public void AddEdgeUndirected(T node1, T node2, int weight = 0, string description = null)
        {
            var n1 = GetNode(node1);
            var n2 = GetNode(node2);
            n1.Adjacent.Add(new Edge<T>(n1, n2, weight, description));
            n2.Adjacent.Add(new Edge<T>(n2, n1, weight, description));
        }

        public void AddEdgeDirected(T source, T destination, int weight = 0)
        {
            var src = GetNode(source);
            var des = GetNode(destination);
            src.Adjacent.Add(new Edge<T>(src, des, weight));
        }

        public bool DepthFirstSearch(T source, T destination)
        {
            var src = GetNode(source);
            var des = GetNode(destination);
            return DepthFirstSearch<T>.HasPath(src, des);
        }

        public bool BreadthFirstSearch(T source, T destination)
        {
            var src = GetNode(source);
            var des = GetNode(destination);
            return BreadthFirstSearch<T>.HasPath(src, des);
        }

        public (int,List<T>) GetShortestPath(T source, T destination)
        {
            DijkstrasAlgorithm<T>.Run(GetNode(source));
            var distance = GetNode(destination).DistanceFromSource;
            var path = new List<T>();
            var currentNode = GetNode(destination);
            while (!currentNode.Value.Equals(source))
            {
                path.Add(currentNode.Value);
                currentNode = currentNode.PreviousNode;
            }
            path.Add(source);
            path.Reverse();
            return (distance, path);
        }
    }
}
