using System;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class LabWorker : Worker , IOrganisation 
    { 
        public string SpecialTalent { get; set; }
        public int id { get; set; }
        public string Ficha { get; set;}
        public static int TeamCount;
        public LabWorker(Worker father, string specialTalent, string ficha) : base(father)
        {
            this.SpecialTalent = specialTalent;
            this.WorkPlace = "Lab of crazy items of the future";
            this.Ficha = ficha;
            this.Salary = 0;
            this.id++;
            TeamCount++;
            Team.data.Add(this);
        }
        public void MakeSomething()
        {
            Console.WriteLine(Ficha);
        }
        public override void GoToWork()
        {
            Console.WriteLine("Make crazy items of the future!!!");
        }

        public void ShowOrganisation()
        {
            Console.WriteLine("Lab of crazy things");
        }
    }
}