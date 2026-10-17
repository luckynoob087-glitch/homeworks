using System;
using System.Collections.Generic;
using System.Text;

namespace homework7
{
    internal class CollectionHelper
    {

        // 1.
        public static void PrintReverse<T>(T[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        // 2.
        public static T GetFirstElement<T>(T[] arr)
        {
            return arr[0];
        }

        // 3.
        public static T GetLastElement<T>(T[] arr)
        {
            return arr[arr.Length - 1];
        }

        // 4.
        public static bool ContainsElement<T>(T[] arr, T value)
        {
            foreach (T item in arr)
            {
                if (item.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        // 5.
        public static int CountElements<T>(T[] arr)
        {
            int count = 0;
            foreach (T item in arr)
            {
                count++;
            }
            return count;
        }

        // 6. 
        public static int FindIndex<T>(T[] arr, T value)
        {
            int index = 0;
            foreach (T item in arr)
            {
                if (item.Equals(value))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
