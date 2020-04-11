using Library.DataStructures.Trees;
using Library.DataStructures.Lists;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class AVLTreeTests
    {
        [Theory]
        [InlineData(new int[1] { 43 }, new int[1] { 43 }, 1)]
        [InlineData(new int[2] { 43, 18 }, new int[2] { 43, 18 }, 2)]
        [InlineData(new int[3] { 43, 18, 22 }, new int[3] { 22, 18, 43 }, 2)]
        [InlineData(new int[6] { 43, 18, 22, 9, 21, 6}, new int[6] { 18, 9, 22, 6, 21, 43 }, 3)]
        [InlineData(new int[7] { 43, 18, 22, 9, 21, 6, 8 }, new int[7] { 18, 8, 22, 6, 9, 21, 43 }, 3)]
        [InlineData(new int[10] { 43, 18, 22, 9, 21, 6, 8, 20, 63, 50 }, new int[10] { 18, 8, 22, 6, 9, 21, 50, 20, 43, 63}, 4)]
        [InlineData(new int[12] { 43, 18, 22, 9, 21, 6, 8, 20, 63, 50, 62, 51 }, new int[12] { 22, 18, 50, 8, 21, 43, 62, 6, 9, 20, 51, 63}, 4)]
        public void TestAddAVL(int[] input, int[] expectedOutput, int expectedHeight)
        {
            var tree = new AVLTree();

            for(int i = 0; i < input.Length; i++)
            {
                tree.AddAVL(input[i]);
            }
            
            var output = new LinkedList<int>();
            tree.LevelOrderTraversal(out output);
            Assert.Equal(expectedHeight, tree.Root.Height);
            for(int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], output.Get(i));
            }
        }

    }
}
