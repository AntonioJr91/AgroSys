namespace AgroSys.Models
{
    internal class Sector
    {
        public Sector(string name)
        {
            Name = name;
        }

        public string Name { get; set; } = string.Empty;
    }
}