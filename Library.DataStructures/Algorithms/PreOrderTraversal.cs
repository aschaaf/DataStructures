using System;
using System.Text;
using Library.DataStructures.Lists;
using Library.DataStructures.Trees;

namespace Library.DataStructures.Algorithms
{
    public static class PreOrderTraversal
    {
        public static void Traverse(Node node, LinkedList<int> output)
        {
            if (node == null)
            {
                return;
            }

            Console.Write($"{node.Value} ");
            output.Add(node.Value);
            Traverse(node.LeftChild, output);
            Traverse(node.RightChild, output);
        }
    }
}
