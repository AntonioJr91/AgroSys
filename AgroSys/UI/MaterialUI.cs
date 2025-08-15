using AgroSys.Controllers;
using AgroSys.Helpers;
using AgroSys.Models;

namespace AgroSys.UI
{
    internal class MaterialUI
    {
        public static void ShowTitleMaterialHeader(string title)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");
        }

        public static void MenuMaterial()
        {
            MenuHelper.ShowMenu
                (
                    "Gerenciamento de Materiais",
                    [
                        MaterialController.AddMaterialFlow,
                        MaterialController.ShowMaterialList,
                        MaterialController.SearchMaterialByName
                    ],
                    "Voltar ao menu inicial",
                    "Adicionar Material", "Listar Materiais", "Pesquisar Material"
                );
        }

        public static string ReadMaterialName() => Utils.ReadAndValidateInput<string>("Insira o nome: ");
        public static double ReadMaterialAmount() => Utils.ReadAndValidateInput<double>("Insira a quantidade: ");
        public static decimal ReadMaterialValue() => Utils.ReadAndValidateInput<decimal>("Insira o valor: R$");
        public static string ReadCategoryName() => Utils.ReadAndValidateInput<string>("Insira a categoria: ");

        public static void ShowMaterialTable(IEnumerable<Material> Materials)
        {
            Console.WriteLine($"{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}");
            foreach (var p in Materials)
            {
                Console.WriteLine($"{p.Id,-5} {p.Name,-20} {p.Amount,-10:F3} {p.Value,-10:C} {p.Category.Name,-15} {p.Created_At,-15}");
            }
        }

        public static void ShowMaterialAddedMsg()
        {
            Console.Write("\nMaterial adicionado com sucesso!");
            Console.ReadKey();
        }
        public static void ShowMaterialExistsMsg()
        {
            Console.Write("\nEste Material já está cadastado.");
            Console.ReadKey();
        }
        public static void ShowNoMaterialMsg()
        {
            Console.Write("\nNenhum Material cadastrado.");
            Console.ReadKey();
        }
        public static void ShowMaterialNotFound()
        {
            Console.Write("\nMaterial não encontrado!");
            Console.ReadKey();
        }
    }
}