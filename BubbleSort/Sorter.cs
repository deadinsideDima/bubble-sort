using System;

// ReSharper disable InconsistentNaming
namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[]? array)
        {
            if (array != null)
            {
                bool change = true;
                while (change)
                {
                    change = false;
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int buf = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = buf;
                            change = true;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(array));
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[]? array)
        {
            BubbleSort(array);
        }
    }
}
