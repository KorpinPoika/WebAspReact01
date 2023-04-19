using WebAspReact01.Entities;

namespace WebAspReact01.Services
{
    public class DictionaryService : IDictionaryService
    {
        public IEnumerable<MiningEquipment> GetMiningEquipments() => new[] {
            new MiningEquipment{ Name = "ШАС" },
            new MiningEquipment{ Name = "ПДМ" },
            new MiningEquipment{ Name = "Анкероустановщик" }
        };
    }
}
