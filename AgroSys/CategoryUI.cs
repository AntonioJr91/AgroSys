namespace AgroSys
{
    internal class CategoryUI
    {
        public static void ShowCategoryHeader(string title)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");
        }
        public static void CategoryMenu()
        {
            MenuHelper.ShowMenu
                (
                    title: "Gerenciamento de Categorias",
                    actions:
                    [
                        CategoryController.AddCategoryFlow,
                        CategoryController.ShowCategoryList
                    ],
                    menuClosingMsg: "Voltar ao menu principal",
                    options: ["Adicionar Categoria", "Listar Categorias"]
                );
        }

        public static string ReadCategoryName() => Utils.ReadAndValidateInput<string>("Insira o nome: ");

        public static void ShowCategoryNotFoundMsg()
        {
            Console.Write("\nCategoria inexistente! Verifique os dados e tente novamente.");
            Console.ReadKey();
        }
        public static void ShowCategoryAddedMsg()
        {
            Console.Write("\nCategoria adicionada com sucesso!");
            Console.ReadKey();
        }

        public static void ShowCategoryTable(IEnumerable<Category> categories)
        {
            Console.WriteLine($"{"Id",-5} {"Nome",-20}");

            foreach (var c in categories)
            {
                Console.WriteLine($"{c.Id,-5} {c.Name,-20}");
            }

        }
        public static void ShowNoCategoryMsg()
        {
            Console.Write("\nNenhum categoria cadastrada.");
            Console.ReadKey();
        }

        public static void ShowCategoryNotFound()
        {
            Console.Write("\nCategoria não encontrada!");
            Console.ReadKey();
        }
    }
}