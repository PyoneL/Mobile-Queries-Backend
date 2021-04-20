using System.Collections.Generic;
using Entities.Concrete;
using Entities.Dto.TypeOne;

namespace DataAccess.Abstract
{
    public interface IOperationLocationDal
    {
        List<Location> GetAllLocation();
        Location GetByLocationId(int locationId);
    }
}