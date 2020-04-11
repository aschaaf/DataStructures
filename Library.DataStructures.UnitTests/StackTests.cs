using Library.DataStructures.Lists;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class StackTests
    {
        [Fact]
        public void TestInitialize()
        {
            var stack = new Stack<string>();
            Assert.Equal(0, stack.Size);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void TestPush(int count)
        {
            var stack = new Stack<string>();

            for (int i = 0; i < count; i++)
            {
                stack.Push("test");
            }

            Assert.Equal(count, stack.Size);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void TestPop(int count)
        {
            var stack = new Stack<string>();
            var lastElement = "last";

            for(int i = 0; i < count-1; i++)
            {
                stack.Push("test");
            }
            stack.Push(lastElement);
            Assert.Equal(count, stack.Size);

            var result = stack.Pop();
            Assert.Equal(lastElement, result);
            Assert.Equal(count-1, stack.Size);
        }
    }
}
