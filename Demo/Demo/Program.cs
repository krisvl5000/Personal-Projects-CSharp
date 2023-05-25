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

    public class Solution
    {
        public static bool IsSubsequence(string s, string t)
        {
            var sList = s.ToList();
            var tList = t.ToList();

            var finalList = new List<char>();

            for (int i = 0; i < sList.Count; i++)
            {
                for (int j = 0; j < tList.Count; j++)
                {
                    if (sList[i] == tList[j])
                    {
                        if (j > sList.Count)
                        {
                            break;
                        }

                        finalList.Add(tList[i]);
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