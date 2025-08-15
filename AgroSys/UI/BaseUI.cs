namespace AgroSys.UI
{
    internal abstract class BaseUI<T>
    {
        protected abstract string EntityName { get; }

        public void ShowTitle(string title)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");
        }

        public void ShowTable(IEnumerable<T> items, Func<T, string[]> getColumns, string[] headers)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                Console.Write($"{headers[i],-20}");
            }
            Console.WriteLine();

            foreach (var item in items)
            {
                var columns = getColumns(item);
                foreach (var column in columns)
                {
                    Console.Write($"{column,-20}");
                }
                Console.WriteLine();
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine($"\n{message}");
            Console.ReadKey();
        }
    }
}
