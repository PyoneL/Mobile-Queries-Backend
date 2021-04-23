using Business.Abstract;
using Entities.Dto.TypeTwo;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleTwoQueriesController : ControllerBase
    {
        private readonly IQueryExampleTwoService _queryExampleTwoService;

        public ExampleTwoQueriesController(IQueryExampleTwoService queryExampleTwoService)
        {
            _queryExampleTwoService = queryExampleTwoService;
        }


        [HttpPost("queryOne")]
        public IActionResult QueryOne(TypeTwo_ArticleOne_Input input)
        {
            return Ok(_queryExampleTwoService.QueryOne(input));
        }

        [HttpPost("queryTwo")]
        public IActionResult QueryTwo()
        {
            return Ok(_queryExampleTwoService.QueryTwo());
        }

        [HttpPost("queryThree")]
        public IActionResult QueryThree(TypeTwo_ArticleThree_Input input)
        {
            return Ok(_queryExampleTwoService.QueryThree(input));
        }
    }
}