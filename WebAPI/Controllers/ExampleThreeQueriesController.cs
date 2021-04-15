using Business.Abstract;
using Entities.Dto.TypeTree;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleThreeQueriesController : ControllerBase
    {
        private IQueryExampleThreeService _queryExampleThreeService;


        public ExampleThreeQueriesController(IQueryExampleThreeService queryExampleThreeService)
        {
            _queryExampleThreeService = queryExampleThreeService;
        }

        [HttpPost("queryOne")]
        public IActionResult QueryOne(TypeThree_ArticleOne_Input input)
        {
            return Ok(_queryExampleThreeService.QueryOne(input));
        }
        [HttpPost("queryTwo")]
        public IActionResult QueryTwo(TypeThree_ArticleTwo_Input input)
        {
            return Ok(_queryExampleThreeService.QueryTwo(input));
        }
        [HttpGet("queryTree")]
        public IActionResult QueryTree()
        {
            return Ok(_queryExampleThreeService.QueryThree());
        }
    }
}