using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number("20/2", "Standart");
            Number example = new Number("22", "Single");
            Number exampleDouble = new Number("6.25", "Double");
            Number first = new Number(5, 10);
            Number second = new Number(12, 7);
            Number answer = first + second;
            Console.WriteLine(number.ToString("StdOutput"));
            Console.WriteLine(example.ToString("CeilOutput"));
            Console.WriteLine(exampleDouble.ToString("DoubleOutput"));
            Console.WriteLine(answer.ToString("StdOutput"));
        }
    }
}