using AgroSys.Controllers;
using AgroSys.Helpers;
using AgroSys.Models;

namespace AgroSys.UI
{
    internal class CategoryUI : BaseUI<Category>
    {
        public static void Menu()
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

        public static void ShowCategoryTable(IEnumerable<Category> categories)
        {
            ShowTable(categories, c => new object[] { c.Id, c.Name }, new string[] { "Id", "Nome" });

        }

        public static void ShowCategoryAddedMsg() => ShowMessage("Categoria adicionada com sucesso!");
        public static void ShowCategoryExistsMsg() => ShowMessage("Esta Categoria já está cadastrada.");
        public static void ShowCategoryNotFoundMsg() => ShowMessage("Categoria não encontrada!");
        public static void ShowNoCategoryMsg() => ShowMessage("Nenhuma setor cadastrada.");

    }
}