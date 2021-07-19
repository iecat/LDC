using System.Collections.Generic;

namespace LDC
{
    public class ProcessString
    {
        public List<string> Process(List<string> strings)
        {
            if (strings.Count == 0) throw new System.ArgumentException("List should not be empty");
            List<string> result = new List<string>();

            foreach (var str in strings)
            {
                // the requirements doesn't specify what has to happen if the list contians empty string. 
                // an empty string when is processed will result an empty string => as per requirement output string shiuld not be empty
                // therefore, I seer 2 solutions
                // 1. If list contains empty string , throw an exception
                // 2. If list contains empty string, do not priocess the empty string 

                if (string.IsNullOrWhiteSpace(str)) throw new System.ArgumentException("List contains empty string");
                var newStr = str.ReplaceDuplicateChars()
                    .Replace('$', '£')
                    .RemoveChar('4')
                    .RemoveChar('_')
                    .TrimToLength(15);
                result.Add(newStr);
            }

            return result;
        }
    }
}
