namespace AgroSys.UI
{
    internal abstract class BaseUI<T>
    {
        public static void ShowTitle(string title)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");
        }

        public static void ShowTable(IEnumerable<T> items, Func<T, object[]> getColumns, string[] headers)
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
        public static void ShowMessage(string message)
        {
            Console.Write($"\n{message}");
            Console.ReadKey();
        }
    }
}
