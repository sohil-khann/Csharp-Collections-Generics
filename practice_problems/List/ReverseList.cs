using System;
using System.Collections;

namespace List
{
    public class ReverseList //class for reverse a List,ArrayList
    {
        public static void Run() //Main method
        {
            ArrayList arrayList = new ArrayList() { 5, 2, 6, 4, 87, 2, 8 };

            Console.WriteLine("Original ArrayList:");
            PrintList(arrayList);

            ReverseByarrayList(arrayList);

            Console.WriteLine("Reversed ArrayList:");
            PrintList(arrayList);
            
            Console.WriteLine("Original List");
          List<int> ll = new List<int>() { 2, 6, 9, 7, 8, 2, 3 };
Console.WriteLine(string.Join(", ", ll));


           var a= ReverseByList(ll);
            Console.WriteLine("After reversing");
     Console.WriteLine(string.Join(", ", a));


        }
        public static List<Int32> ReverseByList(List<int> ll)
        {
            List<int> temp=new List<int>();
            int size=ll.Count();
            for(int i = size - 1; i >= 0; i--)
            {
                temp.Add(ll[i]);
            }
return temp;

        }

        // Method to reverse ArrayList manually
        public static void ReverseByarrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        // Helper method to print ArrayList
        public static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}