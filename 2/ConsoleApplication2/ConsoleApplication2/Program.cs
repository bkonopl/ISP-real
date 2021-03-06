using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int pos = s.IndexOf('.');
            int a = 0;
            for (int i = 0; i < pos; i++)
            {
                a *= 10;
                a += s[i] - '0';
            }
            // Console.Write(a);
            int step = 1;
            double b = 0;
            int n = s.Length;
            for (int i = n - 1; i > pos; i--)
            {
                step *= 10;
                b += (s[i] - '0') ;
                b /= 10;
            }
            // Console.Write(b);
            double ans = a + b;
            Console.Write(ans);
        }
    }
}