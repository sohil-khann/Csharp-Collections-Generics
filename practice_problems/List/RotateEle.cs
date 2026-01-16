using System;
using System.Collections.Generic;

namespace List{
    public class RotateEle
    {
        public static void Run()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            int k = 2; // rotate by 2 positions

            Console.WriteLine("Original List: " + string.Join(", ", list));

            List<int> rotated = Rotate(list, k);

            Console.WriteLine("Rotated List: " + string.Join(", ", rotated));
        }

        public static List<int> Rotate(List<int> list, int k)
        {
            int n = list.Count;
            k = k % n; // handle cases where k > n

            List<int> result = new List<int>();

            // Add elements from k to end
            for (int i = k; i < n; i++)
            {
                result.Add(list[i]);
            }

            // Add elements from start to k-1
            for (int i = 0; i < k; i++)
            {
                result.Add(list[i]);
            }

            return result;
        }
    }
}