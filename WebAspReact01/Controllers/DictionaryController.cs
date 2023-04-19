using Microsoft.AspNetCore.Mvc;
using WebAspReact01.Entities;
using WebAspReact01.Services;

namespace WebAspReact01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {
        private readonly ILogger<DictionaryController> _logger;
        private readonly IDictionaryService _dictionaryService;

        public DictionaryController(ILogger<DictionaryController> logger, IDictionaryService dictionaryService)
        {
            _logger = logger;
            _dictionaryService = dictionaryService;
        }
        
        [HttpGet("MiningEquipDict")]
        public async Task<ActionResult<IEnumerable<MiningEquipment>>> GetMiningEquipmentsAsync() 
        {
            try
            {
                var result = await Task.FromResult(
                    _dictionaryService.GetMiningEquipments()    
                );

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Getting minig equipments operation was failed with: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

    }
}
