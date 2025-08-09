namespace AgroSys
{
    internal static class MenuHelper
    {
        public static void ShowMenu(string title, Action[] actions, string menuClosingMsg = "Sair", params string[] options)
        {
            var index = options.Length;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== {title} ===\n");

                for (int c = 0; c < index; c++)
                {
                    Console.WriteLine($"{c + 1}. {options[c]}");
                }

                Console.WriteLine($"0. {menuClosingMsg}");

                Console.Write("\nEscolha uma opção: ");
                string? option = Console.ReadLine();

                if (option == "0")
                {
                    Console.WriteLine("\nEncerrando o programa...");
                    break;
                }

                if (!int.TryParse(option, out int choice))
                {
                    Console.WriteLine("Entrada inválida! Verifique os dados e tente novamente...");
                    Console.ReadKey();
                    continue;
                }

                if (choice >= 1 && choice <= actions.Length)
                {
                    actions[choice - 1].Invoke();
                }
                else
                {
                    Console.Write("\nOpção inválida! Pressione qualquer tecla para retornar...");
                    Console.ReadKey();
                }
            }
        }
    }
}