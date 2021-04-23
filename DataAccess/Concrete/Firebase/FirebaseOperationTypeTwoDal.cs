using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Dto.TypeTwo;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationTypeTwoDal : IOperationTypeTwoDal
    {
        public List<TypeTwo_ArticleOne> TypeTwo_ArticleOne(TypeTwo_ArticleOne_Input input)
        {
            var result = new List<TypeTwo_ArticleOne>();

            var response = new
            {
                taxi_count = (from taxi in FirebaseOperationDal.GetAll()
                    where taxi.tpep_pickup_datetime >= input.FirstDate &&
                          taxi.tpep_pickup_datetime <= input.SecondDate &&
                          taxi.PULocationID == input.PULocationID
                    select new {id = taxi.passenger_count}).Count()
            };
            result.Add(new TypeTwo_ArticleOne
            {
                taxi_count = response.taxi_count
            });

            return result;
        }

        public List<TypeTwo_ArticleThree> TypeTwo_ArticleThree(TypeTwo_ArticleThree_Input input)
        {
            var result = new List<TypeTwo_ArticleThree>();

            var response = (from taxi in FirebaseOperationDal.GetAll()
                where taxi.tpep_pickup_datetime.Date >= input.FirstDate.Date &&
                      taxi.tpep_pickup_datetime.Date <= input.SecondDate.Date
                select new
                {
                    PUDatetime = taxi.tpep_pickup_datetime,
                    DODatetime = taxi.tpep_dropoff_datetime,
                    taxi.trip_distance
                }).OrderBy(p => p.trip_distance).Take(5).ToList();

            response.ForEach(p =>
            {
                result.Add(new TypeTwo_ArticleThree
                {
                    PUDatetime = p.PUDatetime,
                    DODatetime = p.DODatetime,
                    trip_distance = p.trip_distance
                });
            });
            return result;
        }

        public List<TypeTwo_ArticleTwo> TypeTwo_ArticleTwo()
        {
            var result = new List<TypeTwo_ArticleTwo>();

            var response = (from taxi in FirebaseOperationDal.GetAll()
                    group taxi by taxi.tpep_pickup_datetime.Date
                    into g
                    select new
                    {
                        PUDatetime = g.Key,
                        total_amount_average = g.Sum(p => p.total_amount) / g.Select(p => p.passenger_count).Count()
                    }
                ).OrderBy(p => p.total_amount_average).ToList();

            var response2 = response.Take(2).OrderBy(p => p.PUDatetime).ToList();

            var response3 = (from a in response
                where a.PUDatetime.Date >= response2[0].PUDatetime.Date &&
                      a.PUDatetime.Date <= response2[1].PUDatetime.Date
                select new
                {
                    a.PUDatetime, a.total_amount_average
                }).ToList();

            response3.ForEach(p =>
            {
                result.Add(new TypeTwo_ArticleTwo
                {
                    PUDatetime = p.PUDatetime,
                    total_amount_average = p.total_amount_average
                });
            });
            return result;
        }
    }
}