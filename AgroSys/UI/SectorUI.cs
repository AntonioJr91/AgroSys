using AgroSys.Controllers;
using AgroSys.Helpers;
using AgroSys.Models;

namespace AgroSys.UI
{
    internal class SectorUI : BaseUI<Sector>
    {
        public static void Menu()

        {
            MenuHelper.ShowMenu
                (
                    "Gerenciamento de Setor",
                    [
                        SectorController.AddSectorFlow,
                        SectorController.ShowSectorList,
                    ],
                    "Voltar ao menu inicial",
                    "Adicionar Setor", "Listar Setores"
                );
        }
        public static string ReadSectorName() => Utils.ReadAndValidateInput<string>("Nome do Setor: ");

        public static void ShowSectorTable(IEnumerable<Sector> sectors)
        {
            ShowTable(sectors, s => new string[] { s.Name }, new string[] { "Nome" });
        }

        public static void ShowSectorAddedMsg() => ShowMessage("Setor adicionado com sucesso!");
        public static void ShowSectorExistsMsg() => ShowMessage("Este Setor já está cadastrado.");
        public static void ShowSectorNotFoundMsg() => ShowMessage("Setor não encontrado!");
        public static void ShowNoSectorMsg() => ShowMessage("Nenhum setor cadastrado.");
    }

}
