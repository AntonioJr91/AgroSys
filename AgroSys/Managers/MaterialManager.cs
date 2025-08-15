using AgroSys.Models;
using System.Collections.ObjectModel;

namespace AgroSys.Managers
{
    internal class MaterialManager
    {
        private static readonly List<Material> _MaterialList = new();
        public static ReadOnlyCollection<Material> MaterialsCollection => _MaterialList.AsReadOnly();
        
        public static void AddMaterial(Material Material)
        {
            _MaterialList.Add(Material);
        }
    }
}