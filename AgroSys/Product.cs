namespace AgroSys
{
    internal class Product
    {
        public Product(string name, int amount, decimal value, Category category)
        {
            Id = ++_Id;
            Name = name;
            Amount = amount;
            Value = value;
            Category = category;
            Created_At = DateOnly.FromDateTime(DateTime.Now);
        }

        private static int _Id = 0;
        public int Id { get; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Value { get; set; }
        public Category Category { get; set; }
        public DateOnly Created_At { get; }
    }
}
