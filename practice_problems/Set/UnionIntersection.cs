using System;
using System.Collections.Generic;

namespace Set
{
    public class UnionIntersection//For find the union and intersection of two sets
    {
        public static void Run()    //For find the union and intersection of two sets
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };//set1 is {1, 2, 3}
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            HashSet<int> union = new HashSet<int>(set1);//union is {1, 2, 3}
            union.UnionWith(set2);//union is {1, 2, 3, 4, 5}

            HashSet<int> intersection = new HashSet<int>(set1);//intersection is {1, 2, 3}
            intersection.IntersectWith(set2);//intersection is {3}

            Console.WriteLine($"Set1: {{{string.Join(", ", set1)}}}");
            Console.WriteLine($"Set2: {{{string.Join(", ", set2)}}}");
            Console.WriteLine($"Union: {{{string.Join(", ", union)}}}");
            Console.WriteLine($"Intersection: {{{string.Join(", ", intersection)}}}");
        }
    }
}
