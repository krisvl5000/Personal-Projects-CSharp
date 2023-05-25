using System;

namespace _01._Hello_Softuni
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.IsSubsequence("acb", "ahbgdc"));
        }
    }

    public static class Solution
    {
        public static bool IsSubsequence(string s, string t)
        {
            var sList = s.ToList();
            var tList = t.ToList();

            var finalList = new List<char>();

            foreach (var t1 in sList)
            {
                foreach (var t2 in tList)
                {
                    if (t1 == t2)
                    {
                        finalList.Add(t1);
                        break;
                    }
                }
            }

            if (string.Join("", finalList) == s)
            {
                return true;    
            }

            return false;
        }
    }
}