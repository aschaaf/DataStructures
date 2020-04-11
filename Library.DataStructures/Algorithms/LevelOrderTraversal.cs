using System;
using Library.DataStructures.Lists;
using Library.DataStructures.Trees;

namespace Library.DataStructures.Algorithms
{
    public static class LevelOrderTraversal
    {
        public static void Traverse(Queue<Node> queue, Node node, LinkedList<int> output)
        {
            Console.Write($"{node.Value} ");
            output.Add(node.Value);
            queue.Push(node.LeftChild);
            queue.Push(node.RightChild);

            if (!queue.IsEmpty())
            {
                Traverse(queue, queue.Pop(), output);
            }
        }
    }
}
