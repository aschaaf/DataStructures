using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataStructures.Trees
{
    public class Node
    {
        public int Value { get; set; }

        public Node Parent { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }
        
        public int Height { get; set; }

        public Node(int value)
        {
            Value = value;
            Height = 1;
        }
    }
}
