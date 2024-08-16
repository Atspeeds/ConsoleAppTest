namespace ConsoleApp1
{
    internal class Details
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Details(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
