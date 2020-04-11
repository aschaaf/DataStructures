using System;
using Library.DataStructures.Algorithms;
using Xunit;

namespace Library.DataStructures.UnitTests
{
    public class SearchTests
    {
        [Fact]
        public void TestBinarySearch()
        {
            var numberToInclude = 55;
            var array = GenerateSortedArrayThatIncludesNumber(10, numberToInclude);

            var result = BinarySearch.Search(array, numberToInclude);

            Assert.True(result);
        }

        private int[] GenerateSortedArrayThatIncludesNumber(int length, int numberToInclude)
        {
            var array = GenerateRandomArrayThatIncludesNumber(length, numberToInclude);
            array.HeapSort();
            return array;
        }

        private int[] GenerateRandomArrayThatIncludesNumber(int length, int numberToInclude)
        {
            var array = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i == length/2)
                {
                    array[i] = numberToInclude;
                    continue;
                }
                array[i] = new Random().Next(0, 100);
            }
            return array;
        }
    }
}
