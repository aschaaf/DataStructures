namespace Library.DataStructures.Lists
{
    public class Queue<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Size = 0;

        public void Push(T value)
        {
            if (value == null)
            {
                return;
            }

            var node = new Node<T>(value);
            Size++;
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            Tail = Tail.Next;
        }

        public T Pop()
        {
            if (Head == null)
            {
                return default(T);
            }
            Size--;
            var temp = Head;
            Head = Head.Next;
            return temp.Value;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}
