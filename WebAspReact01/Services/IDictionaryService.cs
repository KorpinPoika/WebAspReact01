using WebAspReact01.Entities;

namespace WebAspReact01.Services
{
    public interface IDictionaryService
    {
        IEnumerable<Mine> GetMines();
        IEnumerable<PitsEquipment> GetPitsEquipments(int mineId);
    }
}