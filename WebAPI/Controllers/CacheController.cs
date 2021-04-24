using Business.Abstract;
using Entities.Dto.TypeOne;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private IMemoryCacheService _memoryCacheService;

        public CacheController(IMemoryCacheService memoryCacheService)
        {
            _memoryCacheService = memoryCacheService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_memoryCacheService.CacheRestore());

        }
    }
}