
using System;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Team team = new Team();

            Human person = new Human("Okarin", Sex.Male, "Hooin-kema", 20);
            Worker rabotyaga = new Worker(person, "workless",0 );
            rabotyaga.GoToWork();
            LabWorker shiz = new LabWorker(rabotyaga, "Make time paradoxe", "I am " + rabotyaga.Name);
            shiz.MakeSomething();  
            shiz.GoToWork();
            Console.WriteLine("Total humans = " + Human.Count);
            Console.WriteLine("Team of lab of crazy items of the future = " + LabWorker.TeamCount);
            
            //Human human = new Human("Mayoshi", "female", "mayoshi-nya", 17);
            //Worker rab1 = new Worker(human, "officiant", 300);
            //LabWorker girl = new LabWorker(rab1, "make a dress", "Ohaaayo Okarin");
            
            Human human = new Human("Mayoshi", Sex.Female, "mayoshi-nya", 17);
            Worker rab1 = new Worker(human, "officiant", 300);
            Worker girl = new LabWorker(rab1, "make a dress", "Ohaaayo Okarin");
            girl.GoToWork();
            
            Console.WriteLine(team[0].id);

        }
    }
}