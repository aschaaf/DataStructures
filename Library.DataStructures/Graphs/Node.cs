using Library.DataStructures.Lists;

namespace Library.DataStructures.Graphs
{
    public class Node<T>
    {
        public T Value;
        public bool IsVisited;
        public int DistanceFromSource;
        public Node<T> PreviousNode;
        public LinkedList<Edge<T>> Adjacent;

        public Node(T val)
        {
            Value = val;
            IsVisited = false;
            DistanceFromSource = int.MaxValue;
            Adjacent = new LinkedList<Edge<T>>();
        }
    }
}
