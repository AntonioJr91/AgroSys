using AgroSys.Models;
using System.Collections.ObjectModel;

namespace AgroSys.Managers
{
    internal class SectorManager
    {
        private static readonly List<Sector> _sectorList = new();
        public static ReadOnlyCollection<Sector> SectorCollection => _sectorList.AsReadOnly();

        public static void AddSector(Sector sector)
        {
            _sectorList.Add(sector);
        }
    }
}
