using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeTwoController : ControllerBase
    {
        IQueryService _queryService;
        public TypeTwoController(IQueryService queryService)
        {
            _queryService = queryService;
        }

        [HttpGet]
        public IActionResult TypeTwo()
        {
            return Ok("TypeTwo Page");
        }

        [HttpPost]
        [Route("ArticleOne")]
        public IActionResult ArticleOne(TypeTwo_ArticleOne_Input input)
        {
            /*using (Context context = new Context())
            {
                var result = new { 
                    taxi_count = (from taxi in context.taxi_info
                                  where taxi.PUDatetime >= FirstDate && taxi.PUDatetime <= SecondDate && taxi.PULocationID == PULocationID select new { id = taxi.ID }).Count() 
                };
                return Ok(result);
            }*/
            return Ok(_queryService.TypeTwo_ArticleOne(input));
        }

        [HttpPost]
        [Route("ArticleTwo")]
        public IActionResult ArticleTwo()
        {
            /*using (Context context = new Context())
            {
                var result = (from taxi in context.taxi_info
                              group taxi by taxi.PUDatetime.Date into g 
                              select new
                              {
                                PUDatetime = g.Key,
                                total_amount_avarage = g.Sum(p=> p.total_amount) / g.Select(p=>p.ID).Count(),
                              }
                              ).OrderBy(p => p.total_amount_avarage).ToList();

                var result2 = result.OrderBy(p => p.PUDatetime.Date).Take(2).ToList();

                var result3 = (from a in result
                               where a.PUDatetime.Date >= result2[0].PUDatetime.Date && a.PUDatetime.Date <= result2[1].PUDatetime.Date
                               select new
                               {
                                   PUDatetime = a.PUDatetime,
                                   total_amount_average = a.total_amount_avarage,
                               }).ToList();

                return Ok(result3);
            }*/
            return Ok(_queryService.TypeTwo_ArticleTwo());
        }
        
        [HttpPost]
        [Route("ArticleThree")]
        public IActionResult ArticleThree(TypeTwo_ArticleThree_Input input)
        {
            /*
            using (Context context = new Context())
            {
                
                var result = (from taxi in context.taxi_info  
                              where taxi.PUDatetime.Date >= input.FirstDate.Date && taxi.PUDatetime.Date <= input.SecondDate.Date
                              select new
                              {
                                  PUDatetime = taxi.PUDatetime,
                                  DODatetime = taxi.DODatetime,
                                  trip_distance = taxi.trip_distance,
                              }).OrderBy(p=>p.trip_distance).Take(5).ToList();

                return Ok(result);
            }*/
            return Ok(_queryService.TypeTwo_ArticleThree(input));
        }
    }
}
