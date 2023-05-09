using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebAspReact01.Models;
using WebAspReact01.Services;

namespace WebAspReact01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDictionaryService _dictionaryService;

        public HomeController(ILogger<HomeController> logger, IDictionaryService dictionaryService)
        {
            _logger = logger;
            _dictionaryService = dictionaryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShowSelectEqipmentView() {

            ViewBag.MinesList = new SelectList(
                _dictionaryService.GetMines(), "Id", "Name", 1
            );

            ViewBag.EquipmentsList = new SelectList(
                _dictionaryService.GetPitsEquipments(1), "Id", "Name", 11
            );

            return View("EqipmentSelectorView", new EqipmentSelectorViewModel());
        }

        [HttpPost]
        public IActionResult SelectedEquipmentResult(EqipmentSelectorViewModel model) {

            ViewBag.MinesList = new SelectList(
                _dictionaryService.GetMines(), "Id", "Name", model.MineId ?? 1
            );

            ViewBag.EquipmentsList = new SelectList(
                _dictionaryService.GetPitsEquipments(1), "Id", "Name", model.EquipmentId ?? 11
            );

            model.SelectedEqipmentName = (model.MineId.HasValue && model.EquipmentId.HasValue)
                ? _dictionaryService.GetPitsEquipments(model.MineId.Value).FirstOrDefault(x => x.Id == model.EquipmentId)?.Name 
                : null;

            return View("EqipmentSelectorView", model);
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}