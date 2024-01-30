using Xunit;

namespace Algorithms.Tests
{
    public class ArraySearchTest
    {
        [Fact]
        public void BinarySearchFoundInTheMiddle()
        {
            // arrange
            var sortedArray = new [] { 1, 3, 5, 7, 9, 11, 13, 15 };
            var target = 7;

            // act
            var actual = ArraySearch.BinarySearch(sortedArray, target);

            // assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void BinarySearchFoundAtTheBeginning()
        {
            // arrange
            var sortedArray = new [] { 1, 3, 5, 7, 9, 11, 13, 15 };
            var target = 1;

            // act
            var actual = ArraySearch.BinarySearch(sortedArray, target);

            // assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void BinarySearchFoundAtTheEnd()
        {
            // arrange
            var sortedArray = new [] { 1, 3, 5, 7, 9, 11, 13, 15 };
            var target = 15;

            // act
            var actual = ArraySearch.BinarySearch(sortedArray, target);

            // assert
            Assert.Equal(sortedArray.Length - 1, actual);
        }

        [Fact]
        public void BinarySearchNotFound()
        {
            // arrange
            var sortedArray = new[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            var target = 8;

            // act
            var actual = ArraySearch.BinarySearch(sortedArray, target);

            // assert
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void BinarySearchEmptyArray()
        {
            // arrange
            var sortedArray = Array.Empty<int>();
            var target = 5;

            // act
            var actual = ArraySearch.BinarySearch(sortedArray, target);

            // assert
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void BinarySearchNullArray()
        {
            // arrange
            int[] sortedArray = null;
            var target = 5;

            // act
            var actual = ArraySearch.BinarySearch(sortedArray, target);

            // assert
            Assert.Equal(-1, actual);
        }
    }
}