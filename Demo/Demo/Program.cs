using System;

namespace _01._Hello_Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 2;
                Console.WriteLine(arr[i]);
            }
        }
    }
}