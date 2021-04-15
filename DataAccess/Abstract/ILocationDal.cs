using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ILocationDal
    {
        List<Location> GetAll();
    }
}