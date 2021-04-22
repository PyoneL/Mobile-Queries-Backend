using Entities.Dto.TypeOne;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationTypeOneDal : IOperationTypeOneDal
    {
        public List<TypeOne_ArticleOne> TypeOne_ArticleOne()
        {
            var result = new List<TypeOne_ArticleOne>();
            var response = (from taxi in FirebaseOperationDal.GetAll()
                            group taxi by taxi.tpep_pickup_datetime.Date into g
                            select new
                            {
                                PUDatetime = g.Key,
                                passenger_count = g.Sum(p => p.passenger_count),
                            }).OrderByDescending(p => p.passenger_count).Take(5).ToList();

            response.ForEach(p =>
            {
                result.Add(new TypeOne_ArticleOne
                {
                    PUDatetime = p.PUDatetime,
                    passenger_count = p.passenger_count,
                });
            });
            return result;
        }
        public List<TypeOne_ArticleThree> TypeOne_ArticleThree()
        {
            List<TypeOne_ArticleThree> result = new List<TypeOne_ArticleThree>();

            var response = (from taxi in FirebaseOperationDal.GetAll()
                            select new
                            {
                                PUDatetime = taxi.tpep_pickup_datetime, taxi.trip_distance,
                            }).OrderByDescending(p => p.trip_distance).Take(5).ToList();

            response.ForEach(p =>
            {
                result.Add(new TypeOne_ArticleThree
                {
                    PUDatetime = p.PUDatetime,
                    trip_distance = p.trip_distance,
                });
            });

            return result;
        }
        public List<TypeOne_ArticleTwo> TypeOne_ArticleTwo(TypeOne_ArticleTwo_Input input)
        {
            List<TypeOne_ArticleTwo> result = new List<TypeOne_ArticleTwo>();

            var response = (from taxi in FirebaseOperationDal.GetAll()
                            where taxi.trip_distance < input.distance
                            group taxi by taxi.tpep_pickup_datetime into g
                            select new
                            {
                                PUDatetime = g.Key,
                                trip_distance = g.Sum(p => p.trip_distance),
                            }).OrderByDescending(p => p.trip_distance).Take(5).ToList();

            response.ForEach(p =>
            {
                result.Add(new TypeOne_ArticleTwo
                {
                    PUDatetime = p.PUDatetime,
                    trip_distance = p.trip_distance,
                });
            });
            return result;
        }
    }
}
