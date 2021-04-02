using System;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Info info = Info.Get();
            
            Console.WriteLine(info);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}