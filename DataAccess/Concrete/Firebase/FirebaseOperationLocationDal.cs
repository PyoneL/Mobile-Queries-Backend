using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationLocationDal : IOperationLocationDal
    {
        public List<Location> GetAllLocation()
        {
            var response = (from location in FirebaseLocationDal.GetAll()
                select location).OrderBy(p => p.Borough).ThenBy(p => p.Zone).ToList();

            return response;
        }

        public Location GetByLocationId(int locationId)
        {
            return FirebaseLocationDal.GetAll().SingleOrDefault(p => p.LocationId == locationId);
        }
    }
}