using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 4, 2, 8, 3 };

            list.Sotr(false);

            Console.WriteLine("Hello World!");


        }
    }

    public static class EnumerableIntExtension
    {
        public static void Sotr(this List<int> arr, bool isToHide = true)
        {
            int temp;
            if (isToHide)
            {
                for (int j = 0; j <= arr.Count - 2; j++)
                {
                    for (int i = 0; i <= arr.Count - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j <= arr.Count - 2; j++)
                {
                    for (int i = 0; i <= arr.Count - 2; i++)
                    {
                        if (arr[i] < arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }
        }
    }
}
