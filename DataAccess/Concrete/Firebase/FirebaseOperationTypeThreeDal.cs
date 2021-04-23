using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Dto.TypeTree;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationTypeThreeDal : IOperationTypeThreeDal
    {
        private readonly IOperationLocationDal _operationLocation;
        private readonly ICoordinateDal _coordinateDal;
        
        
        public FirebaseOperationTypeThreeDal(IOperationLocationDal operationLocation, ICoordinateDal coordinateDal)
        {
            _operationLocation = operationLocation;
            _coordinateDal = coordinateDal;
        }

        public List<TypeThree_ArticleOne> TypeThree_ArticleOne(TypeThree_ArticleOne_Input input)
        {
            List<TypeThree_ArticleOne> result = new List<TypeThree_ArticleOne>();

            var response = (from taxi in FirebaseOperationDal.GetAll()
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
                var puLocation = _operationLocation.GetByLocationId(p.PULocationID);
                var doLocation = _operationLocation.GetByLocationId(p.DOLocationID);
                var puLocationCoordinate = _coordinateDal.GetCoordinate(puLocation);
                var doLocationCoordinate = _coordinateDal.GetCoordinate(doLocation);
                result.Add(new TypeThree_ArticleOne
                {
                    PUDatetime = p.PUDatetime,
                    DODatetime = p.DODatetime,
                    PULocation = string.Join(" - ",puLocation.Borough,puLocation.Zone),
                    DOLocationCoordinate = doLocationCoordinate,
                    PULocationCoordinate = puLocationCoordinate,
                    DOLocation = string.Join(" - ",doLocation.Borough,doLocation.Zone),
                    trip_distance = p.trip_distance,
                });
            });
            return result;
        }

        public List<TypeThree_ArticleTwo> TypeThree_ArticleTwo(TypeThree_ArticleTwo_Input input)
        {
            List<TypeThree_ArticleTwo> result = new List<TypeThree_ArticleTwo>();
            var response = (from taxi in FirebaseOperationDal.GetAll()
                where taxi.tpep_pickup_datetime.Date == input.FirstDate.Date && 
                      taxi.PULocationID == input.PULocationID
                select new
                {
                    taxi.PULocationID, taxi.DOLocationID,
                }).Take(5).ToList();

            response.ForEach(p =>
            {
                var puLocation = _operationLocation.GetByLocationId(p.PULocationID);
                var doLocation = _operationLocation.GetByLocationId(p.DOLocationID);
                var puLocationCoordinate = _coordinateDal.GetCoordinate(puLocation);
                var doLocationCoordinate = _coordinateDal.GetCoordinate(doLocation);

                result.Add(new TypeThree_ArticleTwo
                {
                    PULocation = string.Join(" - ", puLocation.Borough, puLocation.Zone),
                    PULocationCoordinate = puLocationCoordinate,
                    DOLocation = string.Join(" - ", puLocation.Borough, puLocation.Zone),
                    DOLocationCoordinate = doLocationCoordinate,
                });
            });
            return result;
        }

        public List<TypeThree_ArticleThree> TypeThree_ArticleThree()
        {
            List<TypeThree_ArticleThree> result = new List<TypeThree_ArticleThree>();

            var response = (from taxi in FirebaseOperationDal.GetAll()
                where taxi.passenger_count >= 3                              select new
                {
                    taxi.PULocationID,
                    taxi.DOLocationID,
                    taxi.trip_distance,
                }).OrderByDescending(p=>p.trip_distance).ToList();
            result.Add(new TypeThree_ArticleThree
            {
                
             
                longest_trip = new row { 
                    PULocationCoordinate = _coordinateDal.GetCoordinate(_operationLocation.GetByLocationId(response.First().PULocationID)),
                    DOLocationCoordinate = _coordinateDal.GetCoordinate(_operationLocation.GetByLocationId(response.First().DOLocationID)),
                    
                    PULocation = string.Join(" - ", _operationLocation.GetByLocationId(response.First().PULocationID).Borough, _operationLocation.GetByLocationId(response.First().PULocationID).Zone),
                    DOLocation = string.Join(" - ", _operationLocation.GetByLocationId(response.First().DOLocationID).Borough, _operationLocation.GetByLocationId(response.First().DOLocationID).Zone),
                    trip_distance = response.First().trip_distance,
                },
                shortest_trip = new row
                {
                    PULocationCoordinate = _coordinateDal.GetCoordinate(_operationLocation.GetByLocationId(response.Last().PULocationID)),
                    DOLocationCoordinate = _coordinateDal.GetCoordinate(_operationLocation.GetByLocationId(response.Last().DOLocationID)),
                    
                    PULocation = string.Join(" - ", _operationLocation.GetByLocationId(response.Last().PULocationID).Borough, _operationLocation.GetByLocationId(response.Last().PULocationID).Zone),
                    DOLocation = string.Join(" - ", _operationLocation.GetByLocationId(response.Last().DOLocationID).Borough, _operationLocation.GetByLocationId(response.Last().DOLocationID).Zone),
                    trip_distance = response.Last().trip_distance,
                },
            });
            return result;
        }
    }
}