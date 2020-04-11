using Library.DataStructures.Lists;
using Xunit;
namespace Library.DataStructures.UnitTests
{
    public class QueueTests
    {
        [Fact]
        public void TestInitialize()
        {
            var queue = new Queue<string>();
            Assert.Equal(0, queue.Size);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void TestPush(int count)
        {
            var queue = new Queue<string>();

            for (int i = 0; i < count; i++)
            {
                queue.Push("test");
            }

            Assert.Equal(count, queue.Size);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void TestPop(int count)
        {
            var queue = new Queue<string>();
            var firstElement = "last";

            queue.Push(firstElement);
            for (int i = 0; i < count - 1; i++)
            {
                queue.Push("test");
            }
            Assert.Equal(count, queue.Size);

            var result = queue.Pop();
            Assert.Equal(firstElement, result);
            Assert.Equal(count - 1, queue.Size);
        }
    }
}
