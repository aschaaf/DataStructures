using System;
using Library.DataStructures.Lists;
using Library.DataStructures.Algorithms;

namespace Library.DataStructures.Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        private int size = 0;

        public int Size()
        {
            return size;
        }

        public void Add(int value)
        {
            var newNode = new Node(value);
            size++;
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Add(Root, newNode);
        }

        private void Add(Node node, Node newNode)
        {
            if (newNode.Value < node.Value)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = newNode;
                    newNode.Parent = node;
                    return;
                }

                Add(node.LeftChild, newNode);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = newNode;
                    newNode.Parent = node;
                    return;
                }

                Add(node.RightChild, newNode);
            }
        }

        public int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            return node.Height;
        }

        public Node RightRotate(Node node)
        {
            Node root = node.LeftChild;
            Node temp = root.RightChild;
            root.RightChild = node;
            node.LeftChild = temp;

            node.Height = Math.Max(Height(node.LeftChild), Height(node.RightChild)) + 1;
            root.Height = Math.Max(Height(root.LeftChild), Height(root.RightChild)) + 1;

            return root;
        }

        public Node LeftRotate(Node node)
        {
            Node root = node.RightChild;
            Node temp = root.LeftChild;
            root.LeftChild = node;
            node.RightChild = temp;

            node.Height = Math.Max(Height(node.LeftChild), Height(node.RightChild)) + 1;
            root.Height = Math.Max(Height(root.LeftChild), Height(root.RightChild)) + 1;

            return root;
        }

        public void PreOrderTraversal(out LinkedList<int> output)
        {
            output = new LinkedList<int>();
            Algorithms.PreOrderTraversal.Traverse(Root, output);
        }
        
        public void InOrderTraversal(out LinkedList<int> output)
        {
            output = new LinkedList<int>();
            Algorithms.InOrderTraversal.Traverse(Root, output);
        }
        
        public void PostOrderTraversal(out LinkedList<int> output)
        {
            output = new LinkedList<int>();
            Algorithms.PostOrderTraversal.Traverse(Root, output);
        }

        public void LevelOrderTraversal(out LinkedList<int> output)
        {
            output = new LinkedList<int>();
            Algorithms.LevelOrderTraversal.Traverse(new Queue<Node>(), Root, output);
        }
    }
}
