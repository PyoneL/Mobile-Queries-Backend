using Business.Abstract;
using Entities.Dto.TypeTree;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleThreeQueriesController : ControllerBase
    {
        private readonly IQueryExampleThreeService _queryExampleThreeService;


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

        [HttpPost("queryThree")]
        public IActionResult QueryThree()
        {
            return Ok(_queryExampleThreeService.QueryThree());
        }
    }
}