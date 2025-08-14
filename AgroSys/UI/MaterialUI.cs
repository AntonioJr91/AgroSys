using AgroSys.Controllers;
using AgroSys.Helpers;
using AgroSys.Models;

namespace AgroSys.UI
{
    internal class MaterialUI
    {
        public static void ShowTitleProductHeader(string title)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");
        }
        public static void MenuProduct()
        {
            MenuHelper.ShowMenu
                (
                    "Gerenciamento de Produtos",
                    [
                        MaterialController.AddProductFlow,
                        MaterialController.ShowProductList,
                        MaterialController.SearchProductByName
                    ],
                    "Voltar ao menu inicial",
                    "Adicionar Produto", "Listar Produtos", "Pesquisar Produto"
                );
        }
        public static string ReadProductName() => Utils.ReadAndValidateInput<string>("Insira o nome: ");
        public static double ReadProductAmount() => Utils.ReadAndValidateInput<double>("Insira a quantidade: ");
        public static decimal ReadProductValue() => Utils.ReadAndValidateInput<decimal>("Insira o valor: R$");
        public static string ReadCategoryName() => Utils.ReadAndValidateInput<string>("Insira a categoria: ");
        public static void ShowProductAddedMsg()
        {
            Console.Write("\nProduto adicionado com sucesso!");
            Console.ReadKey();
        }
        public static void ShowProductTable(IEnumerable<Material> products)
        {
            Console.WriteLine($"{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id,-5} {p.Name,-20} {p.Amount,-10:F3} {p.Value,-10:C} {p.Category.Name,-15} {p.Created_At,-15}");
            }
        }

        public static void ShowProductExistsMsg()
        {
            Console.Write("\nEste produto já está cadastado.");
            Console.ReadKey();
        }
        public static void ShowNoProductMsg()
        {
            Console.Write("\nNenhum produto cadastrado.");
            Console.ReadKey();
        }
        public static void ShowProductNotFound()
        {
            Console.Write("\nProduto não encontrado!");
            Console.ReadKey();
        }
    }
}