using System;
using System.Collections.Generic;
using Library.DataStructures.Algorithms;

namespace Library.DataStructures.Lists
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        private int size = 0;

        public void Add(T value)
        {
            var node = new Node<T>(value);

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = Tail.Next;
            }
            size++;
        }
        
        public void Remove(int index)
        {
            Node<T> prevNode = null;
            var node = Head;
            var count = 0;

            while (count != index)
            {
                if (node.Next == null)
                {
                    break;
                }
                prevNode = node;
                node = node.Next;
                count++;
            }

            if (prevNode == null)
            {
                Head = node.Next;
            }
            else
            {
                prevNode.Next = node.Next;
            }

            size--;
        }

        public void Print()
        {
            var node = Head;

            int count = 0;
            while (count < size)
            {
                if (!IsNull(node.Value))
                {
                    Console.WriteLine(node.Value);
                }
                else
                {
                    Console.WriteLine("[Empty]");
                }
                
                node = node.Next;
                count++;
            }
        }
        
        public T Get(int index)
        {
            var node = Head;
            var count = 0;

            while (count != index)
            {
                if (node.Next == null)
                {
                    break;
                }
                node = node.Next;
                count++;
            }

            return node.Value;
        }

        public void InsertIntoIndex(int index, T value)
        {
            if (index > size)
            {
                Console.WriteLine("Note: Index larger than Size of list, adding to end of list.");
                Add(value);
                return;
            }

            var node = new Node<T>(value);
            Node<T> prevNode = null;
            var current = Head;

            int count = 0;
            while (count < index)
            {
                prevNode = current;
                current = current.Next;
                count++;
            }

            node.Next = current;
            if (prevNode == null)
            {
                Head = node;
            }
            else
            {
                prevNode.Next = node;
            }
            size++;
        }

        public void ReplaceIndex(int index, T value)
        {
            if (index > size)
            {
                Console.WriteLine("Note: Index larger than Size of list, adding to end of list.");
                Add(value);
                return;
            }

            var node = new Node<T>(value);
            Node<T> prevNode = null;
            var current = Head;

            int count = 0;
            while (count < index)
            {
                prevNode = current;
                current = current.Next;
                count++;
            }

            node.Next = current.Next;
            if (prevNode == null)
            {
                Head = node;
            }
            else
            {
                prevNode.Next = node;
            }
        }

        public bool HasCycle()
        {
            return FloydsCycleFindingAlgorithm<T>.HasCycle(Head);
        }

        public int Size()
        {
            return size;
        }

        public Node<T> GetHead()
        {
            return Head;
        }

        private bool IsNull(T value)
        {
            return EqualityComparer<T>.Default.Equals(value, default(T));
        }
    }
}
