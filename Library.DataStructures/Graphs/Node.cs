using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataStructures.Graphs
{
    public class Node<T>
    {
        public T Value;
        public bool IsVisited;
        public int DistanceFromSource;
        public Node<T> PreviousNode;
        public List<Edge<T>> Adjacent;

        public Node(T val)
        {
            Value = val;
            IsVisited = false;
            DistanceFromSource = int.MaxValue;
            Adjacent = new List<Edge<T>>();
        }
    }
}
