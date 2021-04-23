using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IOperationLocationDal
    {
        List<Location> GetAllLocation();
        Location GetByLocationId(int locationId);
    }
}