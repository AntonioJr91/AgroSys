namespace AgroSys
{
    internal class Utils
    {
        public static T ReadAndValidateInput<T>(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine()!.Trim();

                if (typeof(T) == typeof(string) && !string.IsNullOrWhiteSpace(input))
                {
                    return (T)(object)input;
                }

                if (typeof(T) == typeof(int) && int.TryParse(input, out int convertedInt))
                {
                    return (T)(object)convertedInt;
                }

                if (typeof(T) == typeof(decimal) && decimal.TryParse(input, out decimal convertedDecimal))
                {
                    return (T)(object)convertedDecimal;
                }
                Console.WriteLine("Entrada inválida! Tente novamente.");
            }
        }
     
    }
}
