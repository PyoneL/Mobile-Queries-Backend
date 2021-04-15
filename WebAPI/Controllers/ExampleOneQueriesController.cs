using Business.Abstract;
using Entities.Dto.TypeOne;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleOneQueriesController : ControllerBase
    {
        private IQueryExampleOneService _queryExampleOneService;

        public ExampleOneQueriesController(IQueryExampleOneService queryExampleOneService)
        {
            _queryExampleOneService = queryExampleOneService;
        }
        [HttpGet("queryOne")]
        public IActionResult QueryOne()
        {
            return Ok(_queryExampleOneService.QueryOne());
        }
        [HttpPost("queryTwo")]
        public IActionResult QueryTwo(TypeOne_ArticleTwo_Input input)
        {
            return Ok(_queryExampleOneService.QueryTwo(input));
        }
        [HttpGet("queryTree")]
        public IActionResult QueryTree()
        {
            return Ok(_queryExampleOneService.QueryThree());
        }
    }
}
