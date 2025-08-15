using AgroSys.Controllers;
using AgroSys.Helpers;
using AgroSys.Models;

namespace AgroSys.UI
{
    internal class MaterialUI : BaseUI<Material>
    {

        public static void Menu()
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

        public static void ShowMaterialTable(IEnumerable<Material> materials)
        {

            ShowTable(materials,
                m => new object[] { $"{m.Id,-5} {m.Name,-20} {m.Amount,-10:F3} {m.Value,-10:C} {m.Category.Name,-15} {m.Created_At,-15}" },
                new string[] { $"{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}" }
                );
        }
        public static void ShowMaterialAddedMsg() => ShowMessage("Material adicionado com sucesso!");
        public static void ShowMaterialExistsMsg() => ShowMessage("Este Material já está cadastrada.");
        public static void ShowMaterialNotFoundMsg() => ShowMessage("Material não encontrado!");
        public static void ShowNoMaterialMsg() => ShowMessage("Nenhuma Material cadastrada.");

    }
}