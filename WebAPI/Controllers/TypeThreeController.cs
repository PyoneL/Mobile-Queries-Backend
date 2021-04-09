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
    public class TypeThreeController : ControllerBase
    {
        IQueryService _queryService;
        public TypeThreeController(IQueryService queryService)
        {
            _queryService = queryService;
        }
        [HttpGet]
        public IActionResult TypeTwo()
        {
            return Ok("TypeThree Page");
        }

        [HttpPost]
        [Route("ArticleOne")]
        public IActionResult ArticleOne(TypeThree_ArticleOne_Input input)
        {
            /*using (Context context = new Context())
            {
                var result = (from taxi in context.taxi_info
                              where taxi.PUDatetime.Date == FirstDate.Date
                              select new
                              {
                                  PUDatetime = taxi.PUDatetime,
                                  DODatetime = taxi.DODatetime,
                                  PULocationID = taxi.PULocationID,
                                  DOLocationID = taxi.DOLocationID,
                                  trip_distance = taxi.trip_distance,
                              }).OrderByDescending(p=> p.trip_distance).Take(1).ToList(); 
                
                return Ok(result);
            }*/
            return Ok(_queryService.TypeThree_ArticleOne(input));
        }
        
        [HttpPost]
        [Route("ArticleTwo")]
        public IActionResult ArticleTwo(TypeThree_ArticleTwo_Input input)
        {
            /*using (Context context = new Context())
            {
                DateTime FirstDate = new DateTime();
                FirstDate = Convert.ToDateTime("2020/12/01 15:00:00");
                int PULocationID = 41;
                var result = (from taxi in context.taxi_info
                              where taxi.PUDatetime.Date == FirstDate.Date && taxi.PULocationID == PULocationID
                              select new
                              {
                                PULocationID = taxi.PULocationID, 
                                DOLocationID = taxi.DOLocationID,
                              }).Take(5).ToList();

                return Ok(result);
            }*/
            return Ok(_queryService.TypeThree_ArticleTwo(input));
        }
        
        [HttpPost]
        [Route("ArticleThree")]
        public IActionResult ArticleThree()
        {/*
            using (Context context = new Context())
            {
                var result = (from taxi in context.taxi_info  
                              where taxi.passenger_count >= 3                              select new
                              {
                                  PULocationID = taxi.PULocationID,
                                  DOLocationID = taxi.DOLocationID,
                                  trip_distance = taxi.trip_distance,
                              }).OrderByDescending(p=>p.trip_distance).ToList();
                var result2 = new
                {
                    longest_trip = result.First(),
                    shortest_trip = result.Last(),
                };
                return Ok(result2);
            }*/
            return Ok(_queryService.TypeThree_ArticleThree());
        }
    }
}
