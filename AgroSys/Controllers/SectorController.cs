using AgroSys.Managers;
using AgroSys.Models;
using AgroSys.UI;

namespace AgroSys.Controllers
{
    internal class SectorController
    {
        public static void AddSectorFlow()
        {
            SectorUI.ShowTitleProductHeader("Adicionar Setor");

            var sectorName = SectorUI.ReadSectorName();

            if (SectorManager.SectorCollection.Any(s => s.Name.Equals(sectorName, StringComparison.OrdinalIgnoreCase)))
            {
                SectorUI.ShowSectorExistsMsg();
                return;
            }

            Sector newSector = new(sectorName);

            SectorManager.AddSector(newSector);

            SectorUI.ShowSectorAddedMsg();
        }
        public static void ShowSectorList()
        {
            SectorUI.ShowTitleProductHeader("Lista de Setores");

            var sectorColletion = SectorManager.SectorCollection;

            if (!sectorColletion.Any())
            {
                SectorUI.ShowNoSectorMsg();
                return;
            }

            SectorUI.ShowSectorTable(sectorColletion);
            Console.ReadKey();
        }
    }
}
