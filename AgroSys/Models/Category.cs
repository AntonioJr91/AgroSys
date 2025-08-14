namespace AgroSys.Models
{
    internal class Category
    {
        public Category(string name)
        {
            Id = ++_Id;
            Name = name;
        }

        private static int _Id = 0;
        public int Id { get; }
        public string Name { get; set; } = string.Empty;
    }
}