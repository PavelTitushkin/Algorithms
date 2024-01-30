namespace Algorithms
{
    public static class ArraySearch
    {
        public static int BinarySearch(int[] sortedArray, int target)
        {
            // поскольку в условии задачи не сказанно, что делать если приходить Null массив,
            // я считаю, что нет элемента и возвращаю -1.
            // Как альтернатива можно бросать исключение ArgumentNullException.
            if (sortedArray == null)
            {
                return -1;
            }

            var leftIndex = 0;
            var rightIndex = sortedArray.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (sortedArray[middleIndex] == target)
                {
                    return middleIndex;
                }
                if (sortedArray[middleIndex] < target)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }

            return -1;
        }
    }
}
