using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            string[] s = Console.ReadLine().Split(' ');
            List<string> v = new List<string>();
            int sz = 0;
            foreach (var word in s)
            {
                bool good = false;
                foreach (var c in word) 
                {
                for(char i = 'a'; i <= 'z'; i++)
                    if (char.ToUpper(i) != c || c != i)
                    {
                        good = true;
                    }
                }
                sz = Math.Max(sz, word.Length);
                if(good) v.Add(word);
            }
            
            foreach (var word in v)
            {
                Console.WriteLine(word.PadLeft(sz));
            }
            
        }
    }
}