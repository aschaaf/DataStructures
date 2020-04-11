using System;
using Library.DataStructures.Algorithms;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class SortTests
    {
        [Fact]
        public void TestQuickSort()
        {
            var array = GenerateRandomArray(100);
            array.QuickSort();
            ValidateSortedArray(array);
        }

        [Fact]
        public void TestHeapSort()
        {
            var array = GenerateRandomArray(100);
            array.HeapSort();
            ValidateSortedArray(array);
        }

        [Fact]
        public void TestMergeSort()
        {
            var array = GenerateRandomArray(100);
            array.MergeSort();
            ValidateSortedArray(array);
        }

        private int[] GenerateRandomArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new Random().Next(0, 100);
            }
            return array;
        }

        private void ValidateSortedArray(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                Assert.True(array[i - 1] <= array[i]);
            }
        }
    }
}
