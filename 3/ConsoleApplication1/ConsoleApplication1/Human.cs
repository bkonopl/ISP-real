using System;

namespace ConsoleApplication1
{
    public class Human : Person
    {
        public static int Count;
        public  string Name { get; set; }
        public  int Age { get; set; }
        public int Money { get; set; }
        public Human(string mainName, Sex sex, string name, int age) : base(mainName, sex)
        {
            this.Name = name;
            this.Age = age;
            this.Money = 0;
            Count++;
        }
        public Human(Human other) : this(other.Info.MainName, other.Info.Sex, other.Name, other.Age)
        {
            Count--;
            this.Money = 0;
        }
            
        public void CheckMoney()
        {
            Console.WriteLine("You have : " + this.Money);
        }
    }
}