using Entities.Concrete;
using Entities.Dto.TypeThree;

namespace DataAccess.Abstract
{
    public interface ICoordinateDal
    {
        CoordinateDto GetCoordinate(Location location);
    }
}