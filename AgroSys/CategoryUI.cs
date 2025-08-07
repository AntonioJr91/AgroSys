namespace AgroSys
{
    internal class CategoryUI
    {
        public static void MenuCategory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciamento de categorias ===\n");
                Console.WriteLine("1. Adicionar categoria");
                Console.WriteLine("2. Listar categorias cadastradas");
                Console.WriteLine("0. Voltar ao menu principal");
                Console.Write("\nEscolha uma opção: ");
                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        HandleAddCategory();
                        break;
                    case "2":
                        DisplayList();
                        break;
                    case "0":
                        Console.WriteLine("\nSaindo do gerenciador de produtos...");
                        return;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

                Console.Write("\nPressione qualquer tecla para retornar...");
                Console.ReadKey();
            }
        }

        public static void HandleAddCategory()
        {
            Console.Clear();
            Console.WriteLine("=== Adicionando uma nova categoria ===\n");

            string name = Utils.ReadAndValidateInput<string>("Insira o nome: ");

            Category newCategory = new(name);

            ProductManager.AddCategory(newCategory);
        }
        public static void DisplayList()
        {
            Console.Clear();
            Console.WriteLine("=== Listagem de categorias ===\n");

            var CategoriesCollection = ProductManager.CategoriesCollection;

            if (!CategoriesCollection.Any())
            {
                Console.WriteLine("Nenhuma categoria cadastrado.");
                return;
            }

            Console.WriteLine($"{"Id",-5} {"Nome",-20}");
            foreach (var c in CategoriesCollection)
                Console.WriteLine($"{c.Id,-5} {c.Name,-20}");
        }
    }
}