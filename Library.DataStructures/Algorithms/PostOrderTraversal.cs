using System;
using System.Text;
using Library.DataStructures.Lists;
using Library.DataStructures.Trees;


namespace Library.DataStructures.Algorithms
{
    public static class PostOrderTraversal
    {
        public static void Traverse(Node node, LinkedList<int> output)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.LeftChild, output);
            Traverse(node.RightChild, output);
            Console.Write($"{node.Value} ");
            output.Add(node.Value);
        }
    }
}
