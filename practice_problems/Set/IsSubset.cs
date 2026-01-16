using System;
using System.Collections.Generic;

namespace Set 
{
    public class IsSubset //For check whether a set is a subset of another set
    {
        public static void Run()
        {
            HashSet<int> subset = new HashSet<int> { 2, 3 };
            HashSet<int> superset = new HashSet<int> { 1, 2, 3, 4 };//  superset is {1, 2, 3, 4}

            bool isSub = subset.IsSubsetOf(superset);//check whether subset is a subset of superset

            Console.WriteLine($"Subset: {{{string.Join(", ", subset)}}}");
            Console.WriteLine($"Superset: {{{string.Join(", ", superset)}}}");
            Console.WriteLine($"Is it a subset? {isSub}");
        }
    }
}
