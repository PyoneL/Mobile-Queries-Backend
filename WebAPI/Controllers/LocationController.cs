using Business.Abstract;
using Entities.Dto.TypeOne;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private IQueryExampleLocationService _queryExampleLocationService;

        public LocationController(IQueryExampleLocationService queryExampleLocationService)
        {
            _queryExampleLocationService = queryExampleLocationService;
        }

        [HttpPost("all")]
        public IActionResult QueryOne()
        {
            return Ok(_queryExampleLocationService.GetAllLocation());
        }
    }
}
