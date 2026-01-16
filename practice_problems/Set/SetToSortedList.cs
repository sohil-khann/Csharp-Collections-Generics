using System;
using System.Collections.Generic;
using System.Linq;

namespace Set//For convert a set to a sorted list
{
    public class SetToSortedList    //For convert a set to a sorted list
    {
        public static void Run()
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };//set is {5, 3, 9, 1}

            List<int> sortedList = set.ToList();
            sortedList.Sort();

            Console.WriteLine($"Input Set: {{{string.Join(", ", set)}}}");
            Console.WriteLine($"Sorted List: [{string.Join(", ", sortedList)}]");
        }
    }
}
