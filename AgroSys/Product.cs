namespace AgroSys
{
    internal class Product : IDisplayable
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

        public void DisplayDetails()
        {
            Console.WriteLine($"{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}");
            Console.WriteLine($"{Id,-5} {Name,-20} {Amount,-10} {Value,-10:C} {Category.Name,-15} {Created_At,-15}");
        }
    }
}
