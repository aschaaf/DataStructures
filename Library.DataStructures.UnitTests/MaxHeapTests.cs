using Library.DataStructures.Trees;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class MaxHeapTests
    {
        [Fact]
        public void TestInitialize()
        {
            var heap = new MaxHeap();
            Assert.Equal(0, heap.Size());
        }

        [Fact]
        public void TestPoll()
        {
            var expectedOrder = new int[] { 7, 6, 5, 4, 3, 2, 1 };

            var heap = GenerateHeap();

            Assert.Equal(expectedOrder.Length, heap.Size());

            for (int i = 0; i < expectedOrder.Length; i++)
            {
                var result = heap.Poll();
                Assert.Equal(expectedOrder[i], result);
            }
        }

        private MaxHeap GenerateHeap()
        {
            var heap = new MaxHeap();
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
