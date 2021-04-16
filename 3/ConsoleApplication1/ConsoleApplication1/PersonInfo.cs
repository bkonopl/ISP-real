namespace ConsoleApplication1
{
    public struct PersonInfo
    {
        public string MainName { get; set; }
        public Sex Sex { get; set; }

        public PersonInfo(string mainName, Sex sex)
        {
            MainName = mainName;
            Sex = sex;
        }
    }
}
