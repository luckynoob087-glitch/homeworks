using System;
using System.Collections.Generic;
using System.Text;

namespace homework_00
{
    internal class ArrayHelper
    {
        
        
            
            public void PrintReverse<T>(T[] arr)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);
                }
            }

           
            public T GetFirstElement<T>(T[] arr)
            {
                T first = arr[0];
                return first;
            }

           
            public T GetLastElement<T>(T[] arr)
            {
                T last = arr[arr.Length - 1];
                return last;
            }

            
            public bool ContainsElement<T>(T[] arr, T value)
            {
                bool found = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                    {
                        found = true;
                    }
                }

                return found;
            }

            
            public int CountElements<T>(T[] arr)
            {
                int count = 0;

                foreach (T item in arr)
                {
                    count = count + 1;
                }

                return count;
            }

            
            public int FindIndex<T>(T[] arr, T value)
            {
                int result = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                    {
                        result = i;
                        break;
                    }
                }

                return result;
            }
        }
    }

