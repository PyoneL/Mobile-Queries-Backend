using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICoordinateDal
    {
        Coordinate GetCordinate(Location location);
    }
}