using System;

namespace ConsoleApplication1
{
    public class Worker : Human
    {
        public string WorkPlace { get; set; }
        public int Salary { get; set; }
            
        public Worker(Human father, string workPlace, int salary) : base(father)
        {
            this.WorkPlace = workPlace;
            this.Salary = salary;
        }
        public Worker(Worker other) : base(other)
        {
            this.WorkPlace = other.WorkPlace;
            this.Money += this.Salary;
        }
        public void GoToWork()
        {
            Console.WriteLine("Congratulations you get your salary : " + this.Salary);
        }

    }
}