using WebAspReact01.Entities;

namespace WebAspReact01.Services
{
    public sealed class DictionaryService : IDictionaryService
    {
        private static readonly IDictionary<int, ICollection<PitsEquipment>> _pitsEqipments = new Dictionary<int, ICollection<PitsEquipment>>{
            { 1, new List<PitsEquipment> { new PitsEquipment { Name = "ШАС 1" }, new PitsEquipment { Name = "ПДМ 1" }, new PitsEquipment { Name = "Анкероустановщик 1" } } },
            { 2, new List<PitsEquipment> { new PitsEquipment { Name = "ШАС 2" }, new PitsEquipment { Name = "ПДМ 2" }, new PitsEquipment { Name = "Анкероустановщик 2" } } },
            { 3, new List<PitsEquipment> { new PitsEquipment { Name = "ШАС 3" }, new PitsEquipment { Name = "ПДМ 3" }, new PitsEquipment { Name = "Анкероустановщик 3" } } }
        };


        public IEnumerable<PitsEquipment> GetPitsEquipments(int mineId) {
            if ( !_pitsEqipments.ContainsKey(mineId) ) {
                throw new ArgumentException($"Wrong mineId {mineId}");
            }

            return _pitsEqipments[mineId];
        }
    }
}
