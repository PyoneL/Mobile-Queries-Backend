using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IQueryExampleLocationService _queryExampleLocationService;

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