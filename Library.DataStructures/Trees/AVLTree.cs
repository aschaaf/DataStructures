using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataStructures.Trees
{
    public class AVLTree : BinarySearchTree
    {
        public int GetBalance(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            return Height(node.LeftChild) - Height(node.RightChild);
        }

        public void AddAVL(int value)
        {
            Root = AddAVL(Root, value);
        }

        public Node AddAVL(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.LeftChild = AddAVL(node.LeftChild, value);
            }
            else if (value > node.Value)
            {
                node.RightChild = AddAVL(node.RightChild, value);
            }
            else
            {
                return node; // Duplicate keys not allowed  
            }

            // Update height
            node.Height = 1 + Math.Max(Height(node.LeftChild),Height(node.RightChild));

            int balance = GetBalance(node);
            // Right rotate
            if (balance > 1 && value < node.LeftChild.Value)
            {
                return RightRotate(node);
            }
            // Left rotate 
            if (balance < -1 && value > node.RightChild.Value)
            {
                return LeftRotate(node);
            }
            // Left Right rotate  
            if (balance > 1 && value > node.LeftChild.Value)
            {
                node.LeftChild = LeftRotate(node.LeftChild);
                return RightRotate(node);
            }
            // Right Left rotate  
            if (balance < -1 && value < node.RightChild.Value)
            {
                node.RightChild = RightRotate(node.RightChild);
                return LeftRotate(node);
            }
            
            return node;
        }
    }
}
