using System;
using System.Collections.Generic;

namespace Set
{//For check whether two sets are equal
    public class SetsEqual //For check whether two sets are equal
    {
        public static void Run()//For check whether two sets are equal
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

            bool isEqual = set1.SetEquals(set2);//check whether set1 is equal to set2

            Console.WriteLine($"Set1: {{{string.Join(", ", set1)}}}");
            Console.WriteLine($"Set2: {{{string.Join(", ", set2)}}}");
            Console.WriteLine($"Are sets equal? {isEqual}");
        }
    }
}
