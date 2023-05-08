using WebAspReact01.Entities;

namespace WebAspReact01.Services
{
    public interface IDictionaryService
    {
        IEnumerable<PitsEquipment> GetPitsEquipments(int mineId);
    }
}