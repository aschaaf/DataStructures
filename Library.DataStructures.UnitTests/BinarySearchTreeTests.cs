using Library.DataStructures.Lists;
using Library.DataStructures.Trees;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void TestInitialize()
        {
            var tree = new BinarySearchTree();
            Assert.Equal(0, tree.Size());
        }

        [Fact]
        public void TestInOrderTraversal()
        {
            var expectedOrder = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var balancedTree = GenerateBalancedTree();
            LinkedList<int> result;
            balancedTree.InOrderTraversal(out result);

            for (int i = 0; i < expectedOrder.Length; i++)
            {
                Assert.Equal(expectedOrder[i], result.Get(i));
            }
        }

        [Fact]
        public void TestPreOrderTraversal()
        {
            var expectedOrder = new int[] { 4, 2, 1, 3, 6, 5, 7 };

            var balancedTree = GenerateBalancedTree();
            LinkedList<int> result;
            balancedTree.PreOrderTraversal(out result);

            for (int i = 0; i < expectedOrder.Length; i++)
            {
                Assert.Equal(expectedOrder[i], result.Get(i));
            }
        }

        [Fact]
        public void TestPostOrderTraversal()
        {
            var expectedOrder = new int[] { 1, 3, 2, 5, 7, 6, 4 };

            var balancedTree = GenerateBalancedTree();
            LinkedList<int> result;
            balancedTree.PostOrderTraversal(out result);

            for (int i = 0; i < expectedOrder.Length; i++)
            {
                Assert.Equal(expectedOrder[i], result.Get(i));
            }
        }

        [Fact]
        public void TestLevelOrderTraversal()
        {
            var expectedOrder = new int[] { 4, 2, 6, 1, 3, 5, 7 };

            var balancedTree = GenerateBalancedTree();
            LinkedList<int> result;
            balancedTree.LevelOrderTraversal(out result);

            for(int i = 0; i < expectedOrder.Length; i++)
            {
                Assert.Equal(expectedOrder[i], result.Get(i));
            }
        }

        private BinarySearchTree GenerateBalancedTree()
        {
            var balancedTree = new BinarySearchTree();
            balancedTree.Add(4);
            balancedTree.Add(2);
            balancedTree.Add(6);
            balancedTree.Add(1);
            balancedTree.Add(3);
            balancedTree.Add(5);
            balancedTree.Add(7);

            return balancedTree;
        }
    }
}
