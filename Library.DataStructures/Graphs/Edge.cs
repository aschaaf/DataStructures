namespace Library.DataStructures.Graphs
{
    public class Edge<T>
    {
        public Node<T> Source;
        public Node<T> Destination;
        public int Weight;
        public string Description;

        public Edge(Node<T> source, Node<T> destination, int weight, string description = null)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
            Description = description;
        }
    }
}
