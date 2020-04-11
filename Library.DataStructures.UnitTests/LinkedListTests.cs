using Xunit;
using Library.DataStructures.Lists;

namespace Library.DataStructures.UnitTests
{
    public class LinkedListTests
    {
        [Fact]
        public void TestInitialize()
        {
            var list = new LinkedList<string>();
            Assert.Equal(0, list.Size());
        }

        [Fact]
        public void TestAddValues()
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new LinkedList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            Assert.Equal(values.Length, list.Size());
            for (int i = 0; i < values.Length; i++)
            {
                Assert.Equal(values[i], list.Get(i));
            }
        }
        
        [Fact]
        public void TestPrint_NoExceptions()
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new LinkedList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            list.Print();

            Assert.Equal(values.Length, list.Size());
        }

        [Theory]
        [InlineData(0, new string[] { "test2", "test3" })]
        [InlineData(1, new string[] { "test1", "test3" })]
        [InlineData(2, new string[] { "test1", "test2" })]
        public void TestRemove(int index, string[] newValues)
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new LinkedList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            list.Remove(index);

            Assert.Equal(newValues.Length, list.Size());
            for (int i = 0; i < newValues.Length; i++)
            {
                Assert.Equal(newValues[i], list.Get(i));
            }
        }

        [Theory]
        [InlineData(0, new string[] { "insert", "test1", "test2", "test3" })]
        [InlineData(1, new string[] { "test1", "insert", "test2", "test3" })]
        [InlineData(2, new string[] { "test1", "test2", "insert", "test3" })]
        [InlineData(3, new string[] { "test1", "test2", "test3", "insert" })]
        public void TestInsertIntoIndex(int index, string[] newValues)
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new LinkedList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            list.InsertIntoIndex(index, "insert");

            Assert.Equal(newValues.Length, list.Size());
            for (int i = 0; i < newValues.Length; i++)
            {
                Assert.Equal(newValues[i], list.Get(i));
            }
        }

        [Theory]
        [InlineData(0, new string[] { "insert", "test2", "test3" })]
        [InlineData(1, new string[] { "test1", "insert", "test3" })]
        [InlineData(2, new string[] { "test1", "test2", "insert" })]
        public void TestReplaceIndex(int index, string[] newValues)
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new LinkedList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            list.ReplaceIndex(index, "insert");

            Assert.Equal(newValues.Length, list.Size());
            for (int i = 0; i < newValues.Length; i++)
            {
                Assert.Equal(newValues[i], list.Get(i));
            }
        }

        [Fact]
        public void TestHasCyclePositive()
        {
            var list = new LinkedList<int>();
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);

            list.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node2;

            var result = list.HasCycle();

            Assert.True(result);
        }

        [Fact]
        public void TestHasCycleNegative()
        {
            var list = new LinkedList<int>();
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);

            list.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            var result = list.HasCycle();

            Assert.False(result);
        }
    }
}
