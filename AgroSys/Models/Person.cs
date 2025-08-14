using AgroSys.Enums;

namespace AgroSys.Models
{
    internal abstract class Person
    {
        protected Person(string name, string lastName, int age, PositionType position)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public PositionType Position { get; set; }
    }
}
