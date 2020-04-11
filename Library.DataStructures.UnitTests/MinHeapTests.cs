using Library.DataStructures.Lists;
using Library.DataStructures.Trees;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class MinHeapTests
    {
        [Fact]
        public void TestInitialize()
        {
            var heap = new MinHeap();
            Assert.Equal(0, heap.Size());
        }

        [Fact]
        public void TestPoll()
        {
            //var expectedOrder = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            var expectedOrder = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var heap = GenerateHeap();

            Assert.Equal(expectedOrder.Length, heap.Size());

            for(int i = 0; i < expectedOrder.Length; i++)
            {
                var result = heap.Poll();
                Assert.Equal(expectedOrder[i], result);
            }
        }

        private MinHeap GenerateHeap()
        {
            var heap = new MinHeap();
            heap.Add(4);
            heap.Add(2);
            heap.Add(6);
            heap.Add(1);
            heap.Add(3);
            heap.Add(5);
            heap.Add(7);

            return heap;
        }
    }
}
