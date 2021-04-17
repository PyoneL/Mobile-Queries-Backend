using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Dto.TypeTree;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationTypeThreeDal : FirebaseOperationDal , IOperationTypeThreeDal
    {
        public List<TypeThree_ArticleOne> TypeThree_ArticleOne(TypeThree_ArticleOne_Input input)
        {
            List<TypeThree_ArticleOne> result = new List<TypeThree_ArticleOne>();

            var response = (from taxi in GetAll()
                where taxi.tpep_pickup_datetime.Date == input.FirstDate.Date
                select new
                {
                    PUDatetime = taxi.tpep_pickup_datetime,
                    DODatetime = taxi.tpep_dropoff_datetime,
                    taxi.PULocationID,
                    taxi.DOLocationID,
                    taxi.trip_distance,
                }).OrderByDescending(p => p.trip_distance).Take(1).ToList();

            response.ForEach(p =>
            {
                result.Add(new TypeThree_ArticleOne
                {
                    PUDatetime = p.PUDatetime,
                    DODatetime = p.DODatetime,
                    PULocationID = p.PULocationID,
                    DOLocationID = p.DOLocationID,
                    trip_distance = p.trip_distance,
                });
            });
            return result;
        }

        public List<TypeThree_ArticleTwo> TypeThree_ArticleTwo(TypeThree_ArticleTwo_Input input)
        {
            List<TypeThree_ArticleTwo> result = new List<TypeThree_ArticleTwo>();
            var response = (from taxi in GetAll()
                where taxi.tpep_pickup_datetime.Date == input.FirstDate.Date && 
                      taxi.PULocationID == input.PULocationID
                select new
                {
                    taxi.PULocationID, taxi.DOLocationID,
                }).Take(5).ToList();

            response.ForEach(p =>
            {
                result.Add(new TypeThree_ArticleTwo
                {
                    PULocationID = p.PULocationID,
                    DOLocationID = p.DOLocationID,
                });
            });
            return result;
        }

        public List<TypeThree_ArticleThree> TypeThree_ArticleThree()
        {
            List<TypeThree_ArticleThree> result = new List<TypeThree_ArticleThree>();

            var response = (from taxi in GetAll()
                where taxi.passenger_count >= 3                              select new
                {
                    taxi.PULocationID,
                    taxi.DOLocationID,
                    taxi.trip_distance,
                }).OrderByDescending(p=>p.trip_distance).ToList();
            result.Add(new TypeThree_ArticleThree
            {
                longest_trip = new row { 
                    PULocationID = response.First().PULocationID,
                    DOLocationID = response.First().DOLocationID,
                    trip_distance = response.First().trip_distance,
                },
                shortest_trip = new row
                {
                    PULocationID = response.Last().PULocationID,
                    DOLocationID = response.Last().DOLocationID,
                    trip_distance = response.Last().trip_distance,
                },
            });
            return result;
        }
    }
}