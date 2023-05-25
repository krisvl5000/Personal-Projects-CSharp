using System;

namespace _01._Hello_Softuni
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.StrongPasswordChecker("NehtoSiTam235"));
        }
    }

    public class Solution
    {
        public static int StrongPasswordChecker(string password)
        {
            int result = 0;

            List<bool> boolList = new List<bool>();

            bool isOfValidLength = true;
            boolList.Add(isOfValidLength);

            bool hasLowercaseLetter = true;
            boolList.Add(hasLowercaseLetter);

            bool hasUppercaseLetter = true;
            boolList.Add(hasUppercaseLetter);

            bool doesNotRepeatCharacters = true;
            boolList.Add(doesNotRepeatCharacters);

            // Check if the length is valid
            if (password.Length < 6 || password.Length > 20)
            {
                isOfValidLength = false;
            }

            // Check if it contains lowercase letters
            if (!password.Any(x => char.IsLower(x)))
            {
                hasLowercaseLetter = false;
            }

            // Check if it contains uppercase letters
            if (!password.Any(x => char.IsUpper(x)))
            {
                hasUppercaseLetter = false;
            }

            // Check if it repeats characters
            var counter = 0;

            var charList = new List<char>();

            foreach (var ch in password)
            {
                counter++;

                charList.Add(ch);

                if (counter == 3 && charList.All(x => x == ch))
                {
                    doesNotRepeatCharacters = false;
                }
                else if (counter == 3) 
                {
                    charList.Clear();
                    counter = 0;
                }
            }

            return result;
        }
    }
}