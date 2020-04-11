using Library.DataStructures.Lists;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class ArrayListTests
    {
        [Fact]
        public void TestInitialize()
        {
            var list = new ArrayList<string>();
            Assert.Equal(0, list.Count());
        }

        [Fact]
        public void TestAddValues()
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new ArrayList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            Assert.Equal(values.Length, list.Count());
            for (int i = 0; i < values.Length; i++)
            {
                Assert.Equal(values[i], list[i]);
            }
        }

        [Fact]
        public void TestAddTooManyValues()
        {
            var length = 150;
            var values = new string[length];

            for(int i = 0; i < length; i++)
            {
                values[i] = "test";
            }

            var list = new ArrayList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            Assert.Equal(values.Length, length);
        }

        [Fact]
        public void TestPrint_NoExceptions()
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new ArrayList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            list.Print();

            Assert.Equal(values.Length, list.Count());
        }

        [Theory]
        [InlineData(0, new string[] { "insert", "test2", "test3" })]
        [InlineData(1, new string[] { "test1", "insert", "test3" })]
        [InlineData(2, new string[] { "test1", "test2", "insert" })]
        public void TestReplaceIndex(int index, string[] newValues)
        {
            var values = new string[] { "test1", "test2", "test3" };
            var list = new ArrayList<string>();

            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            list[index] = "insert";

            Assert.Equal(newValues.Length, list.Count());
            for (int i = 0; i < newValues.Length; i++)
            {
                Assert.Equal(newValues[i], list[i]);
            }
        }
    }
}
