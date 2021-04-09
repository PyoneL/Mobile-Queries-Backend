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
    public class TypeOneController : ControllerBase
    {
        IQueryService _queryService;
        public TypeOneController(IQueryService queryService)
        {
            _queryService = queryService;
        }

        [HttpGet]
        public IActionResult TypeOne()
        {
            return Ok("TypeOne Page");
        }

        [HttpPost]
        [Route("ArticleOne")]
        public IActionResult ArticleOne()
        {
            /*using (Context context = new Context())
            {
                var result = (from taxi in context.taxi_info
                              group taxi by taxi.PUDatetime.Date into g
                              select new
                              {
                                  PUDatetime = g.Key,
                                  passenger_count = g.Sum(p => p.passenger_count),
                              }).OrderByDescending(p => p.passenger_count).Take(5).ToList();

                return Ok(result);
            }*/
            return Ok(_queryService.TypeOne_ArticleOne());
        }
        
        [HttpPost]
        [Route("ArticleTwo")]
        public IActionResult ArticleTwo(TypeOne_ArticleTwo_Input input)
        {
            /*using (Context context = new Context())
            {
                var result = (from taxi in context.taxi_info
                              where taxi.trip_distance < distance 
                              group taxi by taxi.PUDatetime into g 
                              select new
                              {
                                  PUDatetime = g.Key,
                                  trip_distance = g.Sum(p => p.trip_distance),
                              }).OrderByDescending(p => p.trip_distance).Take(5).ToList();

                return Ok(result);
            }*/
            return Ok(_queryService.TypeOne_ArticleTwo(input));
        }
        
        [HttpPost]
        [Route("ArticleThree")]
        public IActionResult ArticleThree()
        {
            /*
            using (Context context = new Context())
            {
                var result = (from taxi in context.taxi_info  
                              select new
                              {
                                  PUDatetime = taxi.PUDatetime,
                                  trip_distance = taxi.trip_distance,
                              }).OrderByDescending(p=>p.trip_distance).Take(5).ToList();

                return Ok(result);
            }*/
            return Ok(_queryService.TypeOne_ArticleThree());
        }
    }
}
