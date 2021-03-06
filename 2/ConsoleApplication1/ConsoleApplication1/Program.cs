using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');

            int n = str.Length;
            for (int i = 0; i < n - i - 1; i++)
            {
                string temp = str[n - i - 1];
                str[n - i - 1] = str[i];
                str[i] = temp;
            }
            foreach (var words in str)
            {
                Console.Write(words + " ");
            }
        }
    }
}