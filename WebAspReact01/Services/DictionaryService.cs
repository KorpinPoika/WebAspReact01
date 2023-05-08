using WebAspReact01.Entities;

namespace WebAspReact01.Services
{
    public sealed class DictionaryService : IDictionaryService
    {
        private static readonly ICollection<Mine> _mines = new List<Mine> { 
            new Mine { Id = 1, Name = "Октябрьский" },
            new Mine { Id = 2, Name = "Северный" },
            new Mine { Id = 3, Name = "Кольский" }
        };

        private static readonly IDictionary<int, ICollection<PitsEquipment>> _pitsEqipmentsByMine = new Dictionary<int, ICollection<PitsEquipment>>{
            { 1, new List<PitsEquipment> { new PitsEquipment { Id = 11, Name = "ШАС 1" }, new PitsEquipment {Id = 12, Name = "ПДМ 1" }, new PitsEquipment {Id = 31, Name = "Анкероустановщик 1" } } },
            { 2, new List<PitsEquipment> { new PitsEquipment { Id = 21, Name = "ШАС 2" }, new PitsEquipment {Id = 22, Name = "ПДМ 2" }, new PitsEquipment {Id = 32, Name = "Анкероустановщик 2" } } },
            { 3, new List<PitsEquipment> { new PitsEquipment { Id = 31, Name = "ШАС 3" }, new PitsEquipment {Id = 32, Name = "ПДМ 3" }, new PitsEquipment {Id = 33, Name = "Анкероустановщик 3" } } }
        };

        public IEnumerable<Mine> GetMines() => _mines;

        public IEnumerable<PitsEquipment> GetPitsEquipments(int mineId) {
            if ( !_pitsEqipmentsByMine.ContainsKey(mineId) ) {
                throw new ArgumentException($"Wrong mineId {mineId}");
            }

            return _pitsEqipmentsByMine[mineId];
        }
    }
}
