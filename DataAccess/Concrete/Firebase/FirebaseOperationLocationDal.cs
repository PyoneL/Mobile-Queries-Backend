using Entities.Dto.TypeOne;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.Location;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationLocationDal : FirebaseLocationDal, IOperationLocationDal
    {
        public List<Location> GetAllLocation() {
            
            var response = (from location in GetAll()
                            select location).ToList();

            return response;
        }
    }
}
