using System;
using System.Collections.Generic;

namespace Set
{
    public class SymmetricDifference
    {
        public static void Run()//For find the symmetric difference between two sets
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };//set1 is {1, 2, 3}
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            HashSet<int> symmetricDiff = new HashSet<int>(set1);
            symmetricDiff.SymmetricExceptWith(set2);

            Console.WriteLine($"Set1: {{{string.Join(", ", set1)}}}");
            Console.WriteLine($"Set2: {{{string.Join(", ", set2)}}}");
            Console.WriteLine($"Symmetric Difference: {{{string.Join(", ", symmetricDiff)}}}");//symmetricDiff is {1, 2, 4, 5}
        }
    }
}
