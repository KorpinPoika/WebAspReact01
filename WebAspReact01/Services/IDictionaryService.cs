using WebAspReact01.Entities;

namespace WebAspReact01.Services
{
    public interface IDictionaryService
    {
        IEnumerable<MiningEquipment> GetMiningEquipments();
    }
}