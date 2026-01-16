using System;
namespace List
{
    public class FindFrequency
    {
        public static void Run()
        {
            List<String> element=new List<string>(){"apple", "banana", "apple", "orange"};
            Dictionary<string, int> freq=new Dictionary<string, int>();
          
               for (int i = 0; i < element.Count; i++)
            {
                if (!freq.ContainsKey(element[i]))
                {
                    // First time seeing this element → set count to 1
                    freq[element[i]] = 1;
                }
                else
                {
                    // Already exists → increment count
                    freq[element[i]]++;
                }
            }
  
  Console.WriteLine(string.Join(",",freq));
       

          

        }
    }
}