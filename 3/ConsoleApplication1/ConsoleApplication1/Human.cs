using System;

namespace ConsoleApplication1
{
    public class Human
    {
        public string MainName { get; set; }
        public static int Count;
        public string Sex { get; set; }
        public  string Name { get; set; }
        public  int Age { get; set; }
        public int Money { get; set; }
        public Human(string mainName, string sex, string name, int age)
        {
            this.MainName = mainName;
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
            this.Money = 0;
            Count++;
        }
        public Human(Human other) : this(other.MainName, other.Sex, other.Name, other.Age)
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