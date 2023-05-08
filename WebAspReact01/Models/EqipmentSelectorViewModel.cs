using Microsoft.AspNetCore.Mvc.Rendering;
using WebAspReact01.Entities;

namespace WebAspReact01.Models
{
    public sealed class EqipmentSelectorViewModel {

        public int? MineId { get; set; }

        public int? EquipmentId { get; set; }

        public string? SelectedEqipmentName { get; set; }
    }
}
