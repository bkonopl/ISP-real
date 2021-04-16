namespace ConsoleApplication1
{
    public abstract class Person
    {
        public PersonInfo Info { get; set; }

        public Person(string name, Sex sex)
        {
            Info = new PersonInfo(name, sex);
        }

        /*public Person(Person other) : base(other)
        {
            
        }*/
    }
}
