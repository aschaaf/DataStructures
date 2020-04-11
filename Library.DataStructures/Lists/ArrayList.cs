using System;

namespace Library.DataStructures.Lists
{
    public class ArrayList<T>
    {
        private T[] items;
        private int count;

        public ArrayList()
        {
            count = 0;
            items = new T[100];
        }
        
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                if (index >= items.Length)
                {
                    var temp = new T[index + 1];
                    items.CopyTo(temp, 0);
                    items = temp;
                }
                items[index] = value;
            }
        }

        public void Add(T value)
        {
            if (count >= items.Length)
            {
                var temp = new T[items.Length + 1];
                items.CopyTo(temp, 0);
                items = temp;
            }
            items[count] = value;
            count++;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public int Count()
        {
            return count;
        }
    }
}
