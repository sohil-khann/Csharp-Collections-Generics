using System;
namespace List
{
    public class RemoveDuplicate //For remeove duplicate
    {
        public static void Run() //main method
        {
            List<int> original=new List<int>(){3, 1, 2, 2, 3, 4};
            Console.WriteLine("Original list: "+string.Join(",",original) );

            List<int> duplicate=new List<int>();

            for(int i = 0; i < original.Count; i++)//iterate over original
            {
                if (!duplicate.Contains(original[i]))
                {
                    duplicate.Add(original[i]);
                }
            }

   Console.WriteLine("list of unique elements : "+string.Join(",",duplicate) );
        }
    }
}