using System;

namespace ConsoleApplication1
{
    public class Human : Person , IOrganisation , IComparable<Human>
    {
        public static int Count;

        public delegate void Example(string msg);

        public event Example beispliel;

        public void Cout(string msg)
        {
            beispliel?.Invoke(msg);
        }

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

        public void ShowOrganisation()
        {
            Console.WriteLine("None Orgnisation");
        }

        public int CompareTo(Human other)
        {
            if (this.Age > other.Age) return 1;
            if (this.Age < other.Age) return -1;
            return 0;
        }
    }
}