using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataStructures.Lists
{
    public class Stack<T>
    {
        public Node<T> Top;
        public int Size = 0;

        public void Push(T value)
        {
            if (value == null)
            {
                return;
            }

            var node = new Node<T>(value);
            Size++;
            if (Top == null)
            {
                Top = node;
                return;
            }

            var temp = Top;
            Top = node;
            Top.Next = temp;
        }

        public T Pop()
        {
            if (Top == null)
            {
                return default(T);
            }

            Size--;
            var temp = Top;
            Top = Top.Next;
            return temp.Value;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
