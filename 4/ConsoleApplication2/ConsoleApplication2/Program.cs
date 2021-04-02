using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication2
{
    internal class Program
    {
            [DllImport("DDL.dll", CallingConvention = CallingConvention.StdCall)]
            private static extern int Multiply(int a, int b);
            
            [DllImport("DDL.dll", CallingConvention = CallingConvention.StdCall)] 
            private static extern int Divide(int a, int b);
            
            [DllImport("DDL.dll", CallingConvention = CallingConvention.Cdecl)]
            private static extern int Pow(int a, int power);
            
            static void Main(string[] args)
            {
                Console.WriteLine("See? It`s works");
                Console.WriteLine("4 * 6 = " + Multiply(4, 6));
                Console.WriteLine("10 / 2 = " + Divide(10, 2));
                Console.WriteLine("2 ^ 3 = " + Pow(2, 3));

                Console.ReadKey();
            }
    }
}